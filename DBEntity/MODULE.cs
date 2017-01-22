using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DBEntity
{
    [XmlSerializerFormat]
    [Serializable]
    [DataContract]
    public class MODULE
    {
        ///<summary>
        ///
        ///</summary>
        public string ID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string MODULE_NAME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string MODULE_DESCRIBE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TAGNAME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string STATUS { get; set; } 
    }
}
