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
    public class DU_Device
    {
        ///<summary>
        ///
        ///</summary>
        public string DEVICEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DEVICENODEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DEVICESERVICEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DEVICENAME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DEVICETYPE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int VOID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string WAREHOUSENO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string AISLE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string LINE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string SERVERIPADDRESS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string SERVERPORTNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string IPADDRESS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int PORTNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string SOCKETTYPE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string LOCALIPADDRESS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int LOCALPORTNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string REMOTEIPADDRESS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int REMOTEPORTNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int ISONLINE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string WORKINGSTATUS { get; set; } 

    }
}
