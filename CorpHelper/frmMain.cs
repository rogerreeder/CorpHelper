using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
    

namespace CorpHelper
{
    public partial class frmMain : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        public bool PreventSleep { get; set; }
        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED= 0x00000001
        }
        public frmMain()
        {
            InitializeComponent();
            HandlePreventSleep(false);
        }

        private void chkbxSleepPrevention_CheckedChanged(object sender, EventArgs e)
        {
            HandlePreventSleep( this.chkbxSleepPrevention.Checked);

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //if the form is minimized
            //hide it from the task bar
            //and show the system tray icon (represented by the NotifyIcon Control
            if(this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIconController.Visible = true;
            }
        }

        private void notifyIconController_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIconController.Visible = false;
        }


        private void cmMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "menuItemExit":
                    Application.Exit();
                    break;
                case "menuItemToggleSleep":
                    HandlePreventSleep(!PreventSleep);
                    break;
            }
            cmMain.Visible = false;
        }

        private void notifyIconController_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                cmMain.Visible = true;
            }
        }


        private void PreventFromSleep()
        {
            UpdateStatus($"PreventFromSleep was called.");
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
        }
        private void HandlePreventSleep(bool flag)
        {
            if(PreventSleep == flag) return;
            UpdateStatus($"Prevent Sleep was {(flag ? "Enabled" : "Disabled")}.");
            PreventSleep = flag;
            if(this.chkbxSleepPrevention.Checked != flag) this.chkbxSleepPrevention.Checked = flag;
            if (flag) PreventFromSleep();
            tmrPreventSleep.Enabled = flag;
            notifyIconController.ShowBalloonTip(5000, "Sleep Preventer Set", $"Sleep Preventer: {(flag ? "Enabled" : "Disabled")}", ToolTipIcon.Info);
        }

        private void tmrPreventSleep_Tick(object sender, EventArgs e)
        {
            if (PreventSleep) PreventFromSleep();
        }
        private void UpdateStatus(string text)
        {
            txtStatus.AppendText($"{Environment.NewLine}{DateTime.Now.ToString("HH:mm:ss.fff")}: {text}");
        }
    }
}
