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
            RequestJson json = new RequestJson(uuid.Text);

            log("указанный ключ: " + uuid.Text);

            httpRequest("GET", "URL", JsonConvert.SerializeObject(json));
        }
        
        private void httpRequest(string method, string url, string json = "")
        {
            
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = method;
                if (method.Equals("POST") || method.Equals("PUT"))
                {
                    req.ContentType = "application/json";
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
        }
    }
}
