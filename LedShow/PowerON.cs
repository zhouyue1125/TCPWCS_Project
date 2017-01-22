using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace LedShow
{
    public partial class PowerON : Form
    {
        string con = "Data Source=.;Initial Catalog=ASRS_VOLVO;Persist Security Info=True;User ID=sa;Password=123abc.com;";
        CLEDSender LEDSender2 = new CLEDSender();
        private const int WM_LED_NOTIFY = 1025;
        int i = 0;

        public PowerON()
        {
            InitializeComponent();
        }

        private void PowerON_Load(object sender, EventArgs e)
        {
            LEDSender2.Do_LED_Startup();
            TSenderParam param = new TSenderParam();
            GetDeviceParam(ref param.devParam);
            param.notifyMode = LEDSender2.NOTIFY_EVENT;
            param.wmHandle = (UInt32)Handle;
            LEDSender2.Do_LED_SetPower(ref param, 1);
            i = 1;
        }
        private void PowerON_FormClosed(object sender, FormClosedEventArgs e)
        {
            LEDSender2.Do_LED_Cleanup();
        }
        private void GetDeviceParam(ref TDeviceParam param)
        {
            param.devType = LEDSender2.DEVICE_TYPE_UDP;
            param.locPort = 8881;
            param.rmtHost = "192.168.0.99";
            param.rmtPort = 6666;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i = 0;
                TSenderParam param = new TSenderParam();
                GetDeviceParam(ref param.devParam);
                param.notifyMode = LEDSender2.NOTIFY_EVENT;
                param.wmHandle = (UInt32)Handle;
                LEDSender2.Do_LED_SetPower(ref param, 0);
            }
            else
            {
                i = 1;
                TSenderParam param = new TSenderParam();
                GetDeviceParam(ref param.devParam);
                param.notifyMode = LEDSender2.NOTIFY_EVENT;
                param.wmHandle = (UInt32)Handle;
                LEDSender2.Do_LED_SetPower(ref param, 1);
            }

        }
        private void GetDeviceParamWithoutStruct(Int32 param_index, Int32 notifymode, Int32 wmhandle, Int32 wmmessage)
        {
            LEDSender2.Do_LED_UDP_SenderParam(param_index, 8881, "192.168.0.99", 6666, 0, notifymode, wmhandle, wmmessage);
        }

        private void Parse(Int32 K)
        {
            if (K == LEDSender2.R_DEVICE_READY) Text = "正在执行命令或者发送数据...";
            else if (K == LEDSender2.R_DEVICE_INVALID) Text = "打开通讯设备失败(串口不存在、或者串口已被占用、或者网络端口被占用)";
            else if (K == LEDSender2.R_DEVICE_BUSY) Text = "设备忙，正在通讯中...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xc, crk, source, to, sku, desc;
            xc = null;
            crk = null;
            source = null;
            to = null;
            sku = null;
            desc = null;
            SqlConnection conne = new SqlConnection(con);
            //获取小车号/出入库类型/起始位/目标位
            conne.Open();
            string sql = "select * from OD_TASK where RELEASESTATUS='Y' and HADFINISH='Y'";
            SqlCommand cmd = new SqlCommand(sql, conne);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            xc = read["CONTAINERNO"].ToString();
            crk = read["TASKTYPEDESCRIPTION"].ToString().Replace("堆垛机", "");
            source = read["SOURCEPLACE"].ToString();
            to = read["TOPLACE"].ToString();
            conne.Close();
            //根据小车号获取物料号/物料名称
            conne.Open();
            string sqlsku = "select * from IV_CONTAINER_VS_ITEM where CONTAINERID='" + xc + "'";
            SqlCommand cmdsku = new SqlCommand(sqlsku, conne);
            SqlDataReader readsku = cmdsku.ExecuteReader();
            while (readsku.Read())
            {
                sku += readsku["ITEMSKU"].ToString() + ";";
                desc += readsku["ITEMDESC"].ToString() + ";";
            }
            conne.Close();

            ////获取物料名称
            //string sqldesc = "select ITEMDESC from IV_CONTAINER_VS_ITEM where CONTAINERID='" + xc + "'";
            //conne.Open();
            //SqlCommand cmddesc = new SqlCommand(sqldesc, conne);
            //desc = cmddesc.ExecuteScalar().ToString();
            //conne.Close();


            Int32 param_index = 0;
            ushort K;

            GetDeviceParamWithoutStruct(param_index, (Int32)LEDSender2.NOTIFY_EVENT, (Int32)Handle, WM_LED_NOTIFY);

            K = (ushort)LEDSender2.Do_MakeRoot(LEDSender2.ROOT_PLAY, LEDSender2.COLOR_MODE_DOUBLE, LEDSender2.SURVIVE_ALWAYS);
            LEDSender2.Do_AddChapter(K, 30000, LEDSender2.WAIT_CHILD);
            LEDSender2.Do_AddRegion(K, 0, 0, 256, 160, 0);
            //添加表头
            LEDSender2.Do_AddLeaf(K, 10000000, LEDSender2.WAIT_CHILD);
            LEDSender2.Do_AddText(K, 0, 1, 256, 16, 1, 0, "吉利沃尔沃立体库", "宋体", 12, 255, 0, 0, 1, 1, 5, 1, 5, 0, 0, 100000);
            LEDSender2.Do_AddText(K, 10, 26,110, 16, 1, 0, "小车号:"+xc, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);      
            LEDSender2.Do_AddText(K, 125, 26, 131, 16, 1, 0, "任务类型:"+crk, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
            LEDSender2.Do_AddText(K, 10, 47, 256, 16, 1, 0, "物料号:"+sku, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
            LEDSender2.Do_AddText(K, 10, 69, 256, 16, 1, 0, "物料名称:"+desc, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
            LEDSender2.Do_AddText(K, 10, 92, 110, 16, 1, 0, "起始位:"+source, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
            LEDSender2.Do_AddText(K, 125, 92, 131, 16, 1, 0, "目标位:"+to, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
            LEDSender2.Do_AddText(K, 10, 116, 256, 16, 1, 0, "作业时间:"+DateTime.Now, "宋体", 11, 255, 0, 0, 0, 1, 5, 1, 5, 0, 0, 100000);
            LEDSender2.Do_AddText(K, 0, 140, 256, 16, 1, 0, "技术支持:伟本智能机电(上海)股份有限公司", "宋体", 10, 255, 0, 0, 1, 1, 5, 1, 5, 0, 0, 100000);

            Parse(LEDSender2.Do_LED_SendToScreen2(param_index, K));
            

        }

    }
}
