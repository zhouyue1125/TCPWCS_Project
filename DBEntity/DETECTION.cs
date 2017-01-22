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
    public class DETECTION
    {
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string ID { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string WAREHOUSE { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string PLACEID { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string CONTAINERID { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string ITEMTYPE { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string ITEMSKU { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string ITEMDESC { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string LJTH { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string QTY { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string DTK_BACKUP1 { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string DTK_BACKUP2 { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string DTK_BACKUP3 { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string UPDATETIME { get; set; }
        [DataMember]
        ///<summary>
        ///
        ///</summary>
        public string UPDATEUSER { get; set; } 


    }
}
