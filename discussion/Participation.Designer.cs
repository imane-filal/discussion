
namespace discussion
{
    partial class Participation
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
            this.lstParticipants = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MRecusPanel = new System.Windows.Forms.Panel();
            this.Message1 = new System.Windows.Forms.Label();
            this.MRecusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstParticipants
            // 
            this.lstParticipants.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstParticipants.FormattingEnabled = true;
            this.lstParticipants.ItemHeight = 21;
            this.lstParticipants.Location = new System.Drawing.Point(23, 59);
            this.lstParticipants.Name = "lstParticipants";
            this.lstParticipants.Size = new System.Drawing.Size(120, 256);
            this.lstParticipants.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Participants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(213, 59);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(301, 50);
            this.txtMessage.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Les  Messages Récus";
            // 
            // MRecusPanel
            // 
            this.MRecusPanel.BackColor = System.Drawing.SystemColors.Info;
            this.MRecusPanel.Controls.Add(this.Message1);
            this.MRecusPanel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MRecusPanel.Location = new System.Drawing.Point(23, 358);
            this.MRecusPanel.Name = "MRecusPanel";
            this.MRecusPanel.Size = new System.Drawing.Size(620, 100);
            this.MRecusPanel.TabIndex = 6;
            // 
            // Message1
            // 
            this.Message1.AutoSize = true;
            this.Message1.Location = new System.Drawing.Point(21, 14);
            this.Message1.Name = "Message1";
            this.Message1.Size = new System.Drawing.Size(0, 13);
            this.Message1.TabIndex = 0;
            // 
            // Participation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 482);
            this.Controls.Add(this.MRecusPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstParticipants);
            this.Name = "Participation";
            this.Text = "Participation";
            this.Load += new System.EventHandler(this.Participation_Load);
            this.MRecusPanel.ResumeLayout(false);
            this.MRecusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstParticipants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel MRecusPanel;
        private System.Windows.Forms.Label Message1;
    }
}