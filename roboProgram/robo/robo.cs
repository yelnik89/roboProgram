using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace robo
{
    public partial class robo : Form
    {
        private const string PROPERTY_URI = "/Properties";
        private const string THINGS_URI = "/Thingworx/Things";
        private bool cicleRun = false;
        private ThingsFactory factory;
        private AllThingsJson.Rootobject allThings;
        private Dictionary<string, Dictionary<string, string>> allThingsProperty;



        public robo()
        {
            InitializeComponent();
            authorizationType.SelectedIndex = 0;
            this.factory = new ThingsFactory();
        }

        private async void sendReqest_Click(object sender, EventArgs e)
        {
            bool error = false;
            string address = Address();
            if (address.Equals("")) error = true;
            if (authorizationType.SelectedIndex == 0)
            {
                if (uuid.Text.Length == 0)
                {
                    log("не указан Ключ!!!");
                    error = true;
                }
            }
            else if (authorizationType.SelectedIndex == 1)
            {
                if (login.Text.Length == 0)
                {
                    log("не указан логин!!!");
                    error = true;
                }
                if (password.Text.Length == 0)
                {
                    log("не введен пароль!!!");
                    error = true;
                }
            }

            if (!error)
            {
                if (authorizationType.SelectedIndex == 0) log("указанный ключ: " + uuid.Text);
                this.allThings = await getThingsAsync(address);
                if (this.allThings != null) CicleRequestStart.Enabled = true;
                this.allThingsProperty = new Dictionary<string, Dictionary<string, string>>(this.allThings.rows.Length);
                fullingThingList(this.allThings);
            }
        }

        private async void thingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllThingsJson.Row thing = (AllThingsJson.Row)thingList.SelectedItem;
            string json = await getPropertyAsync(thing.name);
            if (!json.Equals("Error"))
            {
                Dictionary<string, string> property = this.factory.getThing(json);
                fullingParams(property);
            }

        }

        private void CircleRequestStart_Click(object sender, EventArgs e)
        {
            if (cicleRun) stopCicleRequest();
            else startCicleRequest();
        }

        private async Task<AllThingsJson.Rootobject> getThingsAsync(string address)
        {
            HttpWebRequest req = request("GET", address);
            string json = await sendHttpRequestAsync(req);
            if (json.Equals("error")) return null;

            return JsonConvert.DeserializeObject<AllThingsJson.Rootobject>(json);
        }

        
        private async Task<string> getPropertyAsync(string name)
        {
            log("get Property");
            HttpWebRequest req = request("GET", PropertyAddress(name));
            string json = await sendHttpRequestAsync(req);
            return json;
        }

        private string getProperty(string name)
        {
            log("get Property");
            string address = PropertyAddress(name);
            string result = httpRequest("GET", address);
            return result;
        }

        private void fullingParams(Dictionary<string, string> dict)
        {
            paramFieldClin();
            if (dict == null) return;
            foreach(KeyValuePair<string, string> pair in dict)
            {
                if (pair.Key.Equals("name"))
                {
                    ThingName.Text = pair.Value;
                    continue;
                }
                if (pair.Key.Equals("description") || pair.Key.Equals("thingTemplate") || pair.Key.Equals("tags")) continue;
                ParamsNames.AppendText(pair.Key + Environment.NewLine);
                ParamsValues.AppendText(pair.Value + Environment.NewLine);
            }
        }

        private void fullingThingList(AllThingsJson.Rootobject allThings)
        {
            foreach (AllThingsJson.Row row in allThings.rows)
            {
                thingList.Items.Add(row);
            }

            thingList.SelectedIndex = 0;
        }

        private string httpRequest(string method, string url, string json = "")
        {
            HttpWebRequest req = request(method, url);

            if (method.Equals("POST") || method.Equals("PUT")) sendData(req, json);
            string result = sendRequest(req);

            return result;
        }

        private HttpWebRequest request(string method, string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            req.Method = method;
            authorization(req);
            req.Accept = "application/json";

            return req;
        }

        private void paramFieldClin()
        {
            ThingName.Text = null;
            ParamsValues.Text = null;
            ParamsNames.Text = null;
        }

        private void authorization(HttpWebRequest req)
        {
            string authInfo = login.Text + ":" + password.Text;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            if (authorizationType.SelectedIndex == 1) req.Headers["Authorization"] = "Basic " + authInfo;
            if (authorizationType.SelectedIndex == 0) req.Headers["appkey"] = uuid.Text;
        }

        private string AuthInfo()
        {
            string authInfo = "";
            if (authorizationType.SelectedIndex == 1)
            {
                authInfo = login.Text + ":" + password.Text;
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            }
            if (authorizationType.SelectedIndex == 0) authInfo = uuid.Text;
            return authInfo;
        }

        private string sendRequest(HttpWebRequest req)
        {
            string result;
            try
            {
                using (var responseStream = req.GetResponse().GetResponseStream())
                using (var reader = new StreamReader(responseStream))
                {
                    result = reader.ReadToEnd();
                    log(result);
                }
            }
            catch (Exception e)
            {
                log(e.Message);
                result = "error";
            }
            return result;
        }

        private async Task<string> sendHttpRequestAsync(HttpWebRequest req)
        {
            bool error = false;
            string result = "";
            await Task.Run(() =>
            {
                try
                {
                    using (var responseStream = req.GetResponse().GetResponseStream())
                    using (var reader = new StreamReader(responseStream))
                    {
                        result = reader.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    error = true;
                    result = e.Message;
                }
            });
            log(result);
            if (error) return "error";
            return result;

        }

        private void sendData(HttpWebRequest req, string json)
        {
            req.ContentType = "application/json";
            using (var requestStream = req.GetRequestStream())
            using (var streamWriter = new StreamWriter(requestStream))
            {
                streamWriter.Write(json);
            }
        }

        private void myIP_Click(object sender, EventArgs e)
        {
            httpRequest("GET", "https://api.myip.com");
        }

        private string Address()
        {
            bool error = false;
            string address = "http://" + ip.Text + ":" + port.Text + THINGS_URI;
            if (ip.Text.Equals(""))
            {
                log("не указан IP!!!");
                error = true;
            }
            if (port.Text.Equals(""))
            {
                log("не указан порт!!!");
                error = true;
            }
            if (!error)
            {
                return address;
            }
            else
            {
                return "";
            }
        }

        private string PropertyAddress(string name)
        {
            string address = Address() + "/" + name + PROPERTY_URI;
            if (address.Equals("")) return "";
            log(address);
            return address;
        }

        private string AuthorizationType()
        {
            string authType = "";
            if (authorizationType.SelectedIndex == 0) authType = "appkey";
            if (authorizationType.SelectedIndex == 1) authType = "Basic";
            return authType;
        }

        private void startCicleRequest()
        {
            CicleRequestStart.Text = "STOP";
            this.cicleRun = true;
            cicleMethod();
        }

        private void stopCicleRequest()
        {
            this.cicleRun = false;
            CicleRequestStart.Text = "START";
        }

        private async void cicleMethod()
        {
            Messenger messenger = new Messenger(AuthInfo(), Address(), AuthorizationType());
            string json;
            while (this.cicleRun)
            {
                foreach (AllThingsJson.Row row in this.allThings.rows)
                {
                    json = await getPropertyAsync(row.name);
                    if (this.allThingsProperty.ContainsKey(row.name)) this.allThingsProperty[row.name] = this.factory.getThing(json);
                    else this.allThingsProperty.Add(row.name, this.factory.getThing(json));
                    log(json);
                    if (!this.cicleRun) return;
                }
                await Task.Delay(temp());
            }
            
        }

        private int temp()
        {
            if (Temp.Text.Length == 0) return 0;
            else return int.Parse(Temp.Text);
        }

        private void log(string text)
        {
            logBoxWrite(text);
            using (FileStream file = new FileStream("log.txt", FileMode.Append)){
                byte[] array = Encoding.Default.GetBytes(text + '\n');
                file.Write(array, 0, array.Length);
            }
        }

        public void logBoxWrite(string log)
        {
            logBox.AppendText(log + Environment.NewLine);
            logBox.ScrollToCaret();
        }

        private void robo_Load(object sender, EventArgs e)
        {

        }

        private void Temp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Team1_Click(object sender, EventArgs e)
        {
            itemInfo(Team1.Text);
        }

        private void itemInfo(string teamName)
        {
            FileReader reader = new FileReader();
            try
            {
                Dictionary<string, string[]> text = reader.itemInfo(teamName);
            }
            catch (Exception exception)
            {
                log(exception.Message);
            }
        }
    }
}
