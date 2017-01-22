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
   public class PW_User
    {
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string ID { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string USERNAME { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string PASSWORD { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string USERGROUP { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string DEPARTMENT { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string UPDATETIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string PASSWORDUPDATETIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string PASSWORDEXPIRETIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string LASTLOGINTIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string ISLOGININ { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string HANDSHAKE { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string PW_BACKUP1 { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string PW_BACKUP2 { get; set; }
        ///<summary>
        ///
        ///</summary>
        [DataMember]
        public string PW_BACKUP3 { get; set; } 

        
    }
}
