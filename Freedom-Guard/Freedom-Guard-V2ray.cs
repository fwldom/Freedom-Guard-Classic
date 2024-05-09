using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace Freedom_Guard
{
    public partial class Freedom_Guard_V2ray : Form
    {
        public Freedom_Guard_V2ray()
        {
            InitializeComponent();
        }
        Process process = new Process();
        private void V2rayConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //trojan://telegram-id-privatevpns@51.20.167.108:22222?security=tls&alpn=http/1.1&headerType=none&type=tcp&sni=trojan.burgerip.co.uk#(S102)🇸🇪t.me/PrivateVPNs
                string url = URLConfig.Text;

                Uri uri = new Uri(url);

                // Get scheme
                string scheme = uri.Scheme;
                MessageBox.Show("Scheme: " + scheme);

                // Get host
                string host = uri.Host;
                MessageBox.Show("Host: " + host);

                // Get port
                int port = uri.Port;
                MessageBox.Show("Port: " + port);

                // Get query parameters
                string query = uri.Query;
                MessageBox.Show("Query: " + query);
                string[] queryParts = query.TrimStart('?').Split('&');
                Dictionary<string, string> LinkPara = new Dictionary<string, string>();
                foreach (string part in queryParts)
                {
                    string[] keyValue = part.Split('=');
                    string key = keyValue[0];
                    string value = keyValue.Length > 1 ? keyValue[1] : "";
                    LinkPara.Add(key, value);
                }
                // Find the index of "://" and "@" in the input string
                int startIndex = url.IndexOf("://") + 3; // Add 3 to include "://"
                int endIndex = url.IndexOf("@");
                var passurl = "";
                if (startIndex != -1 && endIndex != -1)
                {
                    // Extract the substring between startIndex and endIndex
                    string extractedString = url.Substring(startIndex, endIndex - startIndex);
                    passurl = (extractedString);
                }
                var type = "";
                 endIndex = url.IndexOf("://");
                if (endIndex != -1)
                {
                    string extractedString = url.Substring(0, endIndex);
                    type = (extractedString);
                }
                var data = new
                {
                    bean = new
                    {
                        _v = 0,
                        addr = uri.Host,
                        name = uri.Fragment,
                        pass = passurl,
                        port = uri.Port,
                        stream = new
                        {
                            alpn = LinkPara["alpn"],
                            ed_len = 0,
                            insecure = false,
                            mux_s = 0,
                            net = LinkPara["type"],
                            sec = LinkPara["security"],
                            sni = LinkPara["sni"]
                        }
                    },
                    gid = 0,
                    id = 51,
                    report = "Latency: Error",
                    traffic = new
                    {
                        dl = 112543,
                        ul = 304795
                    },
                    type = type,
                    yc = 1
                };

                // Convert the data to JSON
                string jsonString = JsonConvert.SerializeObject(data);
                File.WriteAllText("config.json", jsonString);
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "xray.exe",
                    UseShellExecute = true,
                    CreateNoWindow = true,
                    Arguments = "-c config.json"
                };
                process = Process.Start(startInfo);
            }
            catch
            {
                MessageBox.Show("Invalid Link");
            }
        }

        private void Freedom_Guard_V2ray_Load(object sender, EventArgs e)
        {
            MessageBox.Show("this Section Not Ready");
            this.Close();
        }
    }
}
