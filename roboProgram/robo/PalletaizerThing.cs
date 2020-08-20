using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
    class PalletaizerThing
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
            public Load_3 Load_3 { get; set; }
            public Position_X Position_X { get; set; }
            public Status Status { get; set; }
            public Load_4 Load_4 { get; set; }
            public Position_Y Position_Y { get; set; }
            public Load_1 Load_1 { get; set; }
            public Load_2 Load_2 { get; set; }
            public Load_5 Load_5 { get; set; }
            public Motor_1 Motor_1 { get; set; }
            public Motor_2 Motor_2 { get; set; }
            public Motor_3 Motor_3 { get; set; }
            public Motor_4 Motor_4 { get; set; }
            public Motor_5 Motor_5 { get; set; }
            public CCN CCN { get; set; }
            public Temp_4 Temp_4 { get; set; }
            public Temp_3 Temp_3 { get; set; }
            public Temp_5 Temp_5 { get; set; }
            public Vacuum Vacuum { get; set; }
            public Gripper Gripper { get; set; }
            public LCN LCN { get; set; }
            public Currents_Phase Currents_phase { get; set; }
            public Temp_2 Temp_2 { get; set; }
            public Temp_1 Temp_1 { get; set; }
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

        public class Load_3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects4 aspects { get; set; }
        }

        public class Aspects4
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Position_X
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects5 aspects { get; set; }
        }

        public class Aspects5
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Status
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects6 aspects { get; set; }
        }

        public class Aspects6
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Load_4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects7 aspects { get; set; }
        }

        public class Aspects7
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Position_Y
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects8 aspects { get; set; }
        }

        public class Aspects8
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Load_1
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects9 aspects { get; set; }
        }

        public class Aspects9
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Load_2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects10 aspects { get; set; }
        }

        public class Aspects10
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Load_5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects11 aspects { get; set; }
        }

        public class Aspects11
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Motor_1
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects12 aspects { get; set; }
        }

        public class Aspects12
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Motor_2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects13 aspects { get; set; }
        }

        public class Aspects13
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Motor_3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects14 aspects { get; set; }
        }

        public class Aspects14
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Motor_4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects15 aspects { get; set; }
        }

        public class Aspects15
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Motor_5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects16 aspects { get; set; }
        }

        public class Aspects16
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class CCN
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects17 aspects { get; set; }
        }

        public class Aspects17
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Temp_4
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects18 aspects { get; set; }
        }

        public class Aspects18
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Temp_3
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects19 aspects { get; set; }
        }

        public class Aspects19
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Temp_5
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects20 aspects { get; set; }
        }

        public class Aspects20
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Vacuum
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects21 aspects { get; set; }
        }

        public class Aspects21
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Gripper
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects22 aspects { get; set; }
        }

        public class Aspects22
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class LCN
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects23 aspects { get; set; }
        }

        public class Aspects23
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Currents_Phase
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects24 aspects { get; set; }
        }

        public class Aspects24
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Temp_2
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects25 aspects { get; set; }
        }

        public class Aspects25
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Temp_1
        {
            public string name { get; set; }
            public string description { get; set; }
            public string baseType { get; set; }
            public int ordinal { get; set; }
            public Aspects26 aspects { get; set; }
        }

        public class Aspects26
        {
            public bool isPersistent { get; set; }
            public string dataChangeType { get; set; }
            public float cacheTime { get; set; }
        }

        public class Row
        {
            public string name { get; set; }
            public string description { get; set; }
            public string thingTemplate { get; set; }
            public object[] tags { get; set; }
            public int Load_3 { get; set; }
            public int Position_X { get; set; }
            public int Status { get; set; }
            public int Load_4 { get; set; }
            public int Position_Y { get; set; }
            public int Load_1 { get; set; }
            public int Load_2 { get; set; }
            public int Load_5 { get; set; }
            public int Motor_1 { get; set; }
            public int Motor_2 { get; set; }
            public int Motor_3 { get; set; }
            public int Motor_4 { get; set; }
            public int Motor_5 { get; set; }
            public int CCN { get; set; }
            public int Temp_4 { get; set; }
            public int Temp_3 { get; set; }
            public int Temp_5 { get; set; }
            public int Vacuum { get; set; }
            public int Gripper { get; set; }
            public int LCN { get; set; }
            public int Currents_phase { get; set; }
            public int Temp_2 { get; set; }
            public int Temp_1 { get; set; }
        }

    }
}
