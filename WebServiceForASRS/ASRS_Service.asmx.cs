using System;
using System.Collections.Generic;
using System.Web.Services;
using DBEntity;
using WebServiceForASRS.DAL;
using WebServiceForASRS.Opc_Service;
using System.Web.Script.Services;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace WebServiceForASRS
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
    [ScriptService]
    public class ASRS_Service : System.Web.Services.WebService
    {
        #region CommonMethod
        /// <summary>
        /// 获取系统时间
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public System.DateTime CommonMethod_GetServerTime()
        {
            return System.DateTime.Now;
        }
        [WebMethod]
        public bool CommonMethod_BackUpDB(string filePath)
        {
            return Common_Method.BackUpForDB(filePath);
        }
       
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [WebMethod]
        public string CommonMethod_StringEncoding(string pwd)//加密
        {
            return Common_Method.EncryptDES(pwd, "0c6b0450");
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [WebMethod]
        public string CommonMethod_StringDecoding(string pwd)//加密
        {
            return Common_Method.DecryptDES(pwd, "0c6b0450");
        } 
        #endregion

        #region PW_User
        /// <summary>
        /// 根据工号获取用户信息
        /// </summary>
        /// <param name="empno"></param>
        /// <returns></returns>
        [WebMethod]
        public PW_User PW_User_GetUserInfoByEmpno(string empno)
        {
            return SQL_Da_PW_User.GetOneByEmpNo(empno);
        }
       
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [WebMethod]
        public bool PW_User_UpdateUserInfo(PW_User user)
        {
            return SQL_Da_PW_User.UpdateOne(user);
        }

        /// <summary>
        /// 删除一个用户信息
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [WebMethod]
        public bool PW_User_DeleteUser(string UserId)
        {
            return SQL_Da_PW_User.DeleteOne(UserId);
        }

        /// <summary>
        /// 批量删除用户信息
        /// </summary>
        /// <param name="UserIds"></param>
        /// <returns></returns>
        [WebMethod]

        public bool PW_User_DeleteUsers(string UserIds)
        {
            return SQL_Da_PW_User.DeleteUsers(UserIds);
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        [WebMethod]

        public List<PW_User> PW_User_GetAll()
        {
            return SQL_Da_PW_User.GetAll();
        }



      
        [WebMethod]

        public string JsonPW_User_GetAll()
        {
            List<PW_User> ListPWUser = SQL_Da_PW_User.GetAll();
            DataContractJsonSerializer json = new DataContractJsonSerializer(ListPWUser.GetType());
            string szJson = "";
            using (MemoryStream stream = new MemoryStream())
            {

                json.WriteObject(stream, ListPWUser);

                szJson = Encoding.UTF8.GetString(stream.ToArray());

            }
            return szJson;
            //return SQL_Da_PW_User.GetAll();
        }
        /// <summary>
        /// 插入一条用户数据
        /// </summary>
        /// <param name="t_new"></param>
        /// <returns></returns>
        [WebMethod]
        public bool PW_User_InsertOne(PW_User t_new)
        {
            return SQL_Da_PW_User.InsertNew(t_new);
        }

        /// <summary>
        /// 根据UserID来获取用户信息
        /// </summary>
        /// <param name="USERID"></param>
        /// <returns></returns>
        [WebMethod]
        public PW_User PW_User_GetOneByUserID(string USERID)
        {
            return SQL_Da_PW_User.GetOneByEmpNo(USERID);
        }

        /// <summary>
        /// 根据组名来获取用户信息
        /// </summary>
        /// <param name="USERGroup"></param>
        /// <returns></returns>
        [WebMethod]
        public List<PW_User> PW_User_GetAllByUserGroup(string USERGroup)
        {
            return SQL_Da_PW_User.GetAllByGroupName(USERGroup);
        } 
        #endregion

        #region PW_Group
        /// <summary>
        /// 获取全部用户组
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<PW_GROUP> PW_Group_GetAll()
        {
            return SQL_Da_PW_GROUP.GetAll();
        }

        /// <summary>
        /// 删除一个用户组
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool PW_Group_DeleteOne(string groupId)
        {
            return SQL_Da_PW_GROUP.DeleteOne(groupId);
        }
        /// <summary>
        /// 添加一个用户组
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool PW_Group_InsertOne(PW_GROUP t_One)
        {
            return SQL_Da_PW_GROUP.InsertNew(t_One);
        }
        /// <summary>
        /// 修改一个用户组
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool PW_Group_UpadteOne(PW_GROUP t_One)
        {
            return SQL_Da_PW_GROUP.UpdateOne(t_One);
        }
        #endregion

        #region MODULE
        /// <summary>
        /// 获取全部用户组
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<MODULE> MODULE_GetAll()
        {
            return SQL_Da_MODULE.GetAll();
        }

        [WebMethod]
        public bool MODULE_InsertOne(MODULE t_one)
        {
            return SQL_Da_MODULE.InsertNew(t_one);
        }
        [WebMethod]
        public bool MODULE_UpdateOne(MODULE t_one)
        {
            return SQL_Da_MODULE.UpdateOne(t_one);
        }
        [WebMethod]
        public bool MODULE_DeleteOne(string PW_ID)
        {
            return SQL_Da_MODULE.DeleteOne(PW_ID);
        }
        #endregion

        #region MODULE_VS_GROUP

        [WebMethod]
        public List<MODULE_VS_GROUP> MODULE_VS_GROUP_GetAllByGroupName(string GroupName)
        {
            return SQL_Da_MODULE_VS_GROUP.GetAllByGroupName(GroupName);
        }

        [WebMethod]
        public bool MODULE_VS_GROUP_InsertOne(MODULE_VS_GROUP one)
        {
            return SQL_Da_MODULE_VS_GROUP.InsertNew(one);
        }
        [WebMethod]
        public bool MODULE_VS_GROUP_UpdateOne(MODULE_VS_GROUP one)
        {
            return SQL_Da_MODULE_VS_GROUP.UpdateOne(one);
        }
        [WebMethod]
        public bool MODULE_VS_GROUP_DeleteOne(string id)
        {
            return SQL_Da_MODULE_VS_GROUP.DeleteOne(id);
        }
        #endregion

        #region Items
        [WebMethod]
        public List<IM_Item> IM_Item_GetAll()
        {
            return SQL_da_IM_Item.GetAll();
        }

        [WebMethod]
        public bool IM_Item_InsertOne(IM_Item t_new)
        {
            return SQL_da_IM_Item.InsertNew(t_new);
        }
        /// <summary>
        /// 更新一条物料数据
        /// </summary>
        /// <param name="t_new">物料信息</param>
        /// <returns></returns>
        [WebMethod]
        public bool IM_Item_UpdateOne(IM_Item t_new)
        {
            return SQL_da_IM_Item.UpdateOne(t_new);
        }

        [WebMethod]
        public bool IM_Item_DeleteOne(string Sku)
        {
            return SQL_da_IM_Item.DeleteOne(Sku);
        }

        [WebMethod]
        public List<IM_Item> IM_Item_GetAllByContainerID(string containerId)
        {
            return SQL_da_IM_Item.GetAllByContainerID(containerId);
        }
        /// <summary>
        /// 根据物料号查找物料信息
        /// </summary>
        /// <param name="Sku">物料号</param>
        /// <returns></returns>
        [WebMethod]
        public IM_Item IM_Item_GetOneBySku(string Sku)
        {
            return SQL_da_IM_Item.GetOneBySku(Sku);
        }
        /// <summary>
        /// 根据关键字查找物料信息
        /// </summary>
        /// <param name="KeyWord"></param>
        /// <returns></returns>
        [WebMethod]
        public List<IM_Item> IM_Item_GetAllByKeyWord(string KeyWord)
        {
            var rst=SQL_da_IM_Item.GetAll();
            if (rst != null && rst.Count > 0)
            {
                rst = rst.FindAll(x => x.SKU.Contains(KeyWord) || x.SKUDESC.Contains(KeyWord) || x.SPEC.Contains(KeyWord) || x.ITEMCLASS == KeyWord);
            }
            else
            {
                rst = new List<IM_Item>();
            }
            return rst;
        }

       
        #endregion

        #region Container
        [WebMethod]
        public List<IM_Container> IM_Container_GetAll()
        {
            return SQL_Da_IM_Container.GetAll();
        }
        [WebMethod]
        public List<IM_Container> IM_Container_GetUnBindingedContainer()
        {
            return SQL_Da_IM_Container.GetUnBindingedContainer();
        }
        [WebMethod]
        public bool IM_Container_InsertOne(IM_Container t_new)
        {
            return SQL_Da_IM_Container.InsertNew(t_new);
        }

        [WebMethod]
        public bool IM_Container_UpdateOne(IM_Container t_new)
        {
            return SQL_Da_IM_Container.UpdateOne(t_new);
        }

        [WebMethod]
        public bool IM_Container_DeleteOne(string ContainerID)
        {
            return SQL_Da_IM_Container.DeleteOne(ContainerID);
        }

        [WebMethod]
        public IM_Container IM_Container_GetOneByContainerId(string ContainerID)
        {
            return SQL_Da_IM_Container.GetOneByContainerId(ContainerID);
        }
        /// <summary>
        /// 根据关键字查找物料信息
        /// </summary>
        /// <param name="KeyWord"></param>
        /// <returns></returns>
        [WebMethod]
        public List<IM_Container> IM_Container_GetAllByKeyWord(string KeyWord)
        {
            var rst=SQL_Da_IM_Container.GetAll();
            if (rst != null && rst.Count > 0)
            {
                rst = rst.FindAll(x => x.CONTAINERID.Contains(KeyWord) || x.CONTAINERDESC.Contains(KeyWord) || x.CONTAINERTYPE.Contains(KeyWord));
            }
            else
            {
                rst = new List<IM_Container>();
            }
            return rst;
        }
        #endregion

        #region PL_PLACE
        [WebMethod]
        public List<PL_Place> PL_PLACE_GetAll()
        {
            return SQL_Da_PL_Place.GetAll();
        }

        [WebMethod]
        public List<PL_Place> PL_PLACE_GetFreeByHighNO(int HighNO)
        {
            return SQL_Da_PL_Place.GetAllByHighNO(HighNO);
        }


        [WebMethod]
        public bool PL_PLACE_InsertNew(PL_Place t_new)
        {
            return SQL_Da_PL_Place.InsertNew(t_new);
        }
        [WebMethod]
        public bool PL_PLACE_UpdateNew(PL_Place t_new)
        {
            return SQL_Da_PL_Place.UpdateOne(t_new);
        }
        [WebMethod]
        public bool PL_PLACE_DeleteOne(string placeId)
        {
            return SQL_Da_PL_Place.DeleteOne(placeId);
        }
        [WebMethod]
        public List<PL_Place> PL_PLACE_GetPlaceInfoByID(string placeId)
        {
            return SQL_Da_PL_Place.GetPlaceInfoByID(placeId);
        }
        [WebMethod]
        public List<PL_Place> PL_PLACE_GetInputLocationByContainerBind(string BindContainerID)
        {
            return SQL_Da_PL_Place.GetInputLocationByContainerBind(BindContainerID);
        }
        [WebMethod]
        public List<PL_Place> PL_PLACE_GetByAreaStrLocation(string LogicArae)
        {
            return SQL_Da_PL_Place.GetByAreaStrLocation(LogicArae);
        }
        [WebMethod]
        public List<PL_Place> PL_PLACE_FiltLocationByRowColumnLayer(string row, string col, string layer)
        {
            return SQL_Da_PL_Place.FiltLocationByRowColumnLayer(row, col, layer);
        }
        [WebMethod]
        public bool PL_PLACE_CheckPlaceEmpty(string placeID)
        {
            return SQL_Da_PL_Place.CheckPlaceEmpty(placeID);
        }
        [WebMethod]
        public bool PL_PLACE_UpdateHadTaskDoing(string placeID, string OneOrZero)
        {
            return SQL_Da_PL_Place.UpdateHadTaskDoing(placeID, OneOrZero);
        }
        [WebMethod]
        public List<string> PL_PLACE_GetEmptyPlace()
        {
            return SQL_Da_PL_Place.GetEmptyPlace();
        }
       
        
        [WebMethod]
        public List<string> PL_PLACE_GetLockedPlace()
        {
            return SQL_Da_PL_Place.GetLockedPlace();
        }
      
      
        [WebMethod]
        public PL_Place PL_PLACE_GetPlaceByBindingContainer(string containerid)
        {
            return SQL_Da_PL_Place.GetPlaceByBindingContainer(containerid);
        }
        [WebMethod]
        public List<PL_Place>  PL_PLACE_GetAllbyLayer(string layer)
        {
            return SQL_Da_PL_Place.GetAllByLayer(layer);
        }
        #endregion


        #region Device_Alert
        /// <summary>
        /// 根据时间段查找报警信息
        /// </summary>
        /// <param name="start">开始时间</param>
        /// <param name="end">结束时间</param>
        /// <param name="deviceId">设备号</param>
        /// <returns></returns>
        [WebMethod]
        public List<Device_Alert> Device_Alert_GetAllByDate(DateTime start,DateTime end,string deviceId)
        {
            return SQL_da_DeviceAlert.GetAllByDate(start, end, deviceId);
        }

        [WebMethod]
        public Device_Alert Device_Alert_GetAllByAlertId(string alertId)
        {
            return SQL_da_DeviceAlert.GetAllByAlertID(alertId);
        }

        [WebMethod]
        public bool Device_Alert_InsertOne(Device_Alert t_new)
        {
            return SQL_da_DeviceAlert.InsertNew(t_new);
        }
        [WebMethod]
        public bool Device_Alert_UpdateOne(Device_Alert t_new)
        {
            return SQL_da_DeviceAlert.UpdateOne(t_new);
        }
        [WebMethod]
        public bool Device_Alert_DeleteOne(string id)
        {
            return SQL_da_DeviceAlert.DeleteOne(id);
        }
        [WebMethod]
        public bool Device_Alert_UpdateOneFlagByAlarmId(string alarmId, string flag)
        {
            return SQL_da_DeviceAlert.UpdateOneFlagByAlarmId(alarmId, flag);
        }
        [WebMethod]
        public List<Device_Alert> Device_Alert_GetUnReadAlarms()
        {
            return SQL_da_DeviceAlert.GetUnReadAlarms();
        }
        [WebMethod]
        public Device_Alert Device_Alert_GetLastAlarm()
        {
            return SQL_da_DeviceAlert.GetLastAlert();
        }
        #endregion


        #region Place_Vs_Container
        [WebMethod]
        public List<IV_place_vs_container> Place_Vs_Container_GetStoredInfo()
        {
            return SQL_Da_IV_place_vs_container.GetStoredInfo();
        }
        [WebMethod]
        public List<IV_place_vs_container> Place_Vs_Container_GetEmptyContainerInfo()
        {
            return SQL_Da_IV_place_vs_container.GetPlaceOfEmptyContainer();
        }
        [WebMethod]
        public List<IV_place_vs_container> Place_Vs_Container_GetRelationshipByContainer(string ContainerID)
        {
            return SQL_Da_IV_place_vs_container.GetRelationshipByContainer(ContainerID);
        }
        [WebMethod]
        public List<IV_place_vs_container> Place_Vs_Container_GetAll()
        {
            return SQL_Da_IV_place_vs_container.GetAll();
        }
        [WebMethod]
        public bool Place_Vs_Container_UpdateOne(IV_place_vs_container one)
        {
            return SQL_Da_IV_place_vs_container.UpdateOne(one);
        }
        [WebMethod]
        public bool Place_Vs_Container_InsertOne(IV_place_vs_container one)
        {
            return SQL_Da_IV_place_vs_container.InsertNew(one);
        }
        [WebMethod]
        public bool Place_Vs_Container_DeleteOne(string containerId)
        {
            return SQL_Da_IV_place_vs_container.DeleteOne(containerId);
        }
        #endregion

        #region OPC
        /// <summary>
        /// 读取Opc值
        /// </summary>
        /// <param name="ItemNames">地址块集合</param>
        /// <returns></returns>
        [WebMethod]
        public List<object> OPC_Read(List<string> ItemNames)
        {
            if (ItemNames == null || ItemNames.Count == 0)
                return null;
            int count = ItemNames.Count;
            List<object> readRtn = new List<object>();//设置返回值数组
            try
            {
                using (var srv = new OPCXML_DataAccess())
                {
                    ReadRequestItemList ItemLists = new ReadRequestItemList();
                    ItemLists.Items = new ReadRequestItem[count];
                    for (int i = 0; i < count; i++)
                    {
                        ItemLists.Items[i] = new ReadRequestItem();
                        ItemLists.Items[i].ItemPath = "";
                        ItemLists.Items[i].ItemName = ItemNames[i];
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
            }
            catch (Exception)
            {
               
            }
            return readRtn;
        }

        /// <summary>
        /// 单值写入OPCServer
        /// </summary>
        /// <param name="ItemName">地址块</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        [WebMethod]
        public bool OPC_WritePoint(string ItemName, object value)
        {
            try
            {
                using (OPCXML_DataAccess srv = new OPCXML_DataAccess())
                {
                    WriteRequestItemList ItemLists = new WriteRequestItemList();
                    ItemLists.Items = new ItemValue[1];
                    ItemLists.Items[0] = new ItemValue();
                    ItemLists.Items[0].ItemPath = "";
                    ItemLists.Items[0].ItemName = ItemName;
                    ItemLists.Items[0].Value = value;
                    ItemLists.Items[0].TimestampSpecified = false;

                    RequestOptions opt = new RequestOptions();

                    ReplyItemList ItemValues = new ReplyItemList();
                    OPCError[] Errors;
                    opt.ReturnItemTime = true;
                    ReplyBase replay = srv.Write(opt, ItemLists, true, out ItemValues, out Errors);
                    if (replay.ServerState == serverState.failed || replay.ServerState == serverState.commFault)
                        return false;
                    else
                        return true;

                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool SSJ_Licences(int ssj_Number)
        {
            string LOCALSERVER = "S7:[S7 connection_1]";         
            string StackerWrite = "DB540,";
            string WRITE_SSJ_1_Allow = LOCALSERVER + StackerWrite + "B17";//1号输送机入库许可
            string WRITE_SSJ_2_Allow = LOCALSERVER + StackerWrite + "B18";//2号输送机入库许可
            string WRITE_SSJ_3_Allow = LOCALSERVER + StackerWrite + "B19";//3号输送机入库许可
          
            if (ssj_Number == 1)
            {
               return OPC_WritePoint(WRITE_SSJ_1_Allow, 1);
            }
            else if (ssj_Number == 2)
            {
                return OPC_WritePoint(WRITE_SSJ_2_Allow, 1);
            }
            else
            {
                return OPC_WritePoint(WRITE_SSJ_3_Allow, 1);
            }
        }

        /// <summary>
        /// 集合值写入OPC服务器
        /// </summary>
        /// <param name="ItemName">地址块集合</param>
        /// <param name="values"></param>
        /// <returns></returns>
        [WebMethod]
        public bool OPC_WriteSerial(List<string> ItemNames, List<object> values)
        {
            try
            {
                using (OPCXML_DataAccess srv = new OPCXML_DataAccess())
                {
                    int count = ItemNames.Count;
                    WriteRequestItemList ItemLists = new WriteRequestItemList();
                    ItemLists.Items = new ItemValue[count];
                    for (int i = 0; i < count; i++)
                    {
                        ItemLists.Items[i] = new ItemValue();
                        ItemLists.Items[i].ItemPath = "";
                        ItemLists.Items[i].ItemName = ItemNames[i];
                        ItemLists.Items[i].Value = values[i];
                        ItemLists.Items[i].TimestampSpecified = false;
                    }
                    RequestOptions opt = new RequestOptions();
                    ReplyItemList ItemValues = new ReplyItemList();
                    OPCError[] Errors;
                    opt.ReturnItemTime = true;
                    ReplyBase replay = srv.Write(opt, ItemLists, true, out ItemValues, out Errors);
                    if (replay.ServerState == serverState.failed || replay.ServerState == serverState.commFault)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion

        #region Du_Device
        [WebMethod]
        public DU_Device DU_Device_GetOneByDeviceId(string DeviceId)
        {
            return SQL_da_DU_Device.GetOneByDeviceID(DeviceId);
        }

        [WebMethod]
        public bool DU_Device_InsertOne(DU_Device newOne)
        {
            return SQL_da_DU_Device.InsertNew(newOne);
        }
        [WebMethod]
        public bool DU_Device_UpdateOne(DU_Device newOne)
        {
            return SQL_da_DU_Device.UpdateOne(newOne);
        }
        #endregion

        #region Od_Task
        /// <summary>
        /// 生成任务
        /// </summary>
        /// <param name="one"></param>
        /// <returns></returns>
        [WebMethod]
        public bool Od_Task_InsertOne(OD_Task one)
        {
            return SQL_Da_OD_Task.InsertNew(one);
        }
        [WebMethod]
        public bool Od_Task_UpdateOne(OD_Task one)
        {
            return SQL_Da_OD_Task.UpdateOne(one);
        }
        [WebMethod]
        public bool Od_Task_deleteOne(string TaskID)
        {
            return SQL_Da_OD_Task.DeleteOne(TaskID);
        }
        [WebMethod]
        public List<OD_Task> Od_Task_GetNotFinishedTask_by_deviceID(string Device_id)
        {
            return SQL_Da_OD_Task.GetNotFinishedTask_by_deviceID(Device_id);
        }
        [WebMethod]
        public OD_Task Od_Task_GetLastTaskByDeviceID(string Device_id)
        {
            return SQL_Da_OD_Task.GetLastTaskByDeviceID(Device_id);
        }
        /// <summary>
        /// 获取当前任务
        /// </summary>
        /// <param name="Device_id">设备号</param>
        /// <returns></returns>
        [WebMethod]
        public OD_Task Od_Task_GetCurrentTaskByDeviceID(string Device_id)
        {
            return SQL_Da_OD_Task.GetCurrentTaskByDeviceID(Device_id);
        }
        [WebMethod]
        public bool Od_Task_SetLastTaskVoidByDeviceID(string DeviceID)
        {
            return SQL_Da_OD_Task.SetLastTaskVoidByDeviceID(DeviceID);
        }
        #endregion

        #region Container_Vs_Items
        [WebMethod]
        public bool Container_Vs_Items_InsertOne(IV_container_vs_item one)
        {
            return SQL_Da_IV_container_vs_item.InsertNew(one);
        }
        [WebMethod]
        public bool Container_Vs_Items_UpdateOne(IV_container_vs_item one)
        {
            return SQL_Da_IV_container_vs_item.UpdateOne(one);
        }
        [WebMethod]
        public List<IV_container_vs_item> Container_Vs_Items_GetItemsByContainerID(string containerID)
        {
            return SQL_Da_IV_container_vs_item.GetItemsByContainerID(containerID);
        }
        [WebMethod]
        public List<IV_container_vs_item> Container_Vs_Items_GetAll()
        {
            return SQL_Da_IV_container_vs_item.GetAll();
        }
        [WebMethod]
        public bool Container_Vs_Items_DeleteOneByContainerID(string containerId)
        {
            return SQL_Da_IV_container_vs_item.DeleteOneByContainerID(containerId);
        }
        [WebMethod]
        public bool Container_Vs_Items_DeleteOneByCI_ID(string CI_ID)
        {
            return SQL_Da_IV_container_vs_item.DeleteByCI_ID(CI_ID);
        }
        #endregion

        #region V_INOUTSTOCK
        [WebMethod]
        public List<V_INOUTSTOCK> V_INOUTSTOCK_SelectByDate(DateTime startTime,DateTime endTime)
        {
            return SQL_Da_V_INOUTSTOCK.GetAllByDate(startTime,endTime);
        }
        
        #endregion 

        #region [Query_Stored]
        [WebMethod]
        public List<Query_Stored> Query_Stored_GetAll()
        {
            return Sql_Da_Query_Stored.GetAll();
        }
        #endregion 
    
    }
}