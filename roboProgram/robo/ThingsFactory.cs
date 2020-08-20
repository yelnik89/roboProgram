using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
    class ThingsFactory
    {
        public Dictionary<string, string> getThing(string json)
        {
            if (json.Contains("Motor_6"))
            {
                ManipulatorThing.Rootobject thing = JsonConvert.DeserializeObject<ManipulatorThing.Rootobject>(json);
                return getDictionary(thing);
            }else if (json.Contains("Motor_5"))
            {
                PalletaizerThing.Rootobject thing = JsonConvert.DeserializeObject<PalletaizerThing.Rootobject>(json);
                return getDictionary(thing);
            }else if (json.Contains("Button"))
            {
                RemoutTerminalThing.Rootobject thing = JsonConvert.DeserializeObject<RemoutTerminalThing.Rootobject>(json);
                return getDictionary(thing);
            }
            else if (json.Contains("led"))
            {
                LedThing.Rootobject thing = JsonConvert.DeserializeObject<LedThing.Rootobject>(json);
                return getDictionary(thing);
            }

            return null;
        }

        public Dictionary<string, string> getDictionary(LedThing.Rootobject thing)
        {
            thing.rows[0].tags = null;
            string json = JsonConvert.SerializeObject(thing.rows[0]);
            Dictionary<string, string> result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return result;
        }

        public Dictionary<string, string> getDictionary(PalletaizerThing.Rootobject thing)
        {
            thing.rows[0].tags = null;
            string json = JsonConvert.SerializeObject(thing.rows[0]);
            Dictionary<string, string> result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return result;
        }

        public Dictionary<string, string> getDictionary(ManipulatorThing.Rootobject thing)
        {
            thing.rows[0].tags = null;
            string json = JsonConvert.SerializeObject(thing.rows[0]);
            Dictionary<string, string> result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return result;
        }

        public Dictionary<string, string> getDictionary(RemoutTerminalThing.Rootobject thing)
        {
            thing.rows[0].tags = null;
            string json = JsonConvert.SerializeObject(thing.rows[0]);
            Dictionary<string, string> result = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return result;
        }

    }
}
