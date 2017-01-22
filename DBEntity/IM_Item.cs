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
    public class IM_Item
    {
        ///<summary>
        ///
        ///</summary>
        public string SKU { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string SKUDESC { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string BARCODE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string EANCODE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string COMPATIBLECODE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string SPEC { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ITEMCLASS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ABCCLASS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string UOM { get; set; }
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
        public decimal WEIGHT { get; set; }
        ///<summary>
        ///
        ///</summary>
        public decimal SAVEQTY { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string STORGELIFE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int VOID { get; set; }
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
        public string ITEM_BK1 { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ITEM_BK2 { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ITEM_BK3 { get; set; } 

    }
}
