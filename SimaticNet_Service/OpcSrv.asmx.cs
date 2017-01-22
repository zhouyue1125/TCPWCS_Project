using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SimaticNet_Service.SimaticNet;

namespace SimaticNet_Service
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
    // [System.Web.Script.Services.ScriptService]
    public class SimaticNet_Service : System.Web.Services.WebService
    {

        [WebMethod]
        public static List<object> OPC_Read(List<string> ItemNames)
        {
            if (ItemNames == null || ItemNames.Count == 0)
                return null;
            int count = ItemNames.Count;
            List<object> readRtn = new List<object>();//设置返回值数组
            using (var srv = new OPCXML_DataAccess())
            {
                ReadRequestItemList ItemLists = new ReadRequestItemList();
                ItemLists.Items = new ReadRequestItem[count];
                for (int i = 0; i < count; i++)
                {
                    ItemLists.Items[i] = new ReadRequestItem();
                    ItemLists.Items[i].ItemPath = "";
                    ItemLists.Items[i].ItemName = ItemNames[i + 1];
                }
                RequestOptions opt = new RequestOptions();

                ReplyItemList ItemValues = new ReplyItemList(); ;
                OPCError[] Errors;
                opt.ReturnItemTime = true;
                srv.Read(opt, ItemLists, out ItemValues, out Errors);
                foreach (var p in ItemValues.Items)
                {
                    readRtn.Add(p.Value);
                }
            }
            return readRtn;
        }
    }
}