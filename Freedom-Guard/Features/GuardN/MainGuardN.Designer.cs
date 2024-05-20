namespace Freedom_Guard.Features.GuardN
{
    partial class MainGuardN
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
            ConfigURL = new System.Windows.Forms.TextBox();
            Start = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ConfigURL
            // 
            ConfigURL.Location = new System.Drawing.Point(17, 85);
            ConfigURL.Multiline = true;
            ConfigURL.Name = "ConfigURL";
            ConfigURL.Size = new System.Drawing.Size(218, 53);
            ConfigURL.TabIndex = 0;
            // 
            // Start
            // 
            Start.Location = new System.Drawing.Point(241, 85);
            Start.Name = "Start";
            Start.Size = new System.Drawing.Size(75, 23);
            Start.TabIndex = 1;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // MainGuardN
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(340, 150);
            Controls.Add(Start);
            Controls.Add(ConfigURL);
            Name = "MainGuardN";
            Text = "MainGuardN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox ConfigURL;
        private System.Windows.Forms.Button Start;
    }
}