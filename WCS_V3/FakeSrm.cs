using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WCS_V3
{
    public partial class FakeSrm : Form
    {
        Thread trHandShake,
               trRead,
               trRun;

        string IsNewTask;
        int handShake = 0;

        public FakeSrm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

    
        private void btnPower_Click(object sender, EventArgs e)
        {
            if (btnPower.BackColor != Color.Lime)
            {
                trHandShake = new Thread(handshakeProc);
                trHandShake.IsBackground = true;
                trHandShake.Start();
                trRead = new Thread(readTask);
                trRead.IsBackground = true;
                trRead.Start();
                trRun = new Thread(SRMRun);
                trRun.IsBackground = true;
                trRun.Start();
                VirsualSrm.rWorkMode = 1;
                btnPower.BackColor = Color.Lime;
            }
            else
            {
                if (trRead.IsAlive)
                {
                    trRead.Join(10);
                    trRead.Abort();
                }
                if (trRun.IsAlive)
                {
                    trRun.Join(10);
                    trRun.Abort();
                }
                if (trHandShake.IsAlive)
                {
                    trHandShake.Join(10);
                    trHandShake.Abort();
                }
                VirsualSrm.rWorkMode = 0;
                btnPower.BackColor = Color.Red;
            }
        }

        private void readTask(object obj)
        {
            string fromPai, fromLie, fromCeng, toPai, toLie, toCeng, orderType, newTask;
            while (true)
            {
                wait(1000);
                try
                {
                    fromPai = VirsualSrm.wSourcePai.ToString();
                    fromLie = VirsualSrm.wSourceCol.ToString();
                    fromCeng = VirsualSrm.wSourceLayer.ToString();
                    toCeng = VirsualSrm.wToLayer.ToString();
                    toLie = VirsualSrm.wToCol.ToString();
                    toPai = VirsualSrm.wToPai.ToString();
                    orderType = VirsualSrm.wOrderType.ToString();
                    //orderType = VirsualSrm.wNewTask.ToString();
                    if (orderType == "1")
                    {
                        VirsualSrm.rTaskId = VirsualSrm.wTaskID;
                        if (VirsualSrm.wNewTask.ToString() == "1")
                        {
                            lbfromPai.Text = fromPai;
                            lbFromLie.Text = fromLie;
                            lbFromCeng.Text = fromCeng;
                            lbToPai.Text = toPai;
                            lbToLie.Text = toLie;
                            lbToCeng.Text = toCeng;
                            lbTaskId.Text = "任务号:" + VirsualSrm.wTaskID.ToString();
                            IsNewTask = "是";
                            lbIsNewTask.Text = "是否下发:" + "是";
                        }
                        else
                        {
                            lbIsNewTask.Text = "是否下发:" + "否";
                            IsNewTask = "否";
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// 系统等待XX毫秒
        /// </summary>
        /// <param name="Milliseconds"></param>
        public static void wait(int Milliseconds)
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();               
            } while (Tthen.AddMilliseconds(Milliseconds) > DateTime.Now);
        }

        private void handshakeProc(object obj)
        {
            while (true)
            {
                if (handShake > 20000)
                    handShake = 0;
                else
                    handShake++;
                wait(500);
                VirsualSrm.rHandShake = handShake;
                Thread.Sleep(5);
            }
        }

   

        private void btnTaskFinish_Click(object sender, EventArgs e)
        {

            VirsualSrm.rTaskFinish = true;
            VirsualSrm.wNewTask = 0;
            VirsualSrm.rTaskId = 0;
        }

        private void SRMRun()
        {
            int YLocation = Int32.Parse(VirsualSrm.rTravelPos.ToString());//堆垛机水平距离
            while (true)
            {
               VirsualSrm.rWorkStatus=0;//空闲
                if (IsNewTask == "是")
                {
                    VirsualSrm.rTaskFinish = false;
                    VirsualSrm.rGetFinish = false;
                    VirsualSrm.rLoaded = false;
                    VirsualSrm.rPutFinish = false;
                    VirsualSrm.rForkZero = true;
                    Random rd = new Random();
                    VirsualSrm.INHightNo = rd.Next(1, 5);
                    lsBRunning.Items.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "堆垛机开始执行任务....");
                    wait(1000);
                    lsBRunning.Items.Add("开始定位准备取货");
                    VirsualSrm.rWorkStatus = 1;//定位
                    
                    int lenth = (int)(int.Parse(lbFromLie.Text) * 56.2+83);
                    while (lenth != YLocation)
                    {
                        if (YLocation > lenth)
                            YLocation--;
                        else
                            YLocation++;
                       VirsualSrm.rTravelPos=YLocation;//写入当前水平坐标  
                       wait(30);  
                    }
                  
                    Thread.Sleep(5);
                    lsBRunning.Items.Add("定位完毕,开始取货");

                    VirsualSrm.rWorkStatus = 3;//取货                  
                    VirsualSrm.rForkZero = false; ;//货叉原点
                    wait(300);
                    Thread.Sleep(5);
                    int direct = 1;                  
                    SetFork(direct);
                    wait(300);
                    lsBRunning.Items.Add("取货完毕,开始定位准备放货");
                    VirsualSrm.rGetFinish = true;//取货完毕
                    VirsualSrm.rLoaded = true;//载货台有货
                    VirsualSrm.rForkZero = true;
                    VirsualSrm.rForkPos = 84;   //伸叉位置 1排为正,二排为负
                    VirsualSrm.rWorkStatus=4;//定位
                    lenth = (int)(int.Parse(lbToLie.Text) * 56.2 + 83);
                    while (lenth != YLocation)
                    {
                        if (YLocation > lenth)
                            YLocation--;
                        else
                            YLocation++;
                        VirsualSrm.rTravelPos = YLocation;//写入当前水平坐标  
                        wait(30);
                    }
                   
                    Thread.Sleep(5);
                    lsBRunning.Items.Add("定位完毕,开始放货");
                    VirsualSrm.rWorkStatus = 6;//放货
                    VirsualSrm.rForkZero = false;//货叉原点
                    wait(800);
                    Thread.Sleep(5);
                    direct = 1;
                    if (lbToPai.Text.Trim() == "2")
                        direct = -1;
                    SetFork(direct);
                    wait(300);
                    lsBRunning.Items.Add("放货完毕,执行完成");
                    VirsualSrm.rPutFinish = true;//放货完毕
                    VirsualSrm.rLoaded = false;//载货台有货
                    VirsualSrm.rForkZero = true;//货叉原点   
                    VirsualSrm.rForkPos=80;//伸叉位置 80为原点
                    VirsualSrm.rWorkStatus = 0;//空闲
                    VirsualSrm.rTaskId = -1;
                    VirsualSrm.wOrderType = 0;
                    wait(200);
                    VirsualSrm.rTaskFinish=true;//任务完成
                    VirsualSrm.wNewTask = 0 ;//新任务下达
                    IsNewTask = "否";
                    wait(1000);
                }

            }
        }

        /// <summary>
        /// 调节货叉位置 原点：80 上限：16 下限：144
        /// </summary>
        private void SetFork(int direct)
        {
            int zero = 84;
            int topPos = 22;
           

            if (direct > 0)//1排
            {
                for (int l = zero; l > topPos; l--)
                {
                    VirsualSrm.rForkPos = l; ;//模拟伸叉位置 1排为正,二排为负
                    wait(50);
                }
                wait(500);
                Thread.Sleep(5);
                for (int l = topPos; l <= zero; l++)
                {
                    VirsualSrm.rForkPos = l;//模拟收叉位置 1排为正,二排为负
                    wait(50);
                }
            }           
        }

        int alertSec = 1;
        private void btn_Alert_Click(object sender, EventArgs e)
        {
            if (btn_Alert.Text == "报警")
            {
                VirsualSrm.rIsAlarm = alertSec++;//发送报警信号
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        VirsualSrm.rAlarmCode = 111;
                        break;
                    case 1:
                        VirsualSrm.rAlarmCode = 105;
                        break;
                    case 2:
                        VirsualSrm.rAlarmCode = 23;
                        break;
                    case 3:
                        VirsualSrm.rAlarmCode = 11;
                        break;
                }
                btn_Alert.Text = "解除";
            }
            else
            {
                VirsualSrm.rIsAlarm = 0;//发送报警解除
                btn_Alert.Text = "报警";
            }
        }

        private void FakeSrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (trRead.IsAlive)
            {
                trRead.Join(10);
                trRead.Abort();
            }
            if (trRun.IsAlive)
            {
                trRun.Join(10);
                trRun.Abort();
            }
            if (trHandShake.IsAlive)
            {
                trHandShake.Join(10);
                trHandShake.Abort();
            }
        }
    }
}
