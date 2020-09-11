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
using System.Net.Sockets;
using System.Threading;

namespace robo
{
    public partial class robo : Form
    {
        private const string PROPERTY_URI = "/Services/";
        private const string THINGS_URI = "/Thingworx/Things";
        private bool cicleRun = false;
        private bool teamCicleRun = false;
        private string teamName;
        private ThingsFactory factory;
        private AllThingsJson.Rootobject allThings;
        private Dictionary<string, string>[] thingsPropertyInServer;
        private Dictionary<string, string>[] thingsPropertyInPolygon;
        private List<string[]> teamSettings;
        private RequestJson json;
        private UdpClient[] listeningUdpClients;



        public robo()
        {
            InitializeComponent();
            authorizationType.SelectedIndex = 0;
            this.factory = new ThingsFactory();
            this.json = new RequestJson();
        }

        private async void sendReqest_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                string address = Address();
                if (authorizationType.SelectedIndex == 0) log("указанный ключ: " + uuid.Text);
                this.allThings = await getThingsAsync(address);
                if (this.allThings != null)
                {
                    //CicleRequestStart.Enabled = true;
                    this.thingsPropertyInServer = new Dictionary<string, string>[this.allThings.rows.Length];
                    fullingThingList(this.allThings);
                }
            }
        }

        private async void thingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thingName = (string)thingList.SelectedItem;
            string json = await getPropertyAsync(thingName, "", "");    //в метод вставлена заглушка, возможно этот метод здесь вообще вызываться не будет
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

        
        private async Task<string> getPropertyAsync(string name, string thingType, string servisName)
        {
            log("get Property");
            string thingReq = this.json.getJson(thingType);
            HttpWebRequest req = request("POST", PropertyAddress(name, servisName));
            string json = await sendHttpRequestAsync(req, thingReq);
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
                thingList.Items.Add(row.name);
            }

            thingList.SelectedIndex = 0;
        }

        private string httpRequest(string method, string url, string json = "")
        {
            HttpWebRequest req = request(method, url);

            if (method.Equals("POST") || method.Equals("PUT"))
            {
                req.Headers["x-thingworx-session"] = "true<]";
                sendData(req, json);
            }
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

        private async Task<string> sendHttpRequestAsync(HttpWebRequest req, string json = "")
        {
            if (req.Method.Equals("POST"))
            {
                sendData(req, json);
            }
            bool error = true;
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
                    error = false;
                }
                catch (Exception e)
                {
                    result = e.Message;
                }
            });
            log("result: " + result);
            if (error) return "error";
            return result;

        }

        private void sendData(HttpWebRequest req, string json)
        {
            req.Headers["x-thingworx-session"] = "true";
            req.ContentType = "application/json";
            using (var requestStream = req.GetRequestStream())
            using (var streamWriter = new StreamWriter(requestStream))
            {
                streamWriter.Write(json);
            }
            log("send data: " + json);
        }

        private void myIP_Click(object sender, EventArgs e)
        {
            httpRequest("GET", "https://api.myip.com");
        }

        private string Address()
        {
            string address;
            if (checkAddressField())
            {
                address = "http://" + ip.Text + ":" + port.Text + THINGS_URI;
                return address;
            }
            return "";
        }

        private string PropertyAddress(string name, string servisName = "")
        {
            string address = Address() + "/" + name + PROPERTY_URI + servisName;
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
            cicleMethod(this.allThings);
        }

        private void stopCicleRequest()
        {
            this.cicleRun = false;
            CicleRequestStart.Text = "START";
        }

        private async void cicleMethod(AllThingsJson.Rootobject allThings)
        {
            Messenger messenger = new Messenger(AuthInfo(), Address(), AuthorizationType());
            while (this.cicleRun)
            {
                foreach (AllThingsJson.Row row in allThings.rows)
                {
                    //await cicleGetPropertyAsync(row.name);
                    if (!this.cicleRun) break;
                }
                await Task.Delay(temp());
            }
        }

        private async void cicleMethod(List<string[]> teamList)
        {
            byte[] data;
            Messenger messenger = new Messenger(AuthInfo(), Address(), AuthorizationType());
            int teamListLenght = teamList.Count();
            while (this.teamCicleRun)
            {
                for ( int i = 0; i < teamListLenght; i++)
                {
                    string[] thing = teamList[i];
                    if (await cicleGetPropertyAsync(i, thing[4], thing[0], thing[5]))
                    {
                        data = sendData(thing, i);
                        sendUDP(thing[2], int.Parse(thing[3]), data);
                        reseiveUdpAnswer(i);
                        if (!this.teamCicleRun) break;
                    }
                }
                await Task.Delay(temp());
            }
        }

        private async Task<bool> cicleGetPropertyAsync(int index, string name, string thingType, string servisName)
        {
            string json = await getPropertyAsync(name, thingType, servisName);
            if (!json.Equals("error"))
            {
                this.thingsPropertyInServer[index] = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                return true;
            }
            return false;
        }

        private byte[] sendData(string[] thing, int index)
        {
            string sendData = collectStringData(thing, index);
            log("send to UDP: " + sendData);
            byte[] data = toByte(sendData);
            return data;
        }

        private byte[] toByte(string sendData)
        {
            int LengthOfString = sendData.Length;
            byte[] sendToUDP = new byte[LengthOfString];
            for (int i = 0; i < LengthOfString; i++)
            {
                sendToUDP[i] = Convert.ToByte(sendData[i]);
            }
            return sendToUDP;
        }

        private string collectStringData(string[] thing, int index)
        {
            string data = thing[0];
            foreach (KeyValuePair<string, string> property in this.thingsPropertyInServer[index])
            {
                data += ":" + property.Value;
            }
            if (thing[0].Equals("R")) data += ":0:test";
            data += "#";
            data = data.ToLower();
            return data;
        }

        private void sendUDP(string ip, int port, byte[] data)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            EndPoint remotePoint = new IPEndPoint(IPAddress.Parse(ip), port);
            socket.SendTo(data, remotePoint);
            socket.Close();
        }

        private async Task<string> reseiveUdpAnswer(int indexOfThing)
        {
            UdpClient receiver = this.listeningUdpClients[indexOfThing];
            IPEndPoint remoteIP = null;
            string message = "error";
            await Task.Run(() =>
            {
                try
                {
                    while (teamCicleRun)
                    {
                        byte[] data = receiver.Receive(ref remoteIP);
                        message = Encoding.Unicode.GetString(data);
                        log(message);
                    }
                        receiver.Close();
                }
                catch (Exception e)
                {
                    log(e.Message);
                    receiver.Close();
                }
            });

            return message;
        }

        private void Team1_Click(object sender, EventArgs e)
        {
            itemInfo(Team1.Text);
            fullingTeamThingsList(this.teamSettings);

        }

        private void itemInfo(string teamName)
        {
            log("select " + teamName);
            FileReader reader = new FileReader();
            try
            {
                this.teamSettings = reader.itemInfo(teamName);
                TeamStart.Text = teamName;
                this.teamName = teamName;
                this.thingsPropertyInServer = new Dictionary <string, string> [teamSettings.Count];
                this.listeningUdpClients = new UdpClient[teamSettings.Count];
            }
            catch (Exception exception)
            {
                log(exception.Message);
            }
        }

        private void fullingTeamThingsList(List<string[]> teamList)
        {
            int count = teamList.Count;
            for (int i = 0; i < count; i++)
            {
                string[] thing = teamList[i];
                TeamThingsList.Items.Add(thing[4]);
                this.listeningUdpClients[i] = new UdpClient(thing[2], int.Parse(thing[3]));
            }
            TeamThingsList.SelectedIndex = 0;
        }

        private void TeamStart_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (this.teamCicleRun) stopTeamCicleRequest();
                else startTeamCicleRequest();
            }
        }

        private void startTeamCicleRequest()
        {
            TeamStart.Text = "STOP";
            this.teamCicleRun = true;
            cicleMethod(this.teamSettings);
        }

        private void stopTeamCicleRequest()
        {
            this.teamCicleRun = false;
            TeamStart.Text = this.teamName;
        }

        private bool checkFields()
        {
            bool error = false;
            if (!checkAuthorizationField()) error = true;
            if (!checkAddressField()) error = true;
            return !error;
        }

        private bool checkAddressField()
        {
            bool error = false;
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
            return !error;
        }

        private bool checkAuthorizationField()
        {
            bool error = false;
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
            return !error;
        }

        private int temp()
        {
            if (Temp.Text.Length == 0) return 0;
            else return int.Parse(Temp.Text);
        }

        private void paramFieldClin()
        {
            ThingName.Text = null;
            ParamsValues.Text = null;
            ParamsNames.Text = null;
        }

        private void log(string text)
        {
            Loger loger = Loger.getInstance();
            logBox.AppendText(text + Environment.NewLine);
            logBox.ScrollToCaret();
            loger.writeLog(text);
        }

        private void Temp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
