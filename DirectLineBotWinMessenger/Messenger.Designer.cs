namespace DirectLineBotWinMessenger
{
    partial class Messenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messenger));
            this.ConversationTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.BotIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectLineSecretTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConversationTextBox
            // 
            this.ConversationTextBox.BackColor = System.Drawing.Color.White;
            this.ConversationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConversationTextBox.Location = new System.Drawing.Point(9, 19);
            this.ConversationTextBox.Multiline = true;
            this.ConversationTextBox.Name = "ConversationTextBox";
            this.ConversationTextBox.ReadOnly = true;
            this.ConversationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConversationTextBox.Size = new System.Drawing.Size(815, 432);
            this.ConversationTextBox.TabIndex = 3;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.White;
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.Location = new System.Drawing.Point(9, 466);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(736, 26);
            this.MessageTextBox.TabIndex = 4;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(749, 466);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 26);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Enviar";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // BotIdTextBox
            // 
            this.BotIdTextBox.BackColor = System.Drawing.Color.White;
            this.BotIdTextBox.Location = new System.Drawing.Point(52, 10);
            this.BotIdTextBox.Name = "BotIdTextBox";
            this.BotIdTextBox.Size = new System.Drawing.Size(229, 20);
            this.BotIdTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BotId:";
            // 
            // DirectLineSecretTextBox
            // 
            this.DirectLineSecretTextBox.BackColor = System.Drawing.Color.White;
            this.DirectLineSecretTextBox.Location = new System.Drawing.Point(392, 10);
            this.DirectLineSecretTextBox.Name = "DirectLineSecretTextBox";
            this.DirectLineSecretTextBox.Size = new System.Drawing.Size(229, 20);
            this.DirectLineSecretTextBox.TabIndex = 1;
            this.DirectLineSecretTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DirectLineSecret:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(636, 6);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 26);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Conectar";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.ConversationTextBox);
            this.groupBox.Controls.Add(this.MessageTextBox);
            this.groupBox.Controls.Add(this.SendButton);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(7, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(834, 505);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            // 
            // Messenger
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 548);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirectLineSecretTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotIdTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Messenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direct Line Windows Messenger";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConversationTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox BotIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DirectLineSecretTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

