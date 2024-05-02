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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreedomGuard));
            this.start_Guard = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAndStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persianفارسیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop_Guard = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.ProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LogApp = new System.Windows.Forms.TextBox();
            this.LabelLogApp = new System.Windows.Forms.Label();
            this.Gool_services = new System.Windows.Forms.CheckBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runServicesWithStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_Guard
            // 
            this.start_Guard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.start_Guard.Location = new System.Drawing.Point(12, 35);
            this.start_Guard.Name = "start_Guard";
            this.start_Guard.Size = new System.Drawing.Size(85, 38);
            this.start_Guard.TabIndex = 0;
            this.start_Guard.Text = "Start";
            this.start_Guard.UseVisualStyleBackColor = true;
            this.start_Guard.Click += new System.EventHandler(this.start_Guard_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.languagesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(764, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.TabStop = true;
            this.MainMenu.Text = "MainMenu";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAndStopToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.runServicesWithStartToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitAndStopToolStripMenuItem
            // 
            this.exitAndStopToolStripMenuItem.Name = "exitAndStopToolStripMenuItem";
            this.exitAndStopToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exitAndStopToolStripMenuItem.Text = "Stop And Exit";
            this.exitAndStopToolStripMenuItem.Click += new System.EventHandler(this.exitAndStopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.persianفارسیToolStripMenuItem});
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.languagesToolStripMenuItem.Text = "Languages";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // persianفارسیToolStripMenuItem
            // 
            this.persianفارسیToolStripMenuItem.Name = "persianفارسیToolStripMenuItem";
            this.persianفارسیToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.persianفارسیToolStripMenuItem.Text = "Persian (فارسی)";
            this.persianفارسیToolStripMenuItem.Click += new System.EventHandler(this.persianفارسیToolStripMenuItem_Click);
            // 
            // Stop_Guard
            // 
            this.Stop_Guard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Stop_Guard.Location = new System.Drawing.Point(103, 35);
            this.Stop_Guard.Name = "Stop_Guard";
            this.Stop_Guard.Size = new System.Drawing.Size(85, 38);
            this.Stop_Guard.TabIndex = 2;
            this.Stop_Guard.Text = "Stop";
            this.Stop_Guard.UseVisualStyleBackColor = true;
            this.Stop_Guard.Click += new System.EventHandler(this.Stop_Guard_Click);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBarStatus,
            this.StatusLabel});
            this.Status.Location = new System.Drawing.Point(0, 383);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(764, 22);
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
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.StatusLabel.Size = new System.Drawing.Size(87, 17);
            this.StatusLabel.Text = "Not Running ...";
            // 
            // LogApp
            // 
            this.LogApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogApp.Location = new System.Drawing.Point(408, 208);
            this.LogApp.Multiline = true;
            this.LogApp.Name = "LogApp";
            this.LogApp.Size = new System.Drawing.Size(344, 172);
            this.LogApp.TabIndex = 4;
            // 
            // LabelLogApp
            // 
            this.LabelLogApp.AutoSize = true;
            this.LabelLogApp.Location = new System.Drawing.Point(408, 189);
            this.LabelLogApp.Name = "LabelLogApp";
            this.LabelLogApp.Size = new System.Drawing.Size(80, 13);
            this.LabelLogApp.TabIndex = 5;
            this.LabelLogApp.Text = "Log Application";
            // 
            // Gool_services
            // 
            this.Gool_services.AutoSize = true;
            this.Gool_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Gool_services.Location = new System.Drawing.Point(194, 35);
            this.Gool_services.Name = "Gool_services";
            this.Gool_services.Size = new System.Drawing.Size(124, 24);
            this.Gool_services.TabIndex = 7;
            this.Gool_services.Text = "Gool Service";
            this.Gool_services.UseVisualStyleBackColor = true;
            this.Gool_services.CheckedChanged += new System.EventHandler(this.Gool_services_CheckedChanged);
            this.Gool_services.Click += new System.EventHandler(this.Gool_services_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.settingsToolStripMenuItem.Text = "Help";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // runServicesWithStartToolStripMenuItem
            // 
            this.runServicesWithStartToolStripMenuItem.Name = "runServicesWithStartToolStripMenuItem";
            this.runServicesWithStartToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.runServicesWithStartToolStripMenuItem.Text = "Run Services With Start App";
            this.runServicesWithStartToolStripMenuItem.Click += new System.EventHandler(this.runServicesWithStartToolStripMenuItem_Click);
            // 
            // FreedomGuard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 405);
            this.Controls.Add(this.Gool_services);
            this.Controls.Add(this.LabelLogApp);
            this.Controls.Add(this.LogApp);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Stop_Guard);
            this.Controls.Add(this.start_Guard);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "FreedomGuard";
            this.Text = "Freedom Guard";
            this.Load += new System.EventHandler(this.FreedomGuard_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_Guard;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persianفارسیToolStripMenuItem;
        private System.Windows.Forms.Button Stop_Guard;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripProgressBar ProgressBarStatus;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem exitAndStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.TextBox LogApp;
        private System.Windows.Forms.Label LabelLogApp;
        private System.Windows.Forms.CheckBox Gool_services;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runServicesWithStartToolStripMenuItem;
    }
}

