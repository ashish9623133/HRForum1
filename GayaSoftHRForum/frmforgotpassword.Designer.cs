namespace GayaSoftHRForum
{
    partial class frmforgotpassword
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
            this.lblenteremailid = new System.Windows.Forms.Label();
            this.txtverifypwd = new System.Windows.Forms.TextBox();
            this.btnverifypwd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblenteremailid
            // 
            this.lblenteremailid.AutoSize = true;
            this.lblenteremailid.BackColor = System.Drawing.Color.Transparent;
            this.lblenteremailid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenteremailid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblenteremailid.Location = new System.Drawing.Point(322, 33);
            this.lblenteremailid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblenteremailid.Name = "lblenteremailid";
            this.lblenteremailid.Size = new System.Drawing.Size(530, 23);
            this.lblenteremailid.TabIndex = 0;
            this.lblenteremailid.Text = "Your Mail Id  is Verified and Your Password is Sent to Email Id";
            // 
            // txtverifypwd
            // 
            this.txtverifypwd.Location = new System.Drawing.Point(322, 179);
            this.txtverifypwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtverifypwd.Name = "txtverifypwd";
            this.txtverifypwd.Size = new System.Drawing.Size(246, 22);
            this.txtverifypwd.TabIndex = 4;
            this.txtverifypwd.TextChanged += new System.EventHandler(this.txtverifypwd_TextChanged);
            // 
            // btnverifypwd
            // 
            this.btnverifypwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnverifypwd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverifypwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnverifypwd.Location = new System.Drawing.Point(229, 248);
            this.btnverifypwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnverifypwd.Name = "btnverifypwd";
            this.btnverifypwd.Size = new System.Drawing.Size(160, 34);
            this.btnverifypwd.TabIndex = 5;
            this.btnverifypwd.Text = "Verify Password";
            this.btnverifypwd.UseVisualStyleBackColor = false;
            this.btnverifypwd.Click += new System.EventHandler(this.btnverifypwd_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtverifypwd);
            this.panel1.Controls.Add(this.btnverifypwd);
            this.panel1.Location = new System.Drawing.Point(226, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 394);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(232, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOTE :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GayaSoftHRForum.Properties.Resources.icons8_mail_100;
            this.pictureBox1.Location = new System.Drawing.Point(253, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 91);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = global::GayaSoftHRForum.Properties.Resources.icons8_checked_identification_documents_30;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(28, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "       Enter Your Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmforgotpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblenteremailid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmforgotpassword";
            this.Text = "frmforgotpassword";
            this.Load += new System.EventHandler(this.frmforgotpassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblenteremailid;
        private System.Windows.Forms.TextBox txtverifypwd;
        private System.Windows.Forms.Button btnverifypwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}