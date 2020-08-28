using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
    class Messenger
    {
        private const string PROPERTY_URI = "/Properties";
        private const string THINGS_URI = "/Thingworx/Things";

        private string authInfo;
        private string address;
        private string authorizationType;

        public Messenger(string authInfo, string address, string authorizationType)
        {
            this.authInfo = authInfo;
            this.address = address;
            this.authorizationType = authorizationType;
        }

        public string getAllThings()
        {
            string result = httpRequest("GET", this.address);
            return result;
        }

        public string getProperty(string name)
        {
            string address = getPropertyAddress(name);
            string result = httpRequest("GET", address);

            return result;
        }
        
        private string httpRequest(string method, string url, string json = "")
        {
            HttpWebRequest req = request(method, url);
            if (method.Equals("POST") || method.Equals("PUT")) sendData(req, json);
            string result = sendRequest(req);

            return result;
        }

        private HttpWebRequest request(string url, string method)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = method;
            authorization(req, this.authInfo);
            req.Accept = "application/json";
            return req;
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
                    //log(result);
                }
            }
            catch (Exception e)
            {
                //log(e.Message);
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

        private string BasicAuthorization()
        {
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(this.authInfo));
            return "Basic " + authInfo;
        }

        private string getPropertyAddress(string name)
        {
            string address = this.address + "/" + name + PROPERTY_URI;
            if (address.Equals("")) return "";
            //log(address);
            return address;
        }

        private void authorization(HttpWebRequest req, string authInfo)
        {
            if (this.authorizationType.Equals("Basic")) req.Headers["Authorization"] = "Basic " + authInfo;
            if (this.authorizationType.Equals("appkey")) req.Headers["appkey"] = authInfo;
        }
        
    }
}
