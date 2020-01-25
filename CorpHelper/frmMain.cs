using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpHelper.Modules;
using System.Collections;

namespace CorpHelper
{
    public partial class frmMain : Form
    {
        public bool EnablePreventSleep { get; set; }
        public int PreventSleepInterval { get; set; }
        public bool InTaskBar { get; set; }
        public frmMain()
        {
            InitializeComponent();
            EnablePreventSleep = Properties.Settings.Default.EnableSleepPrevention;
            PreventSleepInterval = Properties.Settings.Default.SleepPreventionInterval;
            InTaskBar = Properties.Settings.Default.InTaskBar;
            PopulateSleepPreventionInterval(PreventSleepInterval);
            HandlePreventSleep(EnablePreventSleep);

        }
        private void PopulateSleepPreventionInterval(int DefaultInterval = 59000)
        {
            var key = "";
            var value = 0;
            for(var i = 0; i < 11; i++)
            {
                switch(i)
                {
                    case 0:
                        key = "30 Seconds";
                        value = 30000;
                        break;
                    case 1:
                        key = "45 Seconds";
                        value = 45000;
                        break;
                    case 2:
                        key = "1 Minute";
                        value = 59000;
                        break;
                    case 3:
                        key = "2 Minutes";
                        value = 119000;
                        break;
                    case 4:
                        key = "3 Minutes";
                        value = 179000;
                        break;
                    case 5:
                        key = "4 Minutes";
                        value = 239000;
                        break;
                    case 6:
                        key = "5 Minutes";
                        value = 299000;
                        break;
                    case 7:
                        key = "10 Minutes";
                        value = 599000;
                        break;
                    case 8:
                        key = "15 Minutes";
                        value = 899000;
                        break;
                    case 9:
                        key = "20 Minutes";
                        value = 1199000;
                        break;
                    case 10:
                        key = "30 Minutes";
                        value = 1799000;
                        break;
                }
                cbSleepPreventionInterval.Items.Add(new DictionaryEntry(key, value));
                if (value == DefaultInterval) cbSleepPreventionInterval.SelectedIndex = i;
            }
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
            switch (e.ClickedItem.Name.ToLower())
            {
                case "menuitemopen":
                    Show();
                    this.WindowState = FormWindowState.Normal;
                    notifyIconController.Visible = false;
                    break;
                case "menuitemexit":
                    Application.Exit();
                    break;
                case "menuitemtogglesleep":
                    HandlePreventSleep(!EnablePreventSleep);
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
            SleepPreventer.PreventFromSleep();
        }
        private void HandlePreventSleep(bool flag)
        {
            if(EnablePreventSleep == flag && tmrPreventSleep.Enabled == flag) return;
            UpdateStatus($"Prevent Sleep was {(flag ? "Enabled" : "Disabled")}.");
            EnablePreventSleep = flag;
            Properties.Settings.Default.EnableSleepPrevention = flag;
            if(this.chkbxSleepPrevention.Checked != flag) this.chkbxSleepPrevention.Checked = flag;
            tmrPreventSleep.Enabled = flag;
            notifyIconController.ShowBalloonTip(5000, "Sleep Preventer Set", $"Sleep Preventer: {(flag ? "Enabled" : "Disabled")}", ToolTipIcon.Info);
        }

        private void tmrPreventSleep_Tick(object sender, EventArgs e)
        {
            if (EnablePreventSleep) PreventFromSleep();
        }
        private void UpdateStatus(string text)
        {
            txtStatus.AppendText($"{Environment.NewLine}{DateTime.Now.ToString("HH:mm:ss.fff")}: {text}");
        }

        private void cbSleepPreventionInterval_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbSleepPreventionInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var interval = (int) ((DictionaryEntry)(comboBox.Items[comboBox.SelectedIndex])).Value;
            tmrPreventSleep.Interval = interval;
            Properties.Settings.Default.SleepPreventionInterval = interval;
            UpdateStatus($"Interval set to {interval.ToString()} ms.");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.InTaskBar = WindowState == FormWindowState.Minimized;
            Properties.Settings.Default.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(InTaskBar)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            HandlePreventSleep(EnablePreventSleep);
        }
    }
}
