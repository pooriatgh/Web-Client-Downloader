namespace HTTP_WebRequest_Downloader
{
    partial class FormHttpWebRequest
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
            this.GB_TestTimeout = new System.Windows.Forms.GroupBox();
            this.Btn_Timeout = new System.Windows.Forms.Button();
            this.TXT_Timeout = new System.Windows.Forms.TextBox();
            this.LBL_Timeout = new System.Windows.Forms.Label();
            this.LBL_TimeoutScale = new System.Windows.Forms.Label();
            this.GB_TestTimeout.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_TestTimeout
            // 
            this.GB_TestTimeout.Controls.Add(this.LBL_TimeoutScale);
            this.GB_TestTimeout.Controls.Add(this.LBL_Timeout);
            this.GB_TestTimeout.Controls.Add(this.TXT_Timeout);
            this.GB_TestTimeout.Controls.Add(this.Btn_Timeout);
            this.GB_TestTimeout.Location = new System.Drawing.Point(12, 12);
            this.GB_TestTimeout.Name = "GB_TestTimeout";
            this.GB_TestTimeout.Size = new System.Drawing.Size(200, 100);
            this.GB_TestTimeout.TabIndex = 0;
            this.GB_TestTimeout.TabStop = false;
            this.GB_TestTimeout.Text = "Override TimeOut WebCient";
            // 
            // Btn_Timeout
            // 
            this.Btn_Timeout.Location = new System.Drawing.Point(6, 71);
            this.Btn_Timeout.Name = "Btn_Timeout";
            this.Btn_Timeout.Size = new System.Drawing.Size(178, 23);
            this.Btn_Timeout.TabIndex = 0;
            this.Btn_Timeout.Text = "Test Timeout";
            this.Btn_Timeout.UseVisualStyleBackColor = true;
            this.Btn_Timeout.Click += new System.EventHandler(this.Btn_Timeout_Click);
            // 
            // TXT_Timeout
            // 
            this.TXT_Timeout.Location = new System.Drawing.Point(48, 33);
            this.TXT_Timeout.Name = "TXT_Timeout";
            this.TXT_Timeout.Size = new System.Drawing.Size(100, 20);
            this.TXT_Timeout.TabIndex = 1;
            // 
            // LBL_Timeout
            // 
            this.LBL_Timeout.AutoSize = true;
            this.LBL_Timeout.Location = new System.Drawing.Point(6, 36);
            this.LBL_Timeout.Name = "LBL_Timeout";
            this.LBL_Timeout.Size = new System.Drawing.Size(42, 13);
            this.LBL_Timeout.TabIndex = 2;
            this.LBL_Timeout.Text = "Timout:";
            // 
            // LBL_TimeoutScale
            // 
            this.LBL_TimeoutScale.AutoSize = true;
            this.LBL_TimeoutScale.Location = new System.Drawing.Point(158, 36);
            this.LBL_TimeoutScale.Name = "LBL_TimeoutScale";
            this.LBL_TimeoutScale.Size = new System.Drawing.Size(26, 13);
            this.LBL_TimeoutScale.TabIndex = 3;
            this.LBL_TimeoutScale.Text = "(ms)";
            // 
            // FormHttpWebRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GB_TestTimeout);
            this.Name = "FormHttpWebRequest";
            this.Text = "Testing All methods";
            this.GB_TestTimeout.ResumeLayout(false);
            this.GB_TestTimeout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_TestTimeout;
        private System.Windows.Forms.Label LBL_TimeoutScale;
        private System.Windows.Forms.Label LBL_Timeout;
        private System.Windows.Forms.TextBox TXT_Timeout;
        private System.Windows.Forms.Button Btn_Timeout;
    }
}

