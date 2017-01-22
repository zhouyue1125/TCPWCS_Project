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
    public class IV_place_vs_container
    {
        ///<summary>
        ///
        ///</summary>
        public string ID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string WAREHOUSENO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string PLACEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CONTAINERID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string UPDATETIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string UPDATEUSER { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int VOID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ISEMPTYCONTAINER { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ISEMPTYPLACE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string PVC_BACKUP1 { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string PVC_BACKUP2 { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string PVC_BACKUP3 { get; set; } 

    }
}
