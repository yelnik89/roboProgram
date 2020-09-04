using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
    class RequestJson
    {
        private string[] trafficLights = { "l1", "l2", "l3", "l4" };
        private string[] remotTerminal = { "l1", "l2", "l3", "l4" };
        private string[] manipulator = { "n", "s", "p",
            "m1", "m2", "m3", "m4", "m5", "m6",
            "l0", "l1", "l2", "l3", "l4", "l5", "l6",
            "t1", "t2", "t3", "t4", "t5", "t6",
            "b1", "b2", "b3", "t", "l" };
        private string[] politasier = { "n", "s", "p",
            "m1", "m2", "m3", "m4", "m5",
            "l0", "l1", "l2", "l3", "l4", "l5",
            "t1", "t2", "t3", "t4", "t5",
            "b1", "b2", "b3", "t", "l" };
        

        public string getJson(string litera)
        {
            string[] template = null;

            if (litera.Equals("T")) template = this.trafficLights;
            if (litera.Equals("R")) template = this.remotTerminal;
            if (litera.Equals("M")) template = this.manipulator;
            if (litera.Equals("P")) template = this.politasier;


            return JsonConvert.SerializeObject(template);
        }
    }
}
