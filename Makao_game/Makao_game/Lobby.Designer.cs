namespace Makao_game
{
    partial class Lobby
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
            this.amIServerCheckbox = new System.Windows.Forms.CheckBox();
            this.listOfPlayersTextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amIServerCheckbox
            // 
            this.amIServerCheckbox.AutoSize = true;
            this.amIServerCheckbox.Location = new System.Drawing.Point(12, 12);
            this.amIServerCheckbox.Name = "amIServerCheckbox";
            this.amIServerCheckbox.Size = new System.Drawing.Size(85, 17);
            this.amIServerCheckbox.TabIndex = 0;
            this.amIServerCheckbox.Text = "Am I server?";
            this.amIServerCheckbox.UseVisualStyleBackColor = true;
            // 
            // listOfPlayersTextbox
            // 
            this.listOfPlayersTextbox.Location = new System.Drawing.Point(12, 78);
            this.listOfPlayersTextbox.Name = "listOfPlayersTextbox";
            this.listOfPlayersTextbox.Size = new System.Drawing.Size(296, 101);
            this.listOfPlayersTextbox.TabIndex = 1;
            this.listOfPlayersTextbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Players";
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(15, 215);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(293, 20);
            this.ipTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP";
            // 
            // ConnectCreateButton
            // 
            this.ConnectCreateButton.Location = new System.Drawing.Point(18, 242);
            this.ConnectCreateButton.Name = "ConnectCreateButton";
            this.ConnectCreateButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectCreateButton.TabIndex = 5;
            this.ConnectCreateButton.Text = "Connect";
            this.ConnectCreateButton.UseVisualStyleBackColor = true;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 440);
            this.Controls.Add(this.ConnectCreateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfPlayersTextbox);
            this.Controls.Add(this.amIServerCheckbox);
            this.Name = "Lobby";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox amIServerCheckbox;
        private System.Windows.Forms.RichTextBox listOfPlayersTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectCreateButton;
    }
}