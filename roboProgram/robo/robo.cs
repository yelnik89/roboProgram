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
        private ThingsFactory factory;
        private const string PROPERTY_URI = "/Properties";
        private const string THINGS_URI = "/Thingworx/Things";


        public robo()
        {
            InitializeComponent();
            authorizationType.SelectedIndex = 0;
            this.factory = new ThingsFactory();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendReqest_Click(object sender, EventArgs e)
        {
            bool error = false;
            string address = getAddress();
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
            if (address.Equals("")) error = true;

            if (!error)
            {
                if (authorizationType.SelectedIndex == 0) log("указанный ключ: " + uuid.Text);
                getThingsAsync(address);
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

        private async void getThingsAsync(string address)
        {
            bool error = false;
            string json = "";
            HttpWebRequest req = request("GET", address);

            await Task.Run(() =>
            {
                try
                {
                    using (var responseStream = req.GetResponse().GetResponseStream())
                    using (var reader = new StreamReader(responseStream))
                    {
                        json = reader.ReadToEnd();
                    }
                }
                catch(Exception e)
                {
                    json = e.Message;
                    error = true;
                }
            });

            log(json);
            if (!error) fullingThingList(json);
        }

        private async Task<string> getPropertyAsync(string name)
        {
            log("get Property");
            bool error = false;
            string json = "";
            HttpWebRequest req = request("GET", getPropertyAddress(name));
            await Task.Run(() =>
            {
                try
                {
                    using (var responseStream = req.GetResponse().GetResponseStream())
                    using (var reader = new StreamReader(responseStream))
                    {
                        json = reader.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    error = true;
                    json = e.Message;
                }
            });
            log(json);
            if (error)
            {
                return "Error";
            }
            return json;
        }

        private string getProperty(string name)
        {
            log("get Property");
            string address = getPropertyAddress(name);
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

        private void paramFieldClin()
        {
            ThingName.Text = null;
            ParamsValues.Text = null;
            ParamsNames.Text = null;
        }
        
        private void fullingThingList(string json)
        {
            AllThingsJson.Rootobject allThings = JsonConvert.DeserializeObject<AllThingsJson.Rootobject>(json);
            foreach (AllThingsJson.Row row in allThings.rows)
            {
                thingList.Items.Add(row);
            }

            thingList.SelectedIndex = 0;
        }
                
        private string httpRequest (string method, string url, string json = "")
        {
            HttpWebRequest req = request(method, url);

            if (method.Equals("POST") || method.Equals("PUT")) sendData(req, json);
            var result = sendRequest(req);

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

        private void authorization(HttpWebRequest req)
        {
            string authInfo = login.Text + ":" + password.Text;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            if (authorizationType.SelectedIndex == 1) req.Headers["Authorization"] = "Basic " + authInfo;
            if (authorizationType.SelectedIndex == 0) req.Headers["appkey"] = uuid.Text;
        }

        private string getAuthInfo()
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

        private string sendRequestAsync(HttpWebRequest req)
        {
            string result;
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
                result = e.Message;
            }
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

        private string getAddress()
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

        private string getPropertyAddress(string name)
        {
            string address = getAddress() + "/" + name + PROPERTY_URI;
            if (address.Equals("")) return "";
            log(address);
            return address;
        }

        private string getAuthorizationType()
        {
            string authType = "";
            if (authorizationType.SelectedIndex == 0) authType = "appkey";
            if (authorizationType.SelectedIndex == 1) authType = "Basic";
            return authType;
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
    }
}
