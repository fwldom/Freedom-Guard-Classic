using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace Freedom_Guard
{
    public partial class Freedom_Guard_Dns : Form
    {
        Process process = new Process();
        public Freedom_Guard_Dns()
        {
            InitializeComponent();
        }

        private void DnsSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DnsSelector.SelectedIndex == 0)
            {
                IpDNS1.Text = "8";
                IpDNS2.Text = "8";
                IpDNS3.Text = "8";
                IpDNS4.Text = "8";
                IpDNS11.Text = "8";
                IpDNS12.Text = "8";
                IpDNS13.Text = "4";
                IpDNS14.Text = "4";
            }
            else if (DnsSelector.SelectedIndex == 1)
            {
                IpDNS1.Text = "1";
                IpDNS2.Text = "1";
                IpDNS3.Text = "1";
                IpDNS4.Text = "1";
                IpDNS11.Text = "1";
                IpDNS12.Text = "0";
                IpDNS13.Text = "0";
                IpDNS14.Text = "1";
            }
            else if (DnsSelector.SelectedIndex == 2)
            {
                IpDNS1.Text = "";
                IpDNS2.Text = "";
                IpDNS3.Text = "";
                IpDNS4.Text = "";
                IpDNS11.Text = "";
                IpDNS12.Text = "";
                IpDNS13.Text = "";
                IpDNS14.Text = "";
            }
            else if (DnsSelector.SelectedIndex == 3)
            {
                IpDNS1.Text = "1";
                IpDNS2.Text = "1";
                IpDNS3.Text = "1";
                IpDNS4.Text = "1";
                IpDNS11.Text = "1";
                IpDNS12.Text = "0";
                IpDNS13.Text = "0";
                IpDNS14.Text = "1";
            }
            else if (DnsSelector.SelectedIndex == 4)
            {
                IpDNS1.Text = "208";
                IpDNS2.Text = "67";
                IpDNS3.Text = "222";
                IpDNS4.Text = "222";
                IpDNS11.Text = "208";
                IpDNS12.Text = "67";
                IpDNS13.Text = "220";
                IpDNS14.Text = "220";
            }
            else if (DnsSelector.SelectedIndex == 5)
            {
                IpDNS1.Text = "8";
                IpDNS2.Text = "26";
                IpDNS3.Text = "56";
                IpDNS4.Text = "26";
                IpDNS11.Text = "8";
                IpDNS12.Text = "20";
                IpDNS13.Text = "247";
                IpDNS14.Text = "20";
            }
            else if (DnsSelector.SelectedIndex == 6)
            {
                IpDNS1.Text = "9";
                IpDNS2.Text = "9";
                IpDNS3.Text = "9";
                IpDNS4.Text = "9";
                IpDNS11.Text = "9";
                IpDNS12.Text = "9";
                IpDNS13.Text = "9";
                IpDNS14.Text = "9";
            }
            else if (DnsSelector.SelectedIndex == 7)
            {
                IpDNS1.Text = "64";
                IpDNS2.Text = "6";
                IpDNS3.Text = "64";
                IpDNS4.Text = "6";
                IpDNS11.Text = "64";
                IpDNS12.Text = "6";
                IpDNS13.Text = "65";
                IpDNS14.Text = "6";
            }
            else if (DnsSelector.SelectedIndex == 8)
            {
                IpDNS1.Text = "185";
                IpDNS2.Text = "228";
                IpDNS3.Text = "168";
                IpDNS4.Text = "9";
                IpDNS11.Text = "185";
                IpDNS12.Text = "228";
                IpDNS13.Text = "168";
                IpDNS14.Text = "9";
            }
            else if (DnsSelector.SelectedIndex == 9)
            {
                IpDNS1.Text = "176";
                IpDNS2.Text = "103";
                IpDNS3.Text = "130";
                IpDNS4.Text = "130";
                IpDNS11.Text = "176";
                IpDNS12.Text = "103";
                IpDNS13.Text = "130";
                IpDNS14.Text = "130";
            }
            else if (DnsSelector.SelectedIndex == 10)
            {
                IpDNS1.Text = "10";
                IpDNS2.Text = "202";
                IpDNS3.Text = "10";
                IpDNS4.Text = "202";
                IpDNS11.Text = "10";
                IpDNS12.Text = "202";
                IpDNS13.Text = "10";
                IpDNS14.Text = "102";
            }
        }

        public static string[] GetNetworkAdapterNames()
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            List<string> adapterNames = new List<string>();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    adapterNames.Add(objMO["Caption"].ToString());
                }
            }

            return adapterNames.ToArray();
        }

        private void SetDNS_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "DnsJumper.exe",
                UseShellExecute = true,
                CreateNoWindow = true,
                Arguments = $" /F {IpDNS1.Text}.{IpDNS2.Text}.{IpDNS3.Text}.{IpDNS4.Text},{IpDNS11.Text}.{IpDNS12.Text}.{IpDNS13.Text}.{IpDNS14.Text}"
            };
            process = Process.Start(startInfo);
            process.WaitForExit();
            MessageBox.Show("Seted DNS | دی ان اس تنظیم شد");
        }


        private void CustomSet(object sender, EventArgs e)
        {
            DnsSelector.SelectedIndex = 2;
        }

        private void Freedom_Guard_Dns_Load(object sender, EventArgs e)
        {

        }
    }
}

