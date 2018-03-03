namespace TwitchChatBot
{
    partial class uxMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxMainForm));
            this.uxOutputText = new System.Windows.Forms.CheckBox();
            this.uxIntervalBox = new System.Windows.Forms.TextBox();
            this.uxMessage = new System.Windows.Forms.TextBox();
            this.uxTimer = new System.Windows.Forms.TextBox();
            this.uxSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxOutputText
            // 
            this.uxOutputText.AutoSize = true;
            this.uxOutputText.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOutputText.Location = new System.Drawing.Point(12, 12);
            this.uxOutputText.Name = "uxOutputText";
            this.uxOutputText.Size = new System.Drawing.Size(235, 53);
            this.uxOutputText.TabIndex = 0;
            this.uxOutputText.Text = "Output Text";
            this.uxOutputText.UseVisualStyleBackColor = true;
            this.uxOutputText.CheckedChanged += new System.EventHandler(this.uxOutputText_CheckedChanged);
            // 
            // uxIntervalBox
            // 
            this.uxIntervalBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxIntervalBox.Location = new System.Drawing.Point(12, 71);
            this.uxIntervalBox.Name = "uxIntervalBox";
            this.uxIntervalBox.ReadOnly = true;
            this.uxIntervalBox.Size = new System.Drawing.Size(231, 29);
            this.uxIntervalBox.TabIndex = 1;
            // 
            // uxMessage
            // 
            this.uxMessage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMessage.Location = new System.Drawing.Point(12, 141);
            this.uxMessage.Name = "uxMessage";
            this.uxMessage.ReadOnly = true;
            this.uxMessage.Size = new System.Drawing.Size(231, 29);
            this.uxMessage.TabIndex = 2;
            // 
            // uxTimer
            // 
            this.uxTimer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTimer.Location = new System.Drawing.Point(12, 106);
            this.uxTimer.Name = "uxTimer";
            this.uxTimer.ReadOnly = true;
            this.uxTimer.Size = new System.Drawing.Size(231, 29);
            this.uxTimer.TabIndex = 3;
            // 
            // uxSendMessage
            // 
            this.uxSendMessage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSendMessage.Location = new System.Drawing.Point(12, 176);
            this.uxSendMessage.Name = "uxSendMessage";
            this.uxSendMessage.Size = new System.Drawing.Size(231, 35);
            this.uxSendMessage.TabIndex = 4;
            this.uxSendMessage.Text = "Send Message";
            this.uxSendMessage.UseVisualStyleBackColor = true;
            this.uxSendMessage.Click += new System.EventHandler(this.uxSendMessage_Click);
            // 
            // uxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 223);
            this.Controls.Add(this.uxSendMessage);
            this.Controls.Add(this.uxTimer);
            this.Controls.Add(this.uxMessage);
            this.Controls.Add(this.uxIntervalBox);
            this.Controls.Add(this.uxOutputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "uxMainForm";
            this.Text = "Twitch Chat Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.uxMainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox uxOutputText;
        private System.Windows.Forms.TextBox uxIntervalBox;
        private System.Windows.Forms.TextBox uxMessage;
        private System.Windows.Forms.TextBox uxTimer;
        private System.Windows.Forms.Button uxSendMessage;
    }
}

