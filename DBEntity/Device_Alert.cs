using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace DBEntity
{
    [XmlSerializerFormat]
    [Serializable]
    [DataContract]
   public class Device_Alert
    {
        ///<summary>
        ///
        ///</summary>
        public string ID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DEVICEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ALERTID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ALERTNAME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CREATETIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string FINISH_TIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TIME_OF_DURATION { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string SYSTEMFLAG { get; set; } 

    }
}
