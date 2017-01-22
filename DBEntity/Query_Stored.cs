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
    public class Query_Stored
    {
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
        public string ITEMSKU { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ITEMDESC { get; set; }
        ///<summary>
        ///
        ///</summary>
        public decimal ITEMQTY { get; set; } 

    }
}
