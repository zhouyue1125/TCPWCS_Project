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
    public class IM_Container
    {
        ///<summary>
        ///
        ///</summary>
        public string CONTAINERID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CONTAINERDESC { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CONTAINERTYPE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public decimal LENGTH { get; set; }
        ///<summary>
        ///
        ///</summary>
        public decimal WIDTH { get; set; }
        ///<summary>
        ///
        ///</summary>
        public decimal HEIGHT { get; set; }
        ///<summary>
        ///
        ///</summary>
        public decimal MAXWEIGHT { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int VOID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int STATUS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string WAREHOUSENO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ONLINEMODEL { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string UPDATETIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string UPDATEUSER { get; set; } 


    }
}
