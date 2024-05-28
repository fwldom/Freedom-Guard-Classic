namespace Freedom_Guard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreedomGuard));
            start_Guard = new System.Windows.Forms.Button();
            Status = new System.Windows.Forms.StatusStrip();
            ProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            LogApp = new System.Windows.Forms.TextBox();
            LabelLogApp = new System.Windows.Forms.Label();
            Gool_services = new System.Windows.Forms.CheckBox();
            MenuPanel = new System.Windows.Forms.Panel();
            clearCache = new System.Windows.Forms.Button();
            SettingShow = new System.Windows.Forms.Button();
            showAbout = new System.Windows.Forms.Button();
            ExitApp = new System.Windows.Forms.Button();
            Restart = new System.Windows.Forms.Button();
            SelectLanguage = new System.Windows.Forms.MenuStrip();
            languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            EnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            PersianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            topPanel = new System.Windows.Forms.Panel();
            minimizeBtn = new System.Windows.Forms.Button();
            ShowDns = new System.Windows.Forms.Button();
            CloseApp = new System.Windows.Forms.Button();
            TextLabelTopPanel = new System.Windows.Forms.Label();
            MenuShowHide = new System.Windows.Forms.Button();
            StatusText = new System.Windows.Forms.Label();
            scan_Warp = new System.Windows.Forms.CheckBox();
            PsCountry = new System.Windows.Forms.ComboBox();
            TextShowps = new System.Windows.Forms.Label();
            timeText = new System.Windows.Forms.Label();
            ConnectTimer = new System.Windows.Forms.Timer(components);
            Guard_Mode = new System.Windows.Forms.CheckBox();
            TextTimeConnected = new System.Windows.Forms.Label();
            guardModeTimer = new System.Windows.Forms.Timer(components);
            Status.SuspendLayout();
            MenuPanel.SuspendLayout();
            SelectLanguage.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // start_Guard
            // 
            start_Guard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            start_Guard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            start_Guard.Location = new System.Drawing.Point(266, 96);
            start_Guard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            start_Guard.Name = "start_Guard";
            start_Guard.Size = new System.Drawing.Size(138, 44);
            start_Guard.TabIndex = 0;
            start_Guard.Text = "Connect";
            start_Guard.UseVisualStyleBackColor = true;
            start_Guard.Click += start_Guard_Click;
            // 
            // Status
            // 
            Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ProgressBarStatus, StatusLabel });
            Status.Location = new System.Drawing.Point(0, 443);
            Status.Name = "Status";
            Status.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            Status.Size = new System.Drawing.Size(506, 24);
            Status.TabIndex = 3;
            Status.Text = "StatusBar";
            // 
            // ProgressBarStatus
            // 
            ProgressBarStatus.Name = "ProgressBarStatus";
            ProgressBarStatus.Size = new System.Drawing.Size(117, 18);
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = false;
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            StatusLabel.Size = new System.Drawing.Size(280, 19);
            StatusLabel.Text = "Not Running ...";
            StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogApp
            // 
            LogApp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            LogApp.Location = new System.Drawing.Point(194, 298);
            LogApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LogApp.Multiline = true;
            LogApp.Name = "LogApp";
            LogApp.Size = new System.Drawing.Size(304, 136);
            LogApp.TabIndex = 4;
            LogApp.Text = " ";
            // 
            // LabelLogApp
            // 
            LabelLogApp.AutoSize = true;
            LabelLogApp.Location = new System.Drawing.Point(304, 276);
            LabelLogApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelLogApp.Name = "LabelLogApp";
            LabelLogApp.Size = new System.Drawing.Size(91, 15);
            LabelLogApp.TabIndex = 5;
            LabelLogApp.Text = "Log Application";
            // 
            // Gool_services
            // 
            Gool_services.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Gool_services.AutoSize = true;
            Gool_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            Gool_services.Location = new System.Drawing.Point(194, 147);
            Gool_services.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Gool_services.Name = "Gool_services";
            Gool_services.Size = new System.Drawing.Size(124, 24);
            Gool_services.TabIndex = 7;
            Gool_services.Text = "Gool Service";
            Gool_services.UseVisualStyleBackColor = true;
            Gool_services.CheckedChanged += Gool_services_CheckedChanged;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = System.Drawing.Color.DarkGray;
            MenuPanel.Controls.Add(clearCache);
            MenuPanel.Controls.Add(SettingShow);
            MenuPanel.Controls.Add(showAbout);
            MenuPanel.Controls.Add(ExitApp);
            MenuPanel.Controls.Add(Restart);
            MenuPanel.Controls.Add(SelectLanguage);
            MenuPanel.Location = new System.Drawing.Point(14, 44);
            MenuPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new System.Drawing.Size(173, 395);
            MenuPanel.TabIndex = 8;
            MenuPanel.Visible = false;
            // 
            // clearCache
            // 
            clearCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            clearCache.Location = new System.Drawing.Point(3, 227);
            clearCache.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            clearCache.Name = "clearCache";
            clearCache.Size = new System.Drawing.Size(166, 35);
            clearCache.TabIndex = 19;
            clearCache.Text = "Clear Cache";
            clearCache.UseVisualStyleBackColor = true;
            clearCache.Visible = false;
            clearCache.Click += clearCache_Click;
            // 
            // SettingShow
            // 
            SettingShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            SettingShow.Location = new System.Drawing.Point(3, 186);
            SettingShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SettingShow.Name = "SettingShow";
            SettingShow.Size = new System.Drawing.Size(166, 35);
            SettingShow.TabIndex = 18;
            SettingShow.Text = "Settings";
            SettingShow.UseVisualStyleBackColor = true;
            SettingShow.Click += SettingShow_Click;
            // 
            // showAbout
            // 
            showAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            showAbout.Location = new System.Drawing.Point(4, 268);
            showAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            showAbout.Name = "showAbout";
            showAbout.Size = new System.Drawing.Size(166, 35);
            showAbout.TabIndex = 17;
            showAbout.Text = "About";
            showAbout.UseVisualStyleBackColor = true;
            showAbout.Click += showAbout_Click;
            // 
            // ExitApp
            // 
            ExitApp.BackColor = System.Drawing.Color.Gray;
            ExitApp.FlatAppearance.BorderSize = 0;
            ExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ExitApp.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18.25F, System.Drawing.FontStyle.Bold);
            ExitApp.ForeColor = System.Drawing.Color.Red;
            ExitApp.Location = new System.Drawing.Point(5, 350);
            ExitApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ExitApp.Name = "ExitApp";
            ExitApp.Size = new System.Drawing.Size(162, 39);
            ExitApp.TabIndex = 16;
            ExitApp.Text = "Exit";
            ExitApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            ExitApp.UseVisualStyleBackColor = false;
            ExitApp.Click += ExitApp_Click;
            // 
            // Restart
            // 
            Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            Restart.Location = new System.Drawing.Point(5, 309);
            Restart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Restart.Name = "Restart";
            Restart.Size = new System.Drawing.Size(166, 35);
            Restart.TabIndex = 1;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // SelectLanguage
            // 
            SelectLanguage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { languageToolStripMenuItem });
            SelectLanguage.Location = new System.Drawing.Point(0, 0);
            SelectLanguage.Name = "SelectLanguage";
            SelectLanguage.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            SelectLanguage.Size = new System.Drawing.Size(173, 24);
            SelectLanguage.TabIndex = 0;
            SelectLanguage.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { EnglishToolStripMenuItem, PersianToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            languageToolStripMenuItem.Text = "Language";
            // 
            // EnglishToolStripMenuItem
            // 
            EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem";
            EnglishToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            EnglishToolStripMenuItem.Text = "English";
            EnglishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // PersianToolStripMenuItem
            // 
            PersianToolStripMenuItem.Name = "PersianToolStripMenuItem";
            PersianToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            PersianToolStripMenuItem.Text = "Persian (فارسی)";
            PersianToolStripMenuItem.Click += persianToolStripMenuItem_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.White;
            topPanel.Controls.Add(minimizeBtn);
            topPanel.Controls.Add(ShowDns);
            topPanel.Controls.Add(CloseApp);
            topPanel.Controls.Add(TextLabelTopPanel);
            topPanel.Controls.Add(MenuShowHide);
            topPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            topPanel.Location = new System.Drawing.Point(0, -1);
            topPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(506, 38);
            topPanel.TabIndex = 9;
            topPanel.MouseDown += topPanel_MouseDown;
            topPanel.MouseMove += topPanel_MouseMove;
            topPanel.MouseUp += topPanel_MouseUp;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackColor = System.Drawing.Color.White;
            minimizeBtn.BackgroundImage = (System.Drawing.Image)resources.GetObject("minimizeBtn.BackgroundImage");
            minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            minimizeBtn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18.25F, System.Drawing.FontStyle.Bold);
            minimizeBtn.ForeColor = System.Drawing.Color.Red;
            minimizeBtn.Location = new System.Drawing.Point(430, -1);
            minimizeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new System.Drawing.Size(38, 38);
            minimizeBtn.TabIndex = 16;
            minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            minimizeBtn.UseVisualStyleBackColor = false;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // ShowDns
            // 
            ShowDns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            ShowDns.Location = new System.Drawing.Point(54, 3);
            ShowDns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ShowDns.Name = "ShowDns";
            ShowDns.Size = new System.Drawing.Size(88, 31);
            ShowDns.TabIndex = 15;
            ShowDns.Text = "DNS";
            ShowDns.UseVisualStyleBackColor = true;
            ShowDns.Click += ShowDns_Click;
            // 
            // CloseApp
            // 
            CloseApp.BackColor = System.Drawing.Color.Gray;
            CloseApp.FlatAppearance.BorderSize = 0;
            CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CloseApp.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18.25F, System.Drawing.FontStyle.Bold);
            CloseApp.ForeColor = System.Drawing.Color.Red;
            CloseApp.Location = new System.Drawing.Point(469, -2);
            CloseApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CloseApp.Name = "CloseApp";
            CloseApp.Size = new System.Drawing.Size(38, 39);
            CloseApp.TabIndex = 2;
            CloseApp.Text = "X";
            CloseApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            CloseApp.UseVisualStyleBackColor = false;
            CloseApp.Click += CloseApp_Click;
            // 
            // TextLabelTopPanel
            // 
            TextLabelTopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            TextLabelTopPanel.Location = new System.Drawing.Point(150, 8);
            TextLabelTopPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TextLabelTopPanel.Name = "TextLabelTopPanel";
            TextLabelTopPanel.Size = new System.Drawing.Size(152, 23);
            TextLabelTopPanel.TabIndex = 1;
            TextLabelTopPanel.Text = "Freedom Guard";
            TextLabelTopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuShowHide
            // 
            MenuShowHide.BackgroundImage = (System.Drawing.Image)resources.GetObject("MenuShowHide.BackgroundImage");
            MenuShowHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            MenuShowHide.FlatAppearance.BorderSize = 0;
            MenuShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MenuShowHide.Location = new System.Drawing.Point(9, 3);
            MenuShowHide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MenuShowHide.Name = "MenuShowHide";
            MenuShowHide.Size = new System.Drawing.Size(37, 30);
            MenuShowHide.TabIndex = 0;
            MenuShowHide.UseVisualStyleBackColor = true;
            MenuShowHide.Click += MenuShowHide_Click;
            // 
            // StatusText
            // 
            StatusText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            StatusText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            StatusText.Location = new System.Drawing.Point(223, 69);
            StatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StatusText.Name = "StatusText";
            StatusText.Size = new System.Drawing.Size(226, 23);
            StatusText.TabIndex = 10;
            StatusText.Text = "Disconnected";
            StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scan_Warp
            // 
            scan_Warp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            scan_Warp.AutoSize = true;
            scan_Warp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            scan_Warp.Location = new System.Drawing.Point(194, 173);
            scan_Warp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            scan_Warp.Name = "scan_Warp";
            scan_Warp.Size = new System.Drawing.Size(111, 24);
            scan_Warp.TabIndex = 11;
            scan_Warp.Text = "Scan Warp";
            scan_Warp.UseVisualStyleBackColor = true;
            scan_Warp.CheckedChanged += scan_Warp_CheckedChanged;
            // 
            // PsCountry
            // 
            PsCountry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PsCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            PsCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            PsCountry.FormattingEnabled = true;
            PsCountry.Items.AddRange(new object[] { "disable", "Austria (AT)", "Belgium (BE)", "Bulgaria (BG)", "Brazil (BR)", "Canada (CA)", "Switzerland (CH)", "Czech Republic (CZ)", "Germany (DE)", "Denmark (DK)", "Estonia (EE)", "Spain (ES)", "Finland (FI)", "France (FR)", "United Kingdom (GB)", "Hungary (HU)", "Ireland (IE)", "India (IN)", "Italy (IT)", "Japan (JP)", "Latvia (LV)", "Netherlands (NL)", "Norway (NO)", "Poland (PL)", "Romania (RO)", "Serbia (RS)", "Sweden (SE)", "Singapore (SG)", "Slovakia (SK)", "Ukraine (UA)", "United States (US)" });
            PsCountry.Location = new System.Drawing.Point(349, 177);
            PsCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PsCountry.Name = "PsCountry";
            PsCountry.Size = new System.Drawing.Size(143, 28);
            PsCountry.TabIndex = 12;
            PsCountry.SelectedIndexChanged += PsCountry_SelectedIndexChanged;
            // 
            // TextShowps
            // 
            TextShowps.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TextShowps.AutoSize = true;
            TextShowps.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            TextShowps.Location = new System.Drawing.Point(345, 147);
            TextShowps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TextShowps.Name = "TextShowps";
            TextShowps.Size = new System.Drawing.Size(118, 18);
            TextShowps.TabIndex = 13;
            TextShowps.Text = "Psiphon Country";
            // 
            // timeText
            // 
            timeText.AutoSize = true;
            timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            timeText.Location = new System.Drawing.Point(345, 237);
            timeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            timeText.Name = "timeText";
            timeText.Size = new System.Drawing.Size(28, 18);
            timeText.TabIndex = 14;
            timeText.Text = "0 s";
            // 
            // ConnectTimer
            // 
            ConnectTimer.Interval = 1000;
            ConnectTimer.Tick += ConnectTimer_Tick;
            // 
            // Guard_Mode
            // 
            Guard_Mode.AutoSize = true;
            Guard_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            Guard_Mode.Location = new System.Drawing.Point(194, 201);
            Guard_Mode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Guard_Mode.Name = "Guard_Mode";
            Guard_Mode.Size = new System.Drawing.Size(120, 24);
            Guard_Mode.TabIndex = 15;
            Guard_Mode.Text = "Guard Mode";
            Guard_Mode.UseVisualStyleBackColor = true;
            Guard_Mode.CheckedChanged += Guard_Mode_CheckedChanged;
            // 
            // TextTimeConnected
            // 
            TextTimeConnected.AutoSize = true;
            TextTimeConnected.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TextTimeConnected.Location = new System.Drawing.Point(194, 235);
            TextTimeConnected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TextTimeConnected.Name = "TextTimeConnected";
            TextTimeConnected.Size = new System.Drawing.Size(131, 20);
            TextTimeConnected.TabIndex = 16;
            TextTimeConnected.Text = "Time Connected =";
            // 
            // guardModeTimer
            // 
            guardModeTimer.Interval = 5000;
            guardModeTimer.Tick += guardModeTimer_Tick;
            // 
            // FreedomGuard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(506, 467);
            Controls.Add(TextTimeConnected);
            Controls.Add(Guard_Mode);
            Controls.Add(timeText);
            Controls.Add(TextShowps);
            Controls.Add(PsCountry);
            Controls.Add(scan_Warp);
            Controls.Add(StatusText);
            Controls.Add(topPanel);
            Controls.Add(MenuPanel);
            Controls.Add(Gool_services);
            Controls.Add(LabelLogApp);
            Controls.Add(LogApp);
            Controls.Add(Status);
            Controls.Add(start_Guard);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = SelectLanguage;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FreedomGuard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormClosed += FreedomGuard_FormClosed;
            Load += FreedomGuard_Load;
            Status.ResumeLayout(false);
            Status.PerformLayout();
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            SelectLanguage.ResumeLayout(false);
            SelectLanguage.PerformLayout();
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem EnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersianToolStripMenuItem;
        private System.Windows.Forms.MenuStrip SelectLanguage;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.CheckBox scan_Warp;
        private System.Windows.Forms.ComboBox PsCountry;
        private System.Windows.Forms.Label TextShowps;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button ShowDns;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Button showAbout;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Timer ConnectTimer;
        private System.Windows.Forms.CheckBox Guard_Mode;
        private System.Windows.Forms.Label TextTimeConnected;
        private System.Windows.Forms.Button clearCache;
        private System.Windows.Forms.Button SettingShow;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Timer guardModeTimer;
    }
}

