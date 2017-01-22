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
   public  class PW_GROUP
    {
        ///<summary>
        ///
        ///</summary>
        public string ID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string GROUPNAME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string GROUPDESCRIBE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string STATUS { get; set; } 


    }
}
