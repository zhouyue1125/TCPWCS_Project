using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace DBEntity
{
  
    public class V_INOUTSTOCK
    {
        ///<summary>
        ///
        ///</summary>
        public string WAREHOUSENO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CONTAINERNO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TASKTYPE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string SOURCEPLACE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TOPLACE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string UPDATEUSER { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string UPDATETIME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TASKCONTENTSTRING { get; set; } 


    }
}
