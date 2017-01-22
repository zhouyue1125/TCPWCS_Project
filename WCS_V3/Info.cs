using System;
using System.Runtime.InteropServices;

namespace WCS_V3
{
    [StructLayout(LayoutKind.Sequential)]
    public class Info
    {
        public IntPtr ConnId { get; set; }
        public string IpAddress { get; set; }
        public ushort Port { get; set; }
    }
    public enum AppState
    {
        Starting, Started, Stoping, Stoped, Error
    }

}
