using System;
using System.Runtime.InteropServices;

namespace OrderReceiptGUI.Utilities
{
    public static class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
    }
}
