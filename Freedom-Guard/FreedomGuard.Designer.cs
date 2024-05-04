﻿namespace Freedom_Guard
{
    partial class FreedomGuard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreedomGuard));
            this.start_Guard = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.ProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LogApp = new System.Windows.Forms.TextBox();
            this.LabelLogApp = new System.Windows.Forms.Label();
            this.Gool_services = new System.Windows.Forms.CheckBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SelectLanguage = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanel = new System.Windows.Forms.Panel();
            this.CloseApp = new System.Windows.Forms.Button();
            this.TextLabelTopPanel = new System.Windows.Forms.Label();
            this.MenuShowHide = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.Label();
            this.scan_Warp = new System.Windows.Forms.CheckBox();
            this.PsCountry = new System.Windows.Forms.ComboBox();
            this.TextShowps = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Status.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SelectLanguage.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_Guard
            // 
            this.start_Guard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.start_Guard.Location = new System.Drawing.Point(228, 83);
            this.start_Guard.Name = "start_Guard";
            this.start_Guard.Size = new System.Drawing.Size(124, 38);
            this.start_Guard.TabIndex = 0;
            this.start_Guard.Text = "Connect";
            this.start_Guard.UseVisualStyleBackColor = true;
            this.start_Guard.Click += new System.EventHandler(this.start_Guard_Click);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBarStatus,
            this.StatusLabel});
            this.Status.Location = new System.Drawing.Point(0, 383);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(434, 22);
            this.Status.TabIndex = 3;
            this.Status.Text = "statusStrip1";
            // 
            // ProgressBarStatus
            // 
            this.ProgressBarStatus.Name = "ProgressBarStatus";
            this.ProgressBarStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = false;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.StatusLabel.Size = new System.Drawing.Size(280, 17);
            this.StatusLabel.Text = "Not Running ...";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogApp
            // 
            this.LogApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogApp.Location = new System.Drawing.Point(166, 205);
            this.LogApp.Multiline = true;
            this.LogApp.Name = "LogApp";
            this.LogApp.Size = new System.Drawing.Size(256, 172);
            this.LogApp.TabIndex = 4;
            this.LogApp.TextChanged += new System.EventHandler(this.LogApp_TextChanged);
            // 
            // LabelLogApp
            // 
            this.LabelLogApp.AutoSize = true;
            this.LabelLogApp.Location = new System.Drawing.Point(249, 189);
            this.LabelLogApp.Name = "LabelLogApp";
            this.LabelLogApp.Size = new System.Drawing.Size(80, 13);
            this.LabelLogApp.TabIndex = 5;
            this.LabelLogApp.Text = "Log Application";
            this.LabelLogApp.Click += new System.EventHandler(this.LabelLogApp_Click);
            // 
            // Gool_services
            // 
            this.Gool_services.AutoSize = true;
            this.Gool_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Gool_services.Location = new System.Drawing.Point(166, 127);
            this.Gool_services.Name = "Gool_services";
            this.Gool_services.Size = new System.Drawing.Size(124, 24);
            this.Gool_services.TabIndex = 7;
            this.Gool_services.Text = "Gool Service";
            this.Gool_services.UseVisualStyleBackColor = true;
            this.Gool_services.CheckedChanged += new System.EventHandler(this.Gool_services_CheckedChanged);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MenuPanel.Controls.Add(this.Restart);
            this.MenuPanel.Controls.Add(this.SelectLanguage);
            this.MenuPanel.Location = new System.Drawing.Point(12, 38);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(148, 342);
            this.MenuPanel.TabIndex = 8;
            this.MenuPanel.Visible = false;
            // 
            // SelectLanguage
            // 
            this.SelectLanguage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.SelectLanguage.Location = new System.Drawing.Point(0, 0);
            this.SelectLanguage.Name = "SelectLanguage";
            this.SelectLanguage.Size = new System.Drawing.Size(148, 24);
            this.SelectLanguage.TabIndex = 0;
            this.SelectLanguage.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.persianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // persianToolStripMenuItem
            // 
            this.persianToolStripMenuItem.Name = "persianToolStripMenuItem";
            this.persianToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.persianToolStripMenuItem.Text = "Persian (فارسی)";
            this.persianToolStripMenuItem.Click += new System.EventHandler(this.persianToolStripMenuItem_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.CloseApp);
            this.topPanel.Controls.Add(this.TextLabelTopPanel);
            this.topPanel.Controls.Add(this.MenuShowHide);
            this.topPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.topPanel.Location = new System.Drawing.Point(0, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(434, 33);
            this.topPanel.TabIndex = 9;
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.Gray;
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18.25F, System.Drawing.FontStyle.Bold);
            this.CloseApp.ForeColor = System.Drawing.Color.Red;
            this.CloseApp.Location = new System.Drawing.Point(401, -2);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(33, 34);
            this.CloseApp.TabIndex = 2;
            this.CloseApp.Text = "X";
            this.CloseApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // TextLabelTopPanel
            // 
            this.TextLabelTopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TextLabelTopPanel.Location = new System.Drawing.Point(152, 5);
            this.TextLabelTopPanel.Name = "TextLabelTopPanel";
            this.TextLabelTopPanel.Size = new System.Drawing.Size(126, 20);
            this.TextLabelTopPanel.TabIndex = 1;
            this.TextLabelTopPanel.Text = "Freedom Guard";
            this.TextLabelTopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuShowHide
            // 
            this.MenuShowHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuShowHide.BackgroundImage")));
            this.MenuShowHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuShowHide.FlatAppearance.BorderSize = 0;
            this.MenuShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuShowHide.Location = new System.Drawing.Point(8, 3);
            this.MenuShowHide.Name = "MenuShowHide";
            this.MenuShowHide.Size = new System.Drawing.Size(32, 26);
            this.MenuShowHide.TabIndex = 0;
            this.MenuShowHide.UseVisualStyleBackColor = true;
            this.MenuShowHide.Click += new System.EventHandler(this.MenuShowHide_Click);
            // 
            // StatusText
            // 
            this.StatusText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.StatusText.Location = new System.Drawing.Point(191, 60);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(200, 20);
            this.StatusText.TabIndex = 10;
            this.StatusText.Text = "Disconnected";
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusText.Click += new System.EventHandler(this.StatusText_Click);
            // 
            // scan_Warp
            // 
            this.scan_Warp.AutoSize = true;
            this.scan_Warp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.scan_Warp.Location = new System.Drawing.Point(167, 157);
            this.scan_Warp.Name = "scan_Warp";
            this.scan_Warp.Size = new System.Drawing.Size(111, 24);
            this.scan_Warp.TabIndex = 11;
            this.scan_Warp.Text = "Scan Warp";
            this.scan_Warp.UseVisualStyleBackColor = true;
            this.scan_Warp.CheckedChanged += new System.EventHandler(this.scan_Warp_CheckedChanged);
            // 
            // PsCountry
            // 
            this.PsCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PsCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PsCountry.FormattingEnabled = true;
            this.PsCountry.Items.AddRange(new object[] {
            "disable",
            "Austria (AT)",
            "Belgium (BE)",
            "Bulgaria (BG)",
            "Brazil (BR)",
            "Canada (CA)",
            "Switzerland (CH)",
            "Czech Republic (CZ)",
            "Germany (DE)",
            "Denmark (DK)",
            "Estonia (EE)",
            "Spain (ES)",
            "Finland (FI)",
            "France (FR)",
            "United Kingdom (GB)",
            "Hungary (HU)",
            "Ireland (IE)",
            "India (IN)",
            "Italy (IT)",
            "Japan (JP)",
            "Latvia (LV)",
            "Netherlands (NL)",
            "Norway (NO)",
            "Poland (PL)",
            "Romania (RO)",
            "Serbia (RS)",
            "Sweden (SE)",
            "Singapore (SG)",
            "Slovakia (SK)",
            "Ukraine (UA)",
            "United States (US)"});
            this.PsCountry.Location = new System.Drawing.Point(303, 157);
            this.PsCountry.Name = "PsCountry";
            this.PsCountry.Size = new System.Drawing.Size(119, 28);
            this.PsCountry.TabIndex = 12;
            this.PsCountry.SelectedIndexChanged += new System.EventHandler(this.PsCountry_SelectedIndexChanged);
            // 
            // TextShowps
            // 
            this.TextShowps.AutoSize = true;
            this.TextShowps.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TextShowps.Location = new System.Drawing.Point(304, 130);
            this.TextShowps.Name = "TextShowps";
            this.TextShowps.Size = new System.Drawing.Size(118, 18);
            this.TextShowps.TabIndex = 13;
            this.TextShowps.Text = "Psiphon Country";
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Restart.Location = new System.Drawing.Point(3, 309);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(142, 30);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // FreedomGuard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 405);
            this.Controls.Add(this.TextShowps);
            this.Controls.Add(this.PsCountry);
            this.Controls.Add(this.scan_Warp);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.Gool_services);
            this.Controls.Add(this.LabelLogApp);
            this.Controls.Add(this.LogApp);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.start_Guard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SelectLanguage;
            this.Name = "FreedomGuard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freedom Guard";
            this.Load += new System.EventHandler(this.FreedomGuard_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.SelectLanguage.ResumeLayout(false);
            this.SelectLanguage.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_Guard;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripProgressBar ProgressBarStatus;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TextBox LogApp;
        private System.Windows.Forms.Label LabelLogApp;
        private System.Windows.Forms.CheckBox Gool_services;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button MenuShowHide;
        private System.Windows.Forms.Label TextLabelTopPanel;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persianToolStripMenuItem;
        private System.Windows.Forms.MenuStrip SelectLanguage;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.CheckBox scan_Warp;
        private System.Windows.Forms.ComboBox PsCountry;
        private System.Windows.Forms.Label TextShowps;
        private System.Windows.Forms.Button Restart;
    }
}

