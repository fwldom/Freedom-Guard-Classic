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
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Freedom_Guard
{
    public partial class FreedomGuard : Form
    {
        public bool StatusGuard = false;
        private void add_services(string args)
        {
            Switchs = "";
            services = "";
            if (Gool_services.Checked)
            {
                Switchs += " --gool ";
                services += " + Gool ";
                PsCountry.SelectedIndex = 0;
            }
            if (scan_Warp.Checked)
            {
                Switchs += " --scan ";
                services += " + Scan  ";
            }
            if (PsCountry.SelectedItem.ToString() != "disable" && PsCountry.SelectedItem.ToString() != "")
            {
                Switchs += " --cfon --country " + (PsCountry.SelectedItem.ToString().Substring(PsCountry.SelectedItem.ToString().Length - 4).Replace("(", "").Replace(")", "")); ;
                services += $" + Psiphon {PsCountry.SelectedItem.ToString()}  ";
            }
        }
        public FreedomGuard()
        {
            InitializeComponent();
        }
        Process process = null;
        private void Log(string textlog)
        {
            LogApp.AppendText(textlog + Environment.NewLine);
        }
        public static bool PingWithSocks5Proxy(string proxyHost, int proxyPort, string targetUrl)
        {
            try
            {
                // Function For Test Connection With Socks5 Proxy 
                using (var client = new TcpClient(proxyHost, proxyPort))
                {
                    NetworkStream stream = client.GetStream();
                    byte[] initialHandshake = { 5, 1, 0 };
                    stream.Write(initialHandshake, 0, initialHandshake.Length);
                    byte[] response = new byte[2];
                    stream.Read(response, 0, response.Length);
                    if (response[0] == 5 && response[1] == 0)
                    {
                        byte[] request = new byte[7 + targetUrl.Length];
                        request[0] = 5; // SOCKS5 version
                        request[1] = 1; // Connect command
                        request[2] = 0; // Reserved byte
                        request[3] = 3; // Address type (domain name)
                        request[4] = (byte)targetUrl.Length; // Length of the domain name
                        Encoding.ASCII.GetBytes(targetUrl).CopyTo(request, 5); // Copy the domain name
                        BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)80)).CopyTo(request, 5 + targetUrl.Length); // Destination port

                        // Send the request to connect to the target URL
                        stream.Write(request, 0, request.Length);

                        // Receive the response from the SOCKS5 proxy
                        byte[] response2 = new byte[10];
                        stream.Read(response2, 0, response2.Length);

                        // Check if the connection to the target URL was successful
                        if (response2[1] == 0)
                        {

                            // Perform any additional operations here (e.g., send HTTP request, receive response)
                            // For simplicity, we are just printing success message.
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        public void TestConnect()
        {
            System.Threading.Thread.Sleep(5000);
            if (PingWithSocks5Proxy("127.0.0.1", 8086, "ircf.space"))
            {
                MessageBox.Show("Connected | متصل شدید");
            }
            else
            {
                MessageBox.Show("Not Connected Try Again | متصل نشد دوباره امتحان کنید");
                Stop_Guard();
            }
        }
        public string Switchs = "";
        private void start_Guard_Click(object sender, EventArgs e)
        {
            // Start Services
            string exePath = "warp-plus.exe";
            Stop_Guard();
            if (System.IO.File.Exists(exePath))
            {
                if (StatusGuard == false)
                {
                    ProgressBarStatus.Value = 10;
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = exePath,
                        UseShellExecute = true,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Arguments = Switchs
                    };
                    ProgressBarStatus.Value = 30;
                    process = Process.Start(startInfo);
                    Log("Start Services ...");
                    StatusLabel.Text = "Running Warp " + services + " ...";
                    string proxyAddress = "127.0.0.1";
                    string proxyPort = "8086";
                    bool proxyEnabled = true;
                    ProgressBarStatus.Value = 100;
                    SetProxySettings(proxyAddress, proxyPort, proxyEnabled);
                    ProgressBarStatus.Value = 0;
                    Log("Set Proxy Server ...");
                    if (Lang == "fa")
                    {
                        start_Guard.Text = "قطع اتصال";
                        StatusText.Text = "متصل شده";
                    }
                    else
                    {
                        start_Guard.Text = "Disconnect";
                        StatusText.Text = "Connected";
                        Thread TestConn = new Thread(TestConnect);
                        TestConn.Start();
                    }
                    StatusGuard = true;
                }
                else
                {
                    if (Lang == "fa")
                    {
                        start_Guard.Text = "اتصال";
                        StatusText.Text = "وصل نشده است";
                    }
                    else
                    {
                        start_Guard.Text = "Connect";
                        StatusText.Text = "Disconnected";
                    }
                    StatusGuard = false;
                    Stop_Guard();
                }

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
        private void Stop_Guard()
        {
            try
            {
                string proxyAddress = "127.0.0.1";
                string proxyPort = "8086";
                bool proxyEnabled = false;
                Log("Stoped All Services ...");
                SetProxySettings(proxyAddress, proxyPort, proxyEnabled);
                ProgressBarStatus.Value = 100;
                Log("Not Set Proxy Server ...");
                process.Kill();
            }
            catch
            {

            }
            StatusLabel.Text = "Not Running ";
            ProgressBarStatus.Value = 0;

        }
        public string Lang = "en";
        public string services = "";

        private void FreedomGuard_Load(object sender, EventArgs e)
        {
            try
            {
                var INIApp = new IniFile("Settings.ini");
                Lang = INIApp.Read("lang", "setting");
                if (INIApp.Read("gool", "setting") == "true")
                {
                    Gool_services.Checked = true;
                }
                if (INIApp.Read("ps", "setting") != "")
                {
                    PsCountry.SelectedIndex = Convert.ToInt32(INIApp.Read("ps", "setting"));
                }
                if (INIApp.Read("scan", "setting") == "true")
                {
                    scan_Warp.Checked = true;
                }
                if (INIApp.Read("runWtStart", "setting") == "true")
                {
                    start_Guard.PerformClick();
                    if (Lang == "fa")
                    {
                    }
                    else
                    {
                    }
                }
                else
                {
                    if (Lang == "fa")
                    {
                    }
                }
                add_services("");
            }
            catch
            {
                Lang = "en";

            }
            if (Lang == "fa")
            {
                start_Guard.Text = "اتصال";
                LabelLogApp.Text = "رویداد های برنامه";
                Gool_services.Text = "سرویس گول";
                StatusText.Text = "وصل نشده است";
                TextLabelTopPanel.Text = "گارد آزادی";
                TextShowps.Text = "کشور سایفون";
                Restart.Text = "اجرای مجدد برنامه";
                scan_Warp.Text = "اسکن وارپ";
                languageToolStripMenuItem.Text = "زبان ها";
                ExitApp.Text = "بستن برنامه";
                showAbout.Text = "درباره برنامه";
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


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Gool_services_CheckedChanged(object sender, EventArgs e)
        {
            add_services("");
            if (Gool_services.Checked == false)
            {
                var INIApp = new IniFile("Settings.ini");
                INIApp.Write("gool", "false", "setting");
            }
            else
            {
                var INIApp = new IniFile("Settings.ini");
                INIApp.Write("gool", "true", "setting");
            }
        }
        private void runServicesWithStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var INIApp = new IniFile("Settings.ini");
            if (INIApp.Read("runWtStart", "setting") == "true")
            {
                INIApp.Write("runWtStart", "false", "setting");
            }
            else
            {
                INIApp.Write("runWtStart", "true", "setting");
            }
            Application.Restart();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuShowHide_Click(object sender, EventArgs e)
        {
            if (MenuPanel.Visible == true)
            {
                MenuPanel.Visible = false;

            }
            else
            {
                MenuPanel.Visible = true;

            }
        }

        private void LogApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelLogApp_Click(object sender, EventArgs e)
        {

        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Stop_Guard();
            Application.Exit();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var INIApp = new IniFile("Settings.ini");
            INIApp.Write("lang", "en", "setting");
            Application.Restart();
        }

        private void persianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var INIApp = new IniFile("Settings.ini");
            INIApp.Write("lang", "fa", "setting");
            Application.Restart();
        }

        public void Console(string SwitchsOne)
        {
            string exePath = "warp-plus.exe";
            Stop_Guard();
            if (System.IO.File.Exists(exePath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = true,
                    Arguments = SwitchsOne
                };
                process = Process.Start(startInfo);
            }
            process.WaitForExit();
        }
        private void scan_Warp_CheckedChanged(object sender, EventArgs e)
        {
            add_services("");
            if (scan_Warp.Checked == false)
            {
                var INIApp = new IniFile("Settings.ini");
                INIApp.Write("scan", "false", "setting");
            }
            else
            {
                var INIApp = new IniFile("Settings.ini");
                INIApp.Write("scan", "true", "setting");
            }
        }

        private void PsCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PsCountry.SelectedItem.ToString() != "disable" & PsCountry.SelectedItem.ToString() != "")
            {
                Gool_services.Checked = false;
            }
            add_services("");
            var INIApp = new IniFile("Settings.ini");
            INIApp.Write("ps", PsCountry.SelectedIndex.ToString(), "setting");
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Stop_Guard();
            Application.Restart();
        }

        private void StatusText_Click(object sender, EventArgs e)
        {

        }

        private void ShowV2Ray_Click(object sender, EventArgs e)
        {
            Freedom_Guard_V2ray V2ray = new Freedom_Guard_V2ray();
            V2ray.Show();
        }

        private void ShowDns_Click(object sender, EventArgs e)
        {
            Freedom_Guard_Dns DNS = new Freedom_Guard_Dns();
            DNS.Show();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(-dragCursorPoint.X, -dragCursorPoint.Y);
                this.Location = new Point(dragFormPoint.X + newPoint.X,
                                           dragFormPoint.Y + newPoint.Y);
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            CloseApp.PerformClick();
        }

        private void FreedomGuard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop_Guard();
        }

        private void showAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Freedom Guard VPN + Warp + Gool + Psiphon + Dns Changer \n" +
                "Version : 1.2.2 \n" +
                "Contact : fwldom@duck.com \n" + 
                "Date Published : 1403/02/20 |  2024/05/09 \n","About Freedom Guard");

        }
    }
}
