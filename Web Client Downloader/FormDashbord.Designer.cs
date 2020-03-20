namespace Web_Client_Downloader
{
    partial class FormDashbord
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
            this.RTXT_Content = new System.Windows.Forms.RichTextBox();
            this.GB_WebClientMethods = new System.Windows.Forms.GroupBox();
            this.RB_OpenRead = new System.Windows.Forms.RadioButton();
            this.RB_DownloadData = new System.Windows.Forms.RadioButton();
            this.RB_DownloadFile = new System.Windows.Forms.RadioButton();
            this.RB_DownloadString = new System.Windows.Forms.RadioButton();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.GB_Setting = new System.Windows.Forms.GroupBox();
            this.CB_Synchronization = new System.Windows.Forms.ComboBox();
            this.LBL_Synchronization = new System.Windows.Forms.Label();
            this.LBL_URL = new System.Windows.Forms.Label();
            this.TXT_Url = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_WebClientMethods.SuspendLayout();
            this.GB_Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTXT_Content
            // 
            this.RTXT_Content.Location = new System.Drawing.Point(272, 39);
            this.RTXT_Content.Name = "RTXT_Content";
            this.RTXT_Content.Size = new System.Drawing.Size(484, 378);
            this.RTXT_Content.TabIndex = 0;
            this.RTXT_Content.Text = "";
            // 
            // GB_WebClientMethods
            // 
            this.GB_WebClientMethods.Controls.Add(this.RB_OpenRead);
            this.GB_WebClientMethods.Controls.Add(this.RB_DownloadData);
            this.GB_WebClientMethods.Controls.Add(this.RB_DownloadFile);
            this.GB_WebClientMethods.Controls.Add(this.RB_DownloadString);
            this.GB_WebClientMethods.Location = new System.Drawing.Point(15, 39);
            this.GB_WebClientMethods.Name = "GB_WebClientMethods";
            this.GB_WebClientMethods.Size = new System.Drawing.Size(254, 72);
            this.GB_WebClientMethods.TabIndex = 1;
            this.GB_WebClientMethods.TabStop = false;
            this.GB_WebClientMethods.Text = "Web Client Methods";
            // 
            // RB_OpenRead
            // 
            this.RB_OpenRead.AutoSize = true;
            this.RB_OpenRead.Location = new System.Drawing.Point(6, 42);
            this.RB_OpenRead.Name = "RB_OpenRead";
            this.RB_OpenRead.Size = new System.Drawing.Size(77, 17);
            this.RB_OpenRead.TabIndex = 3;
            this.RB_OpenRead.Text = "OpenRead";
            this.RB_OpenRead.UseVisualStyleBackColor = true;
            // 
            // RB_DownloadData
            // 
            this.RB_DownloadData.AutoSize = true;
            this.RB_DownloadData.Location = new System.Drawing.Point(127, 42);
            this.RB_DownloadData.Name = "RB_DownloadData";
            this.RB_DownloadData.Size = new System.Drawing.Size(96, 17);
            this.RB_DownloadData.TabIndex = 2;
            this.RB_DownloadData.Text = "DownloadData";
            this.RB_DownloadData.UseVisualStyleBackColor = true;
            // 
            // RB_DownloadFile
            // 
            this.RB_DownloadFile.AutoSize = true;
            this.RB_DownloadFile.Location = new System.Drawing.Point(127, 19);
            this.RB_DownloadFile.Name = "RB_DownloadFile";
            this.RB_DownloadFile.Size = new System.Drawing.Size(89, 17);
            this.RB_DownloadFile.TabIndex = 1;
            this.RB_DownloadFile.Text = "DownloadFile";
            this.RB_DownloadFile.UseVisualStyleBackColor = true;
            // 
            // RB_DownloadString
            // 
            this.RB_DownloadString.AutoSize = true;
            this.RB_DownloadString.Checked = true;
            this.RB_DownloadString.Location = new System.Drawing.Point(6, 19);
            this.RB_DownloadString.Name = "RB_DownloadString";
            this.RB_DownloadString.Size = new System.Drawing.Size(100, 17);
            this.RB_DownloadString.TabIndex = 0;
            this.RB_DownloadString.TabStop = true;
            this.RB_DownloadString.Text = "DownloadString";
            this.RB_DownloadString.UseVisualStyleBackColor = true;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(15, 189);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(254, 23);
            this.Btn_Submit.TabIndex = 3;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // GB_Setting
            // 
            this.GB_Setting.Controls.Add(this.CB_Synchronization);
            this.GB_Setting.Controls.Add(this.LBL_Synchronization);
            this.GB_Setting.Location = new System.Drawing.Point(15, 117);
            this.GB_Setting.Name = "GB_Setting";
            this.GB_Setting.Size = new System.Drawing.Size(254, 66);
            this.GB_Setting.TabIndex = 4;
            this.GB_Setting.TabStop = false;
            this.GB_Setting.Text = "Setting";
            // 
            // CB_Synchronization
            // 
            this.CB_Synchronization.FormattingEnabled = true;
            this.CB_Synchronization.Items.AddRange(new object[] {
            "Sync",
            "Async"});
            this.CB_Synchronization.Location = new System.Drawing.Point(97, 23);
            this.CB_Synchronization.Name = "CB_Synchronization";
            this.CB_Synchronization.Size = new System.Drawing.Size(121, 21);
            this.CB_Synchronization.TabIndex = 6;
            // 
            // LBL_Synchronization
            // 
            this.LBL_Synchronization.AutoSize = true;
            this.LBL_Synchronization.Location = new System.Drawing.Point(6, 26);
            this.LBL_Synchronization.Name = "LBL_Synchronization";
            this.LBL_Synchronization.Size = new System.Drawing.Size(85, 13);
            this.LBL_Synchronization.TabIndex = 5;
            this.LBL_Synchronization.Text = "Synchronization:";
            // 
            // LBL_URL
            // 
            this.LBL_URL.AutoSize = true;
            this.LBL_URL.Location = new System.Drawing.Point(12, 16);
            this.LBL_URL.Name = "LBL_URL";
            this.LBL_URL.Size = new System.Drawing.Size(32, 13);
            this.LBL_URL.TabIndex = 5;
            this.LBL_URL.Text = "URL:";
            // 
            // TXT_Url
            // 
            this.TXT_Url.Location = new System.Drawing.Point(52, 13);
            this.TXT_Url.Name = "TXT_Url";
            this.TXT_Url.Size = new System.Drawing.Size(704, 20);
            this.TXT_Url.TabIndex = 6;
            // 
            // FormDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 429);
            this.Controls.Add(this.TXT_Url);
            this.Controls.Add(this.LBL_URL);
            this.Controls.Add(this.GB_Setting);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.GB_WebClientMethods);
            this.Controls.Add(this.RTXT_Content);
            this.Name = "FormDashbord";
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.FormDashbord_Load);
            this.GB_WebClientMethods.ResumeLayout(false);
            this.GB_WebClientMethods.PerformLayout();
            this.GB_Setting.ResumeLayout(false);
            this.GB_Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTXT_Content;
        private System.Windows.Forms.GroupBox GB_WebClientMethods;
        private System.Windows.Forms.RadioButton RB_OpenRead;
        private System.Windows.Forms.RadioButton RB_DownloadData;
        private System.Windows.Forms.RadioButton RB_DownloadFile;
        private System.Windows.Forms.RadioButton RB_DownloadString;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.GroupBox GB_Setting;
        private System.Windows.Forms.ComboBox CB_Synchronization;
        private System.Windows.Forms.Label LBL_Synchronization;
        private System.Windows.Forms.Label LBL_URL;
        private System.Windows.Forms.TextBox TXT_Url;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}