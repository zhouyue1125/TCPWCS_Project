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
    public class MODULE_VS_GROUP
    {
        ///<summary>
        ///
        ///</summary>
        public string ID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string GROUP_NAME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string GROUP_DESC { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string MODULE_ID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string MODULE_NAME { get; set; } 


    }
}
