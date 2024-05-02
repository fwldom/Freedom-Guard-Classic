using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Freedom_Guard
{
    public partial class FreedomGuard : Form
    {
        public FreedomGuard()
        {
            InitializeComponent();
        }
        Process process = null;
        private void Log(string textlog)
        {
            LogApp.AppendText(textlog + Environment.NewLine);
        }
        public string Switchs = "";
        private void start_Guard_Click(object sender, EventArgs e)
        {
            // Start Application
            string exePath = "warp-plus.exe";
            Stop_Guard.PerformClick();
            if (System.IO.File.Exists(exePath))
            {
                ProgressBarStatus.Value = 10;
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = true,
                    Arguments = Switchs
                };
                ProgressBarStatus.Value = 30;
                process = Process.Start(startInfo);
                Log("Start Services ...");
                StatusLabel.Text = "Running Warp + " + services + " ...";
                string proxyAddress = "127.0.0.1";
                string proxyPort = "8086";
                bool proxyEnabled = true;
                ProgressBarStatus.Value = 100;
                SetProxySettings(proxyAddress, proxyPort, proxyEnabled);
                ProgressBarStatus.Value = 0;
                Log("Set Proxy Server ...");
            }
            else
            {
                MessageBox.Show("Not Started");
                ProgressBarStatus.Value = 0;
                Log("Error Not Start Services ...");
            }

        }
        static void SetProxySettings(string proxyAddress, string proxyPort, bool proxyEnabled)
        {
            string registryKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings";
            int proxyEnabledValue = proxyEnabled ? 1 : 0;
            string proxyServerValue = $"{proxyAddress}:{proxyPort}";
            Registry.SetValue(registryKey, "ProxyServer", proxyServerValue);
            Registry.SetValue(registryKey, "ProxyEnable", proxyEnabledValue);
            Registry.SetValue(registryKey, "ProxyServerFlags", 3);
        }
        private void Stop_Guard_Click(object sender, EventArgs e)
        {
            try
            {
                process.Kill();
                ProgressBarStatus.Value = 100;
                string proxyAddress = "127.0.0.1";
                string proxyPort = "8086";
                bool proxyEnabled = false;
                Log("Stoped All Services ...");
                SetProxySettings(proxyAddress, proxyPort, proxyEnabled);
                ProgressBarStatus.Value = 0;
                Log("Not Set Proxy Server ...");
            }
            catch
            {

            }
        }

        private void exitAndStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop_Guard.PerformClick();
            Application.Exit();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop_Guard.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string Lang = "en";
        private void FreedomGuard_Load(object sender, EventArgs e)
        {
            try
            {
                var INIApp = new IniFile("Settings.ini");
                Lang = INIApp.Read("lang", "setting");
            }
            catch
            {
                Lang = "en";

            }
            if (Lang == "fa")
            {
                start_Guard.Text = "شروع";
                Stop_Guard.Text = "متوقف";
                LabelLogApp.Text = "رویداد های برنامه";
                programToolStripMenuItem.Text = "برنامه";
                languagesToolStripMenuItem.Text = "زبان";
                exitAndStopToolStripMenuItem.Text = "خروج و متوقف کردن سرویس";
                exitToolStripMenuItem.Text = "خروج";
                stopToolStripMenuItem.Text = "متوقف کردن سرویس";
                Gool_services.Text = "سرویس گول";
                MainMenu.RightToLeft = RightToLeft.Yes;
            }
        }
        class IniFile   // revision 11
        {
            string Path;
            string EXE = Assembly.GetExecutingAssembly().GetName().Name;

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

            public IniFile(string IniPath = null)
            {
                Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
            }

            public string Read(string Key, string Section = null)
            {
                var RetVal = new StringBuilder(255);
                GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
                return RetVal.ToString();
            }

            public void Write(string Key, string Value, string Section = null)
            {
                WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
            }

            public void DeleteKey(string Key, string Section = null)
            {
                Write(Key, null, Section ?? EXE);
            }

            public void DeleteSection(string Section = null)
            {
                Write(null, null, Section ?? EXE);
            }

            public bool KeyExists(string Key, string Section = null)
            {
                return Read(Key, Section).Length > 0;
            }
        }

        private void persianفارسیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var INIApp = new IniFile("Settings.ini");
            INIApp.Write("lang", "fa", "setting");
            Application.Restart();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var INIApp = new IniFile("Settings.ini");
            INIApp.Write("lang", "en", "setting");
            Application.Restart();
        }
        public string services = "";
        private void Gool_services_Click(object sender, EventArgs e)
        {
            services = "Gool";
            Switchs = "--gool";
            Gool_services.Text += " ✅";
            var INIApp = new IniFile("Settings.ini");
            INIApp.Write("gool", "true", "setting");
        }
    }
}
