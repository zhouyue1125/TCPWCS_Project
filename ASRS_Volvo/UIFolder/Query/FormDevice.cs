using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ASRS_Volvo.ServiceForVolvo;


namespace ASRS_ChangAn.UIFolder.Query
{
    public partial class FormDevice : Form
    {
        Thread refreshDevice;
        ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient();
        DU_Device srm = new DU_Device();
        List<IV_place_vs_container> pvc = null;
        List<Query_Stored> PlaceOfEmptyContainer = null;
        List<Query_Stored> storedplaceInfo = null;
        List<Query_Stored> Stored_cache = null;
        List<IV_container_vs_item> containerVsItemCache = null;
        private List<string> emptyplaceInfo, lockedplace;

        public FormDevice()
        {
            InitializeComponent();
            
            pvc = new List<IV_place_vs_container>();
            PlaceOfEmptyContainer = new List<Query_Stored>();
            storedplaceInfo = new List<Query_Stored>();
        }
        private void FormDevice_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
            /***********************************************/
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
               containerVsItemCache= srv.Container_Vs_Items_GetAll().ToList();
             
            }

            //后台线程，实时刷新库存
            refreshDevice = new Thread(DeviceRead);
            refreshDevice.IsBackground = true;
            refreshDevice.Start();
        }

        /// <summary>
        /// 根据列和层数初始化货架模型
        /// </summary>
        /// <param name="sender">控件</param>
        /// <param name="column">列</param>
        /// <param name="layer">层</param>
        private void initialForRack(object sender, int row, int column, int layer)
        {
            (sender as Panel).Controls.Clear();
            int pnlWidth = (sender as Panel).Width;
            int pnlHeight = (sender as Panel).Height;
            string r = row.ToString();
            string c = "";
            string l = "";
            (sender as Panel).Margin = new Padding(1, 1, 1, 5);
            for (int i = 1; i <= column; i++)
            {
                if (row == 2)
                {
                    for (int j = 1; j <= layer; j++)
                    {
                        Label lb = new Label();
                        if (i < 10)
                        {
                            c = "0" + i.ToString();
                        }
                        else
                        {
                            c = i.ToString();
                        }
                        if (j < 10)
                        {
                            l = "0" + j.ToString();
                        }
                        else
                        {
                            l = j.ToString();
                        }
                        lb.Width = pnlWidth / column;
                        lb.Height = pnlHeight / layer;
                        lb.Margin = new Padding(1, 1, 1, 1);
                        int y = (j - 1) * lb.Height;


                        int x = (i - 1) * lb.Width;

                        Point startlocation = new Point(x, y);
                        lb.Location = startlocation;
                        lb.Text = r + c + l;
                        lb.ForeColor = Color.Blue;
                        lb.BorderStyle = BorderStyle.FixedSingle;
                        lb.TextAlign = ContentAlignment.MiddleCenter;

                        (sender as Panel).Controls.Add(lb);

                    }
                }
                else if (row == 1)//一排从下至上排列
                {
                    for (int j = layer; j >= 1; j--)
                    {
                        Label lb = new Label();
                        if (i < 10)
                        {
                            c = "0" + i.ToString();
                        }
                        else
                        {
                            c = i.ToString();
                        }
                        if (j < 10)
                        {
                            l = "0" + j.ToString();
                        }
                        else
                        {
                            l = j.ToString();
                        }
                        lb.Width = pnlWidth / column;
                        lb.Height = pnlHeight / layer;
                        lb.Margin = new Padding(1, 1, 1, 1);
                        int y = pnlHeight - j * lb.Height;

                        int x = (i - 1) * lb.Width;

                        Point startlocation = new Point(x, y);
                        lb.Location = startlocation;
                        lb.Text = r + c + l;
                        lb.ForeColor = Color.Blue;
                        lb.BorderStyle = BorderStyle.FixedSingle;
                        lb.TextAlign = ContentAlignment.MiddleCenter;

                        (sender as Panel).Controls.Add(lb);

                    }
                }
            }
        }


        /// <summary>
        /// 初始化列数列表
        /// </summary>
        /// <param name="column"></param>
        private void initialNumberOfColumn(object sender, int column)
        {
            (sender as Panel).Controls.Clear();
            int pnlWidth = (sender as Panel).Width;
            int pnlHeight = (sender as Panel).Height;
            for (int i = 1; i <= column; i++)
            {
                Label lb = new Label();
                if (i < 10)
                {
                    lb.Text = "0" + i.ToString();
                }
                else
                {
                    lb.Text = i.ToString();
                }
                lb.Width = pnlWidth / column;
                lb.Height = pnlHeight;
                lb.Margin = new Padding(2, 1, 0, 1);
                int y = 0;
                int x = (i - 1) * lb.Width + lb.Width / 4;
                Point startlocation = new Point(x, y);
                lb.Location = startlocation;
                (sender as Panel).Controls.Add(lb);
            }
        }

        /// <summary>
        /// 初始化层数列表
        /// </summary>
        /// <param name="column"></param>
        private void initialNumberOfLayer(object sender, int layer)
        {
            if ((sender as Panel).Name == "pnl_LayerFor1")
            {
                (sender as Panel).Controls.Clear();
                int pnlWidth = (sender as Panel).Width;
                int pnlHeight = (sender as Panel).Height;
                for (int i = layer; i > 0; i--)
                {
                    Label lb = new Label();
                    if (i < 10)
                    {
                        lb.Text = "0" + i.ToString();
                    }
                    else
                    {
                        lb.Text = i.ToString();
                    }
                    lb.Width = pnlWidth;
                    lb.Height = pnlHeight / layer;
                    lb.Margin = new Padding(1, 2, 1, 0);
                    int y = pnlHeight - ((i - 1) * lb.Height + lb.Height / 4) - (int)(lb.Height * 0.6);
                    int x = 0;
                    Point startlocation = new Point(x, y);
                    lb.Location = startlocation;
                    (sender as Panel).Controls.Add(lb);
                    (sender as Panel).Refresh();
                }
            }
            else
            {
                (sender as Panel).Controls.Clear();
                int pnlWidth = (sender as Panel).Width;
                int pnlHeight = (sender as Panel).Height;
                for (int i = 1; i <= layer; i++)
                {
                    Label lb = new Label();
                    if (i < 10)
                    {
                        lb.Text = "0" + i.ToString();
                    }
                    else
                    {
                        lb.Text = i.ToString();
                    }
                    lb.Width = pnlWidth;
                    lb.Height = pnlHeight / layer;
                    lb.Margin = new Padding(1, 2, 1, 0);
                    int y = (i - 1) * lb.Height + lb.Height / 4;
                    int x = 0;
                    Point startlocation = new Point(x, y);
                    lb.Location = startlocation;
                    (sender as Panel).Controls.Add(lb);
                    (sender as Panel).Refresh();
                }
            }
        }

       

        private void RefreshRack1()
        {
            pnl_Rack1.Invoke(new Action(initialForRack1));

        }

        //private void RefreshRack2()
        //{
        //    pnl_Rack2.Invoke(new Action(initialForRack2));
        //}
        private void initialForRack1()
        {
            initialForRack(pnl_Rack1, 1, 12, 5);
        }
        //private void initialForRack2()
        //{
        //    initialForRack(pnl_Rack2, 2, 16, 5);
        //}
        private void btnReload_Click(object sender, EventArgs e)
        {
            initialNumberOfLayer(pnl_LayerFor1, 5);
            initialNumberOfColumn(pnl_ColFor1, 12);
            //initialNumberOfLayer(pnl_LayerFor2, 4);
            //initialNumberOfColumn(pnl_ColFor2,8);
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                //var t1 = new Thread(RefreshRack2);//刷新第二排货架
                //t1.Start();
                var t2 = new Thread(RefreshRack1);//刷新第一排货架
                t2.Start();
            }
            wait(200);
            RefreshAll();
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
        public void RefreshAll()
        {
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                Stored_cache = srv.Query_Stored_GetAll().ToList();
                emptyplaceInfo = Stored_cache.Where(x => string.IsNullOrEmpty(x.CONTAINERID)).Select(x => x.PLACEID).ToList(); //获取空库位

                storedplaceInfo = Stored_cache.Where(x => x.CONTAINERID != "" && !string.IsNullOrEmpty(x.ITEMSKU)).ToList();//获取有货库位
                lb_hasItem.Text = storedplaceInfo.Select(x => x.PLACEID).Distinct().Count().ToString() + "个";
                PlaceOfEmptyContainer = Stored_cache.Where(x => !string.IsNullOrEmpty(x.CONTAINERID) && string.IsNullOrEmpty(x.ITEMSKU)).ToList();//获取空托盘所在库位
                lb_EmptyContainer.Text = PlaceOfEmptyContainer.Count.ToString() + "个";
                lockedplace = srv.PL_PLACE_GetLockedPlace();//获取被锁定库位
                lb_isLock.Text = lockedplace.Count.ToString() + "个";
                lb_emptyPlace.Text = (emptyplaceInfo.Count - lockedplace.Count).ToString() + "个";
            }
            BindingPlace();//将数据和对应的lable对应并分别显示不同的颜色
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 鼠标悬停是更新右键菜单的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        
        private void lb_Mousehover(object sender, EventArgs e)
        {
            string plcID;
            if (sender is Label)
            {
                contextMenuStrip1.Items["plcID"].Text = "库位号:";
                contextMenuStrip1.Items["Sku"].Text = "物料号: "; //初始化右键菜单
                contextMenuStrip1.Items["SkuDesc"].Text = "物料名称: ";
                contextMenuStrip1.Items["QTY"].Text = "数量: ";
            

                try
                {
                    Label lb = sender as Label;

                        plcID = lb.Text.Trim();

                    StringBuilder sb = new StringBuilder();//获取物料号.物料名称,状态,数量

                    var storeds = Stored_cache.FindAll(x => x.PLACEID == plcID);
                    if (storeds != null && storeds.Count > 0)
                    {
                        foreach (var it in storeds)
                        {
                            contextMenuStrip1.Items["plcID"].Text = "库位号:" + it.PLACEID + ";";
                            contextMenuStrip1.Items["Sku"].Text += it.ITEMSKU + "; ";
                            contextMenuStrip1.Items["SkuDesc"].Text += it.ITEMDESC + "; ";
                            contextMenuStrip1.Items["QTY"].Text += it.ITEMQTY + "; ";
                        }
                    }

                }
                catch
                {
                    this.Show();
                }

            }
        }

       


        private void BindingPlace()
        {

            foreach (Control c in pnl_Rack1.Controls)//查找在pn_01中的所有控件
            {
                if (c is Label)//如果是Label
                {
                    Label lb = c as Label;
                    // lb.MouseDoubleClick += new MouseEventHandler(lb_Click);
                    string listFind = "";
                    //用List.Find方法加兰姆达表达式在几个List中分别查找库位的情况
                    listFind = lockedplace.Find(x => x == lb.Text.Trim());
                    if (!string.IsNullOrEmpty(listFind))
                    {
                        lb.BackColor = Color.Red;
                        lb.Visible = false;
                    }
                    listFind = "";

                    listFind = emptyplaceInfo.Find(x => x == lb.Text.Trim()); //将代表空库位的Lable设置为灰色

                    if (!string.IsNullOrEmpty(listFind))
                    {
                        if (lb.BackColor != Color.Red)
                        {
                            lb.BackColor = Color.Gray;
                        }
                    }
                    listFind = "";

                    var tmp2 = PlaceOfEmptyContainer.FindAll(x => x.PLACEID == lb.Text.Trim());
                    if (tmp2 != null && tmp2.Count > 0)
                    {
                        if ( lb.BackColor != Color.Red)
                        {
                            lb.BackColor = Color.Lime;                           
                        }

                    }
                    listFind = "";
                    var tmp1 = (storedplaceInfo.Find(x => x.PLACEID == lb.Text.Trim()));  //将代表有货库位的Lable设置为蓝色
                    if (tmp1 != null)
                        listFind = tmp1.PLACEID;
                    if (!string.IsNullOrEmpty(listFind))
                    {
                        lb.BackColor = Color.Aqua;
                        lb.ContextMenuStrip = contextMenuStrip1;//添加右键点击菜单
                        lb.MouseHover += new EventHandler(lb_Mousehover);
                       

                    }


                }
            }
           
        }

        private void pnl_Rack1_SizeChanged(object sender, EventArgs e)
        {
            initialNumberOfLayer(pnl_LayerFor1, 5);
            initialNumberOfColumn(pnl_ColFor1, 12);
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                //var t1 = new Thread(RefreshRack2);//刷新第二排货架
                //t1.Start();
                var t2 = new Thread(RefreshRack1);//刷新第一排货架
                t2.Start();
            }
           wait(200);
           RefreshAll();
        }

        //实时刷新库存
        private void DeviceRead(object obj)
        {
            string nowrlsod="";
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                while (true) {
                    Thread.Sleep(1000);
                    var rlsod = srv.Od_Task_GetCurrentTaskByDeviceID("SRM_1");
                    if (nowrlsod != rlsod.TASKID)
                    {
                        nowrlsod = rlsod.TASKID;
                        RefreshAll();
                    }
                }
            }
        }

    }
}
