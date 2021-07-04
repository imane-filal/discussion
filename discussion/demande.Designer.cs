
namespace discussion
{
    partial class demande
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnParticiper = new System.Windows.Forms.Button();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mon Pseudo :";
            // 
            // btnParticiper
            // 
            this.btnParticiper.Location = new System.Drawing.Point(411, 182);
            this.btnParticiper.Name = "btnParticiper";
            this.btnParticiper.Size = new System.Drawing.Size(112, 33);
            this.btnParticiper.TabIndex = 1;
            this.btnParticiper.Text = "Participer";
            this.btnParticiper.UseVisualStyleBackColor = true;
            this.btnParticiper.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPseudo
            // 
            this.txtPseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPseudo.Location = new System.Drawing.Point(284, 134);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(239, 20);
            this.txtPseudo.TabIndex = 2;

            // 
            // demande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 340);
            this.Controls.Add(this.txtPseudo);
            this.Controls.Add(this.btnParticiper);
            this.Controls.Add(this.label1);
            this.Name = "demande";
            this.Text = "demande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParticiper;
        private System.Windows.Forms.TextBox txtPseudo;
    }
}