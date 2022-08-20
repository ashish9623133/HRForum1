namespace GayaSoftHRForum
{
    partial class frmchangepassword
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
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtconfimpassword = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lblcurrentpassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.ForeColor = System.Drawing.Color.Black;
            this.txtoldpassword.Location = new System.Drawing.Point(321, 186);
            this.txtoldpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(199, 22);
            this.txtoldpassword.TabIndex = 3;
            this.txtoldpassword.TextChanged += new System.EventHandler(this.txtoldpassword_TextChanged);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(321, 255);
            this.txtnewpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(199, 22);
            this.txtnewpassword.TabIndex = 4;
            this.txtnewpassword.TextChanged += new System.EventHandler(this.txtnewpassword_TextChanged);
            // 
            // txtconfimpassword
            // 
            this.txtconfimpassword.Location = new System.Drawing.Point(321, 320);
            this.txtconfimpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfimpassword.Name = "txtconfimpassword";
            this.txtconfimpassword.Size = new System.Drawing.Size(199, 22);
            this.txtconfimpassword.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnsubmit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubmit.Location = new System.Drawing.Point(210, 397);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(123, 38);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnsubmit);
            this.panel1.Controls.Add(this.lblconfirmpassword);
            this.panel1.Controls.Add(this.txtoldpassword);
            this.panel1.Controls.Add(this.lblnewpassword);
            this.panel1.Controls.Add(this.txtconfimpassword);
            this.panel1.Controls.Add(this.lblcurrentpassword);
            this.panel1.Controls.Add(this.txtnewpassword);
            this.panel1.Location = new System.Drawing.Point(247, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 494);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(150, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Change a password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GayaSoftHRForum.Properties.Resources.kindpng_photo_Shop2;
            this.pictureBox1.Location = new System.Drawing.Point(210, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblconfirmpassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblconfirmpassword.Image = global::GayaSoftHRForum.Properties.Resources.icons8_good_pincode_35;
            this.lblconfirmpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblconfirmpassword.Location = new System.Drawing.Point(31, 315);
            this.lblconfirmpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(232, 27);
            this.lblconfirmpassword.TabIndex = 2;
            this.lblconfirmpassword.Text = "       Confirm Password";
            this.lblconfirmpassword.Click += new System.EventHandler(this.lblconfirmpassword_Click);
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblnewpassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnewpassword.Image = global::GayaSoftHRForum.Properties.Resources.icons8_cloud_sync_35;
            this.lblnewpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblnewpassword.Location = new System.Drawing.Point(31, 250);
            this.lblnewpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(203, 27);
            this.lblnewpassword.TabIndex = 1;
            this.lblnewpassword.Text = "        New Password";
            // 
            // lblcurrentpassword
            // 
            this.lblcurrentpassword.AutoSize = true;
            this.lblcurrentpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblcurrentpassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcurrentpassword.Image = global::GayaSoftHRForum.Properties.Resources.icons8_lock_34;
            this.lblcurrentpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblcurrentpassword.Location = new System.Drawing.Point(31, 186);
            this.lblcurrentpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcurrentpassword.Name = "lblcurrentpassword";
            this.lblcurrentpassword.Size = new System.Drawing.Size(220, 27);
            this.lblcurrentpassword.TabIndex = 0;
            this.lblcurrentpassword.Text = "      Current Password";
            // 
            // frmchangepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmchangepassword";
            this.Text = "frmchangepassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmchangepassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcurrentpassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtconfimpassword;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}