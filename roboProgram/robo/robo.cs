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

namespace robo
{
    public partial class robo : Form
    {
        public robo()
        {
            InitializeComponent();
            autorizationType.SelectedIndex = 0;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendReqest_Click(object sender, EventArgs e)
        {
            int error = 0;
            string address = getAddress();
            if (autorizationType.SelectedIndex == 0)
            {
                if (uuid.Text.Length == 0)
                {
                    log("не указан Ключ!!!");
                    error++;
                }
            }
            else if (autorizationType.SelectedIndex == 1)
            {
                if (login.Text.Length == 0)
                {
                    log("не указан логин!!!");
                    error++;
                }
                if (password.Text.Length == 0)
                {
                    log("не введен пароль!!!");
                    error++;
                }
            }
            if (address.Equals("")) error++;

            if (error < 1)
            {
                if (autorizationType.SelectedIndex == 0) log("указанный ключ: " + uuid.Text);
                log(address);

                string json = httpRequest("GET", address);

                if(!json.Equals("error"))fullingThingList(json);
            }
        }

        private string getProperty()
        {
            log("get Property");
            string address = getAddress() + "/ledtest1/Properties";
            if (address.Equals("")) return"";
            log(address);
            string result = httpRequest("GET", address);
            log(result);
            return result;
        }

        private void thingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            getProperty();
            //log("get Thing");
            //string address = getAddress();
            //if (address.Equals("")) return;
            //address += "/" + thingList.SelectedItem;
            //log(address);
            //string result = httpRequest("GET", address);
            //log(result);
        }

        private void fullingThingList(string json)
        {
            AllThingsJson.Rootobject josnThings = JsonConvert.DeserializeObject<AllThingsJson.Rootobject>(json);

            foreach (AllThingsJson.Row row in josnThings.rows)
            {
                thingList.Items.Add(row);
            }

            thingList.SelectedIndex = 0;
        }
                
        private string httpRequest(string method, string url, string json = "")
        {
            string result;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = method;
                string authInfo = login.Text + ":" + password.Text;
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
                if (autorizationType.SelectedIndex == 1) req.Headers["Authorization"] = "Basic " + authInfo;
                if (autorizationType.SelectedIndex == 0) req.Headers["appkey"] = uuid.Text;
                req.Accept = "application/json";
                req.ContentType = "application/json";
                if (method.Equals("POST") || method.Equals("PUT"))
                {
                    using (var requestStream = req.GetRequestStream())
                    using (var streamWriter = new StreamWriter(requestStream))
                    {
                        streamWriter.Write(json);
                    }
                }

                using (var responseStream = req.GetResponse().GetResponseStream())
                using (var reader = new StreamReader(responseStream))
                {
                    result = reader.ReadToEnd();
                    log(result);
                    return (result);
                }
            }
            catch(Exception e)
            {
                log(e.Message);
            }

            return "error";
        }

        private void myIP_Click(object sender, EventArgs e)
        {
            httpRequest("GET", "https://api.myip.com");
        }

        private string getAddress()
        {
            int error = 0;
            string address = "http://" + ip.Text + ":" + port.Text + "/Thingworx/Things";
            if (ip.Text.Equals(""))
            {
                log("не указан IP!!!");
                error++;
            }
            if (port.Text.Equals(""))
            {
                log("не указан порт!!!");
                error++;
            }
            if (error < 1)
            {
                return address;
            }
            else
            {
                return "";
            }
        }

        private void log(string text)
        {
            logBox.AppendText(text + Environment.NewLine);
            logBox.ScrollToCaret();
            using (FileStream file = new FileStream("log.txt", FileMode.Append)){
                byte[] array = System.Text.Encoding.Default.GetBytes(text + '\n');
                file.Write(array, 0, array.Length);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
