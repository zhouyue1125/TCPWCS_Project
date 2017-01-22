using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LedShow
{
    public partial class frmLedDemo : Form
    {
        private const int WM_LED_NOTIFY = 1025;

        CLEDSender LEDSender = new CLEDSender();

        public frmLedDemo()
        {
            InitializeComponent();
        }

        private void GetDeviceParam(ref TDeviceParam param)
        {
            param.devType = LEDSender.DEVICE_TYPE_UDP;
            param.comPort = (ushort)Convert.ToInt16(eCommPort.Text);
            param.comSpeed = (ushort)cmbBaudRate.SelectedIndex;
            param.locPort = (ushort)Convert.ToInt16(eLocalPort.Text);
            param.rmtHost = eRemoteHost.Text;
            param.rmtPort = 6666;
            param.dstAddr = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LEDSender.Do_LED_Startup();
            //LEDSender.Do_LED_CloseDeviceOnTerminate(1);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            LEDSender.Do_LED_Cleanup();
        }

        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            TSenderParam param = new TSenderParam();
            GetDeviceParam(ref param.devParam);
            param.notifyMode = LEDSender.NOTIFY_EVENT;
            param.wmHandle = (UInt32)Handle;
            param.wmMessage = (UInt32)WM_LED_NOTIFY;
            LEDSender.Do_LED_SetPower(ref param, 1);
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            TSenderParam param = new TSenderParam();
            GetDeviceParam(ref param.devParam);
            param.notifyMode = LEDSender.NOTIFY_EVENT;
            param.wmHandle = (UInt32)Handle;
            param.wmMessage = (UInt32)WM_LED_NOTIFY;
            LEDSender.Do_LED_SetPower(ref param, 0);
        }

    }
}
