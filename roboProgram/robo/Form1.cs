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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendReqest_Click(object sender, EventArgs e)
        {
            if (ip.Text.Equals("") || port.Text.Equals(""))
            {
                if(ip.Text.Equals("")) log("не указан IP!!!");
                if(port.Text.Equals("")) log("не указан порт!!!");
            }
            else
            {
                string address = ip.Text + ":" + port.Text;

                RequestJson json = new RequestJson(uuid.Text);

                log("указанный ключ: " + uuid.Text);
                log(address);

                httpRequest("GET", "http://" + address, JsonConvert.SerializeObject(json));
            }
            
        }
        
        private void httpRequest(string method, string url, string json = "")
        {
            
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = method;
                req.Accept = uuid.Text;
                if (method.Equals("POST") || method.Equals("PUT"))
                {
                    req.ContentType = "application/json";
                    // req.Accept = ;
                    using (var requestStream = req.GetRequestStream())
                    using (var streamWriter = new StreamWriter(requestStream))
                    {
                        streamWriter.Write(json);
                    }
                }

                using (var responseStream = req.GetResponse().GetResponseStream())
                using (var reader = new StreamReader(responseStream))
                {
                    //logBox.Text = logBox.Text + reader.ReadToEnd() + '\n';//ответ
                    log(reader.ReadToEnd());
                }
            }
            catch(Exception e)
            {
                log(e.Message);
            }
        }

        private void myIP_Click(object sender, EventArgs e)
        {
            httpRequest("GET", "https://api.myip.com");
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
    }
}
