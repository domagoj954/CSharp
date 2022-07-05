namespace TCPServer
{
    partial class FormServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServer = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.boxClientIP = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(12, 25);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(68, 25);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(86, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(484, 27);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(86, 403);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(376, 403);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(86, 67);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(484, 284);
            this.txtInfo.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(5, 373);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(75, 25);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message: ";
            // 
            // boxClientIP
            // 
            this.boxClientIP.FormattingEnabled = true;
            this.boxClientIP.ItemHeight = 20;
            this.boxClientIP.Location = new System.Drawing.Point(586, 67);
            this.boxClientIP.Name = "boxClientIP";
            this.boxClientIP.Size = new System.Drawing.Size(210, 284);
            this.boxClientIP.TabIndex = 6;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(86, 370);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(484, 27);
            this.txtMessage.TabIndex = 8;
            // 
            // lblIP
            // 
            this.lblIP.Location = new System.Drawing.Point(586, 22);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(68, 25);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "Client IP:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(476, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(12, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 28);
            this.lblStatus.TabIndex = 11;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 454);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.boxClientIP);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblServer);
            this.Name = "FormServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblServer;
        private TextBox txtIP;
        private Button btnSend;
        private Button btnStart;
        private TextBox txtInfo;
        private Label lblMessage;
        private ListBox boxClientIP;
        private TextBox txtMessage;
        private Label lblIP;
        private Button btnClose;
        private Label lblStatus;
    }
}