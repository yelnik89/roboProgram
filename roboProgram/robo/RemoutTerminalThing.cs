using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
    class RemoutTerminalThing
    {
        public class Rootobject
        {
            public Datashape dataShape { get; set; }
            public Row[] rows { get; set; }
        }

        public class Datashape
        {
            public Fielddefinitions fieldDefinitions { get; set; }
        }

        public class Fielddefinitions
        {
            public Name name { get; set; }
            public Description description { get; set; }
            public Thingtemplate thingTemplate { get; set; }
            public Tags tags { get; set; }
            public Light1 Light1 { get; set; }
            public Button1 Button1 { get; set; }
            public Light2 Light2 { get; set; }
            public Light3 Light3 { get; set; }
            public Light4 Light4 { get; set; }
            public Button3 Button3 { get; set; }
            public Button2 Button2 { get; set; }
            public Deadmanswitch DeadManSwitch { get; set; }
        }

        public class Name
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects aspects { get; set; }
        }

        public class Aspects
        {
            public bool isReadOnly { get; set; }
            public bool isPersistent { get; set; }
            public bool isBuiltIn { get; set; }
        }

        public class Description
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects1 aspects { get; set; }
        }

        public class Aspects1
        {
            public bool isReadOnly { get; set; }
            public bool isPersistent { get; set; }
            public bool isBuiltIn { get; set; }
        }

        public class Thingtemplate
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects2 aspects { get; set; }
        }

        public class Aspects2
        {
            public bool isReadOnly { get; set; }
            public bool isPersistent { get; set; }
            public bool isBuiltIn { get; set; }
        }

        public class Tags
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects3 aspects { get; set; }
        }

        public class Aspects3
        {
            public bool isReadOnly { get; set; }
            public bool isPersistent { get; set; }
            public string tagType { get; set; }
            public bool isBuiltIn { get; set; }
        }

        public class Light1
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects4 aspects { get; set; }
        }

        public class Aspects4
        {
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Button1
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects5 aspects { get; set; }
        }

        public class Aspects5
        {
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Light2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects6 aspects { get; set; }
        }

        public class Aspects6
        {
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Light3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects7 aspects { get; set; }
        }

        public class Aspects7
        {
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Light4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects8 aspects { get; set; }
        }

        public class Aspects8
        {
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Button3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects9 aspects { get; set; }
        }

        public class Aspects9
        {
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Button2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects10 aspects { get; set; }
        }

        public class Aspects10
        {
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Deadmanswitch
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects11 aspects { get; set; }
        }

        public class Aspects11
        {
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Row
        {
            public string name { get; set; }
            public string description { get; set; }
            public string thingTemplate { get; set; }
            public object[] tags { get; set; }
            public int Light1 { get; set; }
            public int Button1 { get; set; }
            public int Light2 { get; set; }
            public int Light3 { get; set; }
            public int Light4 { get; set; }
            public int Button3 { get; set; }
            public int Button2 { get; set; }
            public int Switch { get; set; }
        }

    }
}
