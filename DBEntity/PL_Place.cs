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
    public class PL_Place
    {
        ///<summary>
        ///
        ///</summary>
        public string PLACEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string PLACENODEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string PLACETYPE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string PLACEAREA { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ROWNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string COLUMNNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string LAYERNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DEEPCELLNO { get; set; }
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
        public string AISLESIDE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ISLOCK { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ISFULL { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string HASTASKDOING { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string WAREHOUSENO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string POSITIONNO_FOR_SRM { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string X { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string Y { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string Z { get; set; }
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
        public string HEIGHTLEVEL { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int PRIORITY { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string AREA_LOGIC { get; set; } 

    }
}
