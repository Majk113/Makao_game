namespace MakaoGameNetLayer
{
    partial class MakaoGameNetLayer
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
            this.serverIpBox = new System.Windows.Forms.TextBox();
            this.serverPortBox = new System.Windows.Forms.TextBox();
            this.startServerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.connectButton = new System.Windows.Forms.Button();
            this.clientPortBox = new System.Windows.Forms.TextBox();
            this.clientIpBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chatTextbox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.toSendBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverIpBox
            // 
            this.serverIpBox.Location = new System.Drawing.Point(6, 19);
            this.serverIpBox.Name = "serverIpBox";
            this.serverIpBox.Size = new System.Drawing.Size(234, 20);
            this.serverIpBox.TabIndex = 0;
            this.serverIpBox.Text = "192.168.1.6";
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(6, 58);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(234, 20);
            this.serverPortBox.TabIndex = 1;
            this.serverPortBox.Text = "11111";
            // 
            // startServerButton
            // 
            this.startServerButton.Location = new System.Drawing.Point(6, 84);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(234, 23);
            this.startServerButton.TabIndex = 2;
            this.startServerButton.Text = "Start Server!";
            this.startServerButton.UseVisualStyleBackColor = true;
            this.startServerButton.Click += new System.EventHandler(this.startServerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 151);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.startServerButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.serverPortBox);
            this.tabPage1.Controls.Add(this.serverIpBox);
            this.tabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 125);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.connectButton);
            this.tabPage2.Controls.Add(this.clientPortBox);
            this.tabPage2.Controls.Add(this.clientIpBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(246, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(10, 89);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(230, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect!";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // clientPortBox
            // 
            this.clientPortBox.Location = new System.Drawing.Point(10, 63);
            this.clientPortBox.Name = "clientPortBox";
            this.clientPortBox.Size = new System.Drawing.Size(230, 20);
            this.clientPortBox.TabIndex = 3;
            this.clientPortBox.Text = "11111";
            // 
            // clientIpBox
            // 
            this.clientIpBox.Location = new System.Drawing.Point(10, 24);
            this.clientIpBox.Name = "clientIpBox";
            this.clientIpBox.Size = new System.Drawing.Size(230, 20);
            this.clientIpBox.TabIndex = 2;
            this.clientIpBox.Text = "192.168.1.6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP:";
            // 
            // chatTextbox
            // 
            this.chatTextbox.Location = new System.Drawing.Point(12, 169);
            this.chatTextbox.Name = "chatTextbox";
            this.chatTextbox.Size = new System.Drawing.Size(623, 120);
            this.chatTextbox.TabIndex = 6;
            this.chatTextbox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(12, 322);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(94, 33);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // toSendBox
            // 
            this.toSendBox.Location = new System.Drawing.Point(12, 296);
            this.toSendBox.Name = "toSendBox";
            this.toSendBox.Size = new System.Drawing.Size(623, 20);
            this.toSendBox.TabIndex = 8;
            // 
            // MakaoGameNetLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 515);
            this.Controls.Add(this.toSendBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.chatTextbox);
            this.Controls.Add(this.tabControl1);
            this.Name = "MakaoGameNetLayer";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverIpBox;
        private System.Windows.Forms.TextBox serverPortBox;
        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox clientPortBox;
        private System.Windows.Forms.TextBox clientIpBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox chatTextbox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox toSendBox;
    }
}

