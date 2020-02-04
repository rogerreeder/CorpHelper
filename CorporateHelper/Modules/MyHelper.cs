using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CorporateHelper.Modules
{
    public static class MyHelper
    {
        public static void UpdateAutoStart(bool StartIt)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if(StartIt)
            {
                rk.SetValue(Application.ProductName, Application.ExecutablePath);
            } else
            {
                rk.DeleteValue(Application.ProductName);
            }
        }
    }
}
