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
    public class IV_container_vs_item
    {
        ///<summary>
        ///
        ///</summary>
        public string ID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CONTAINERID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ITEMSKU { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ITEMDESC { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ITEMBATCHNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ITEMSTATUSNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public decimal ITEMQTY { get; set; }
        ///<summary>
        ///
        ///</summary>
        public decimal OCC_QTY { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string WITHORDER { get; set; }
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
        public string EXPIREDAY { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CVI_BACKUP1 { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CVI_BACKUP2 { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CVI_BACKUP3 { get; set; } 


    }
}
