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
    public class OD_Task
    {
        ///<summary>
        ///
        ///</summary>
        public string TASKID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TASKNAME { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DODEVICEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DODEVICENODEID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string DODEVICETYPE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TASKTYPE { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TASKLEVEL { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TASKSTATUS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TASKCONTENTSTRING { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string TASKTYPEDESCRIPTION { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string CONTAINERNO { get; set; }
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
        public string ORDERDETAILSID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ORDERHEADID { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int SENDTIMES { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string RELEASESTATUS { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string HADFINISH { get; set; }
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
        public string WAREHOUSENO { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ISCURRENTTASK { get; set; }
        ///<summary>
        ///
        ///</summary>
        public int INPUTLOCATIONLEVEL { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ISLASTTASK { get; set; }
        ///<summary>
        ///
        ///</summary>
        public string ISEMPTYCONTAINER { get; set; } 

    }
}
