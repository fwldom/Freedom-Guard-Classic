namespace Freedom_Guard
{
    partial class Freedom_Guard_Dns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Freedom_Guard_Dns));
            this.DnsSelector = new System.Windows.Forms.ComboBox();
            this.IpDNS1 = new System.Windows.Forms.TextBox();
            this.IpDNS11 = new System.Windows.Forms.TextBox();
            this.IpDNS4 = new System.Windows.Forms.TextBox();
            this.IpDNS3 = new System.Windows.Forms.TextBox();
            this.IpDNS14 = new System.Windows.Forms.TextBox();
            this.IpDNS12 = new System.Windows.Forms.TextBox();
            this.IpDNS2 = new System.Windows.Forms.TextBox();
            this.IpDNS13 = new System.Windows.Forms.TextBox();
            this.SetDNS = new System.Windows.Forms.Button();
            this.TextDNSSecltor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DnsSelector
            // 
            this.DnsSelector.FormattingEnabled = true;
            this.DnsSelector.Items.AddRange(new object[] {
            "Google",
            "CloudFlare",
            "Custom",
            "OpenDNS",
            "Comodo Secure DNS",
            "Quad9 DNS",
            "Verisign",
            "CleanBrowsing",
            "AdGuard DNS",
            "Yandex DNS",
            "403 Online"});
            this.DnsSelector.Location = new System.Drawing.Point(62, 12);
            this.DnsSelector.Name = "DnsSelector";
            this.DnsSelector.Size = new System.Drawing.Size(121, 21);
            this.DnsSelector.TabIndex = 0;
            this.DnsSelector.SelectedIndexChanged += new System.EventHandler(this.DnsSelector_SelectedIndexChanged);
            // 
            // IpDNS1
            // 
            this.IpDNS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IpDNS1.Location = new System.Drawing.Point(18, 65);
            this.IpDNS1.Name = "IpDNS1";
            this.IpDNS1.Size = new System.Drawing.Size(31, 23);
            this.IpDNS1.TabIndex = 1;
            this.IpDNS1.Click += new System.EventHandler(this.CustomSet);
            // 
            // IpDNS11
            // 
            this.IpDNS11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IpDNS11.Location = new System.Drawing.Point(184, 65);
            this.IpDNS11.Name = "IpDNS11";
            this.IpDNS11.Size = new System.Drawing.Size(31, 23);
            this.IpDNS11.TabIndex = 2;
            this.IpDNS11.Click += new System.EventHandler(this.CustomSet);
            // 
            // IpDNS4
            // 
            this.IpDNS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IpDNS4.Location = new System.Drawing.Point(129, 65);
            this.IpDNS4.Name = "IpDNS4";
            this.IpDNS4.Size = new System.Drawing.Size(31, 23);
            this.IpDNS4.TabIndex = 3;
            this.IpDNS4.Click += new System.EventHandler(this.CustomSet);
            // 
            // IpDNS3
            // 
            this.IpDNS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IpDNS3.Location = new System.Drawing.Point(92, 65);
            this.IpDNS3.Name = "IpDNS3";
            this.IpDNS3.Size = new System.Drawing.Size(31, 23);
            this.IpDNS3.TabIndex = 4;
            this.IpDNS3.Click += new System.EventHandler(this.CustomSet);
            // 
            // IpDNS14
            // 
            this.IpDNS14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IpDNS14.Location = new System.Drawing.Point(295, 65);
            this.IpDNS14.Name = "IpDNS14";
            this.IpDNS14.Size = new System.Drawing.Size(31, 23);
            this.IpDNS14.TabIndex = 5;
            this.IpDNS14.Click += new System.EventHandler(this.CustomSet);
            // 
            // IpDNS12
            // 
            this.IpDNS12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IpDNS12.Location = new System.Drawing.Point(221, 65);
            this.IpDNS12.Name = "IpDNS12";
            this.IpDNS12.Size = new System.Drawing.Size(31, 23);
            this.IpDNS12.TabIndex = 6;
            this.IpDNS12.Click += new System.EventHandler(this.CustomSet);
            // 
            // IpDNS2
            // 
            this.IpDNS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IpDNS2.Location = new System.Drawing.Point(55, 65);
            this.IpDNS2.Name = "IpDNS2";
            this.IpDNS2.Size = new System.Drawing.Size(31, 23);
            this.IpDNS2.TabIndex = 7;
            this.IpDNS2.Click += new System.EventHandler(this.CustomSet);
            // 
            // IpDNS13
            // 
            this.IpDNS13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IpDNS13.Location = new System.Drawing.Point(258, 65);
            this.IpDNS13.Name = "IpDNS13";
            this.IpDNS13.Size = new System.Drawing.Size(31, 23);
            this.IpDNS13.TabIndex = 8;
            this.IpDNS13.Click += new System.EventHandler(this.CustomSet);
            // 
            // SetDNS
            // 
            this.SetDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SetDNS.Location = new System.Drawing.Point(262, 5);
            this.SetDNS.Name = "SetDNS";
            this.SetDNS.Size = new System.Drawing.Size(86, 30);
            this.SetDNS.TabIndex = 9;
            this.SetDNS.Text = "Set";
            this.SetDNS.UseVisualStyleBackColor = true;
            this.SetDNS.Click += new System.EventHandler(this.SetDNS_Click);
            // 
            // TextDNSSecltor
            // 
            this.TextDNSSecltor.AutoSize = true;
            this.TextDNSSecltor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TextDNSSecltor.Location = new System.Drawing.Point(13, 13);
            this.TextDNSSecltor.Name = "TextDNSSecltor";
            this.TextDNSSecltor.Size = new System.Drawing.Size(48, 18);
            this.TextDNSSecltor.TabIndex = 10;
            this.TextDNSSecltor.Text = "DNS :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(164, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(187, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "IP DNS Server 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(19, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "IP DNS Server 1";
            // 
            // Freedom_Guard_Dns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 101);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextDNSSecltor);
            this.Controls.Add(this.SetDNS);
            this.Controls.Add(this.IpDNS13);
            this.Controls.Add(this.IpDNS2);
            this.Controls.Add(this.IpDNS12);
            this.Controls.Add(this.IpDNS14);
            this.Controls.Add(this.IpDNS3);
            this.Controls.Add(this.IpDNS4);
            this.Controls.Add(this.IpDNS11);
            this.Controls.Add(this.IpDNS1);
            this.Controls.Add(this.DnsSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Freedom_Guard_Dns";
            this.Text = "Freedom Guard Dns";
            this.Load += new System.EventHandler(this.Freedom_Guard_Dns_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DnsSelector;
        private System.Windows.Forms.TextBox IpDNS1;
        private System.Windows.Forms.TextBox IpDNS11;
        private System.Windows.Forms.TextBox IpDNS4;
        private System.Windows.Forms.TextBox IpDNS3;
        private System.Windows.Forms.TextBox IpDNS14;
        private System.Windows.Forms.TextBox IpDNS12;
        private System.Windows.Forms.TextBox IpDNS2;
        private System.Windows.Forms.TextBox IpDNS13;
        private System.Windows.Forms.Button SetDNS;
        private System.Windows.Forms.Label TextDNSSecltor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}