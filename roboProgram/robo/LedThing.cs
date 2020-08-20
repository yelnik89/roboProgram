using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
    class LedThing
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
            public Led1 led1 { get; set; }
            public Led2 led2 { get; set; }
            public Led3 led3 { get; set; }
            public Led4 led4 { get; set; }
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

        public class Led1
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

        public class Led2
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

        public class Led3
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

        public class Led4
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

        public class Row
        {
            public string name { get; set; }
            public string description { get; set; }
            public string thingTemplate { get; set; }
            public object[] tags { get; set; }
            public int led1 { get; set; }
            public int led2 { get; set; }
            public int led3 { get; set; }
            public int led4 { get; set; }
        }

    }
}
