namespace Freedom_Guard
{
    partial class Freedom_Guard_V2ray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Freedom_Guard_V2ray));
            this.URLConfig = new System.Windows.Forms.TextBox();
            this.V2rayConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // URLConfig
            // 
            this.URLConfig.Location = new System.Drawing.Point(34, 39);
            this.URLConfig.Multiline = true;
            this.URLConfig.Name = "URLConfig";
            this.URLConfig.Size = new System.Drawing.Size(284, 73);
            this.URLConfig.TabIndex = 0;
            // 
            // V2rayConnect
            // 
            this.V2rayConnect.Location = new System.Drawing.Point(336, 132);
            this.V2rayConnect.Name = "V2rayConnect";
            this.V2rayConnect.Size = new System.Drawing.Size(75, 23);
            this.V2rayConnect.TabIndex = 1;
            this.V2rayConnect.Text = "Connect";
            this.V2rayConnect.UseVisualStyleBackColor = true;
            this.V2rayConnect.Click += new System.EventHandler(this.V2rayConnect_Click);
            // 
            // Freedom_Guard_V2ray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 380);
            this.Controls.Add(this.V2rayConnect);
            this.Controls.Add(this.URLConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Freedom_Guard_V2ray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freedom Guard V2ray";
            this.Load += new System.EventHandler(this.Freedom_Guard_V2ray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLConfig;
        private System.Windows.Forms.Button V2rayConnect;
    }
}