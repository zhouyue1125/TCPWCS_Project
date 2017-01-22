using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WCS_V3.OpcService;

namespace WCS_V3
{
    public partial class FormSt : Form
    {
        List<string> Items = null;
        Thread trSt1 = null;
        Thread trSt2 = null;
        bool bSt1 = false;
        bool bSt2 = false;

        public FormSt()
        {
            InitializeComponent();
        }
        public FormSt(List<string> items)
        {
            InitializeComponent();
            Items = items;
            trSt1 = new Thread(ctrlST1);
            trSt1.IsBackground = true;
            trSt1.Start();
            trSt2 = new Thread(ctrlST2);
            trSt2.IsBackground = true;
            trSt2.Start();
        }
        private void ctrlST1(object obj)
        {
            if (bSt1)
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    srv.OPC_WritePoint(Items[0], 1);
                    FormMain.wait(50);
                }
        }
        private void ctrlST2(object obj)
        {
            if (bSt2)
                using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
                {
                    srv.OPC_WritePoint(Items[1], 1);
                    FormMain.wait(50);
                }
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            bSt1 = true;
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            bSt1 = false;
            FormMain.wait(200);
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                srv.OPC_WritePoint(Items[0], 0);
            }
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            bSt2 = true;
        }

        private void btnDown_KeyUp(object sender, KeyEventArgs e)
        {
            bSt2 = false;
            FormMain.wait(200);
            using (ASRS_ServiceSoapClient srv = new ASRS_ServiceSoapClient())
            {
                srv.OPC_WritePoint(Items[1], 0);
            }
        }


    }
}
