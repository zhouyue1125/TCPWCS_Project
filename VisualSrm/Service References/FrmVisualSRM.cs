using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Test.websrv;

namespace Test
{
    public partial class FrmVisualSRM : Form
    {
        Thread thread1,threadRead,threadRun;
        private const string LOCALSERVER = "S7:[@LOCALSERVER]";
        private const string StackerRead = "DB1,";
        private const string StackerWrite = "DB1,";

        string IsNewTask;
        int handShake = 0;
        public FrmVisualSRM()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            pictureBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != Color.Lime)
            {
                thread1 = new Thread(handshakeProc);
                thread1.IsBackground = true;
                thread1.Start();
                threadRead = new Thread(readTask);
                threadRead.IsBackground = true;
                threadRead.Start();
                threadRun = new Thread(SRMRun);
                threadRun.IsBackground = true;
                threadRun.Start();
                button1.BackColor = Color.Lime;
                pictureBox1.Enabled = true;
            }
            else
            {
                if (thread1.IsAlive)
                {
                    thread1.Join(10);
                    thread1.Abort();
                   
                }
                if (threadRun.IsAlive)
                {
                    threadRun.Join(10);
                    threadRun.Abort();
                  
                }
                if (threadRead.IsAlive)
                {
                    threadRead.Join(10);
                    threadRead.Abort();
                   
                }
                button1.BackColor = Color.Red;
                pictureBox1.Enabled = false;
            }
        }

        private void handshakeProc()
        {
            CheckForIllegalCrossThreadCalls = false;
            string WRITE_HandShake = LOCALSERVER + StackerWrite + "W999";//写入握手信号
            while (true)
            {
             if (handShake > 20000)
                handShake = 0;
             else
                handShake++;
                wait(1000);
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    srv.OPC_WritePoint(WRITE_HandShake, handShake);
                }
            }
        }

        private void readTask()
        {
            CheckForIllegalCrossThreadCalls = false;
            string fromPai, fromLie, fromCeng, toPai, toLie, toCeng, taskId, newTask;
            ArrayOfString items = new ArrayOfString();
            items.Add(LOCALSERVER + StackerWrite + "W42");//frompai 0
            items.Add(LOCALSERVER + StackerWrite + "W38");//fromlie 1
            items.Add(LOCALSERVER + StackerWrite + "W40");//fromceng 2
            items.Add(LOCALSERVER + StackerWrite + "W48");//topai 3
            items.Add(LOCALSERVER + StackerWrite + "W44");//tolie 4
            items.Add(LOCALSERVER + StackerWrite + "W46");//toceng 5
            items.Add(LOCALSERVER + StackerWrite + "W50");//taskid 6
            items.Add(LOCALSERVER + StackerWrite + "W52");//newtask 7
            while (true)
            {
                wait(1000);
                try
                {
                    using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                    {
                     
                        ArrayOfAnyType rsts = srv.OPC_Read(items);
                        if (rsts[7].ToString() == "1")
                        {
                            lbfromPai.Text = rsts[0].ToString();
                            lbFromLie.Text = rsts[1].ToString();
                            lbFromCeng.Text = rsts[2].ToString();
                            lbToPai.Text = rsts[3].ToString();
                            lbToLie.Text = rsts[4].ToString();
                            lbToCeng.Text = rsts[5].ToString();
                            lbTaskId.Text = "任务号:" + rsts[6].ToString();
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

        private void FrmVisualSRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread1.IsAlive)
            {
                thread1.Join(10);
                thread1.Abort();
                thread1 = null;
            }
            if (threadRun.IsAlive)
            {
                threadRun.Join(10);
                threadRun.Abort();
                threadRun = null;
            }
            if (threadRead.IsAlive)
            {
                threadRead.Join(10);
                threadRead.Abort();
                threadRead = null;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                string write_TaskFinish = LOCALSERVER + StackerRead + "X1.2";
                srv.OPC_WritePoint(write_TaskFinish, true);
                string write_NewTask = LOCALSERVER + StackerRead + "W52";
                srv.OPC_WritePoint(write_NewTask,0);
            }
        }

        /// <summary>
        /// 调节货叉位置
        /// </summary>
        private void SetFork(int Zero)
        {
            using(  ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                int maxForkDistance = Zero * 100;
                if (maxForkDistance > 0)
                {
                    for (int l = 0; l < maxForkDistance; l += 2)
                    {
                        srv.OPC_WritePoint(LOCALSERVER + StackerWrite + "INT18", l);//模拟伸叉位置 1排为正,二排为负
                    }
                    wait(1000);
                    for (int l = maxForkDistance; l >= 0; l -= 2)
                    {
                        srv.OPC_WritePoint(LOCALSERVER + StackerWrite + "INT18", l);//模拟收叉位置 1排为正,二排为负
                    }
                }
                if (maxForkDistance < 0)
                {
                    for (int l = 0; l > maxForkDistance; l -= 2)
                    {
                        srv.OPC_WritePoint(LOCALSERVER + StackerWrite + "INT18", l);//模拟伸叉位置 1排为正,二排为负
                    }
                    wait(300);
                    for (int l = maxForkDistance; l <= 0; l += 2)
                    {
                        srv.OPC_WritePoint(LOCALSERVER + StackerWrite + "INT18", l);//模拟收叉位置 1排为正,二排为负
                    }
                }
            }
           
        }

        private void SRMRun()
        {
            CheckForIllegalCrossThreadCalls = false;
            ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient();
            ArrayOfString tmp = new ArrayOfString();
            tmp.Add(LOCALSERVER + StackerRead + "D10");
            int YLocation =Int32.Parse(srv.OPC_Read(tmp)[0].ToString());//堆垛机水平距离
            while (true)
            {
                srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W8", 0);//空闲
                if (IsNewTask =="是")
                {
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.2", false);//任务完成                  
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X0.3", false);//取货完毕
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.3", false);//载货台有货
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.4", true);//货叉原点
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X0.4", false);//放货完毕
               
                    lsBRunning.Items.Add(DateTime.Now.ToString() + "堆垛机开始执行任务....");
                    wait(1000);
                    lsBRunning.Items.Add("开始定位准备取货");
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W8", 2);//定位
                    int lenth =int.Parse( lbFromLie.Text)*100;
                    while(lenth!=YLocation)
                    {
                        if (YLocation > lenth)
                            YLocation--;
                        else
                            YLocation++;
                        srv.OPC_WritePoint(LOCALSERVER + StackerRead + "D10", YLocation);//写入当前水平坐标   
                    }
                        wait(300);
                    lsBRunning.Items.Add("定位完毕,开始取货");
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W8", 3);//取货                  
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.4", false);//货叉原点

                    wait(300);
                    int zero = 1;
                    if (lbfromPai.Text.Trim() == "2")
                        zero = -1;
                    SetFork(zero);

                    wait(300);
                    lsBRunning.Items.Add("取货完毕,开始定位准备放货");
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X0.3", true);//取货完毕
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.3", true);//载货台有货
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.4", true);//货叉原点
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "INT18", 0);//伸叉位置 1排为正,二排为负
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W8", 2);//定位
                    lenth = int.Parse(lbToLie.Text) * 100;
                    while (lenth != YLocation)
                    {
                        if (YLocation > lenth)
                            YLocation--;
                        else
                            YLocation++;
                        srv.OPC_WritePoint(LOCALSERVER + StackerRead + "D10", YLocation);//写入当前水平坐标   
                    }
                    wait(500);
                    lsBRunning.Items.Add("定位完毕,开始放货");
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W8", 4);//放货
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.4", false);//货叉原点
                    wait(800);
                    zero = 1;
                    if (lbToPai.Text.Trim() == "2")
                        zero = -1;
                    SetFork(zero);
                    wait(300);
                    lsBRunning.Items.Add("放货完毕,执行完成");
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X0.4", true);//放货完毕
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.3", false);//载货台有货
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.4", true);//货叉原点
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "INT18", 0);
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W8", 0);//空闲
                    wait(200);
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "X1.2", true);//任务完成
                    srv.OPC_WritePoint(LOCALSERVER + StackerWrite + "W52", 0);//新任务下达
                    IsNewTask = "否";
                    wait(1000);
                }

            }
        }

        int alertSec = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                if (btn_Alert.Text == "报警")
                {

                    {
                        srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W90", alertSec++);//发送报警信号
                        switch (comboBox1.SelectedIndex)
                        {
                            case 0:
                                srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W6", 111);
                                break;
                            case 1:
                                srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W6", 105);
                                break;
                            case 2:
                                srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W6", 23);
                                break;
                            case 3:
                                srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W6", 11);
                                break;
                        }
                        btn_Alert.Text = "解除";
                    }

                }
                else
                {
                    srv.OPC_WritePoint(LOCALSERVER + StackerRead + "W90", 0);//发送报警解除
                    btn_Alert.Text = "报警";
                }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void FrmVisualSRM_Load(object sender, EventArgs e)
        {

        }
    }
}
