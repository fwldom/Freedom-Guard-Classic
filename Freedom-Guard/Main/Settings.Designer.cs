namespace Freedom_Guard.Main
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            IpaddressCustom = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // IpaddressCustom
            // 
            IpaddressCustom.Location = new System.Drawing.Point(12, 41);
            IpaddressCustom.Name = "IpaddressCustom";
            IpaddressCustom.Size = new System.Drawing.Size(44, 23);
            IpaddressCustom.TabIndex = 0;
            IpaddressCustom.Text = "8086";
            IpaddressCustom.TextChanged += IpaddressCustom_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "port default:8086";
            // 
            // Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(278, 417);
            Controls.Add(label1);
            Controls.Add(IpaddressCustom);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox IpaddressCustom;
        private System.Windows.Forms.Label label1;
    }
}