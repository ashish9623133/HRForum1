namespace GayaSoftHRForum
{
    partial class FrmLogin
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
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.linklblforgotpassword = new System.Windows.Forms.LinkLabel();
            this.linklblregisteranewaccount = new System.Windows.Forms.LinkLabel();
            this.btnsignin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnshowpass = new System.Windows.Forms.Button();
            this.btnhidepass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblemailid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.LightGray;
            this.lblpassword.Location = new System.Drawing.Point(1036, 1284);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(109, 25);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // txtemailid
            // 
            this.txtemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtemailid.Location = new System.Drawing.Point(249, 94);
            this.txtemailid.Margin = new System.Windows.Forms.Padding(4);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(313, 30);
            this.txtemailid.TabIndex = 5;
            this.txtemailid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemailid.TextChanged += new System.EventHandler(this.txtemailid_TextChanged);
            this.txtemailid.MouseHover += new System.EventHandler(this.txtemailid_MouseHover);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpassword.Location = new System.Drawing.Point(249, 202);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(313, 30);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // linklblforgotpassword
            // 
            this.linklblforgotpassword.AutoSize = true;
            this.linklblforgotpassword.BackColor = System.Drawing.Color.Transparent;
            this.linklblforgotpassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.linklblforgotpassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linklblforgotpassword.Location = new System.Drawing.Point(473, 435);
            this.linklblforgotpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblforgotpassword.Name = "linklblforgotpassword";
            this.linklblforgotpassword.Size = new System.Drawing.Size(186, 26);
            this.linklblforgotpassword.TabIndex = 9;
            this.linklblforgotpassword.TabStop = true;
            this.linklblforgotpassword.Text = "Forgot Password";
            this.linklblforgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblforgotpassword_LinkClicked);
            // 
            // linklblregisteranewaccount
            // 
            this.linklblregisteranewaccount.AutoSize = true;
            this.linklblregisteranewaccount.BackColor = System.Drawing.Color.Transparent;
            this.linklblregisteranewaccount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.linklblregisteranewaccount.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linklblregisteranewaccount.Location = new System.Drawing.Point(52, 435);
            this.linklblregisteranewaccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblregisteranewaccount.Name = "linklblregisteranewaccount";
            this.linklblregisteranewaccount.Size = new System.Drawing.Size(260, 26);
            this.linklblregisteranewaccount.TabIndex = 11;
            this.linklblregisteranewaccount.TabStop = true;
            this.linklblregisteranewaccount.Text = "Register A New Account";
            this.linklblregisteranewaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblregisteranewaccount_LinkClicked);
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnsignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsignin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsignin.Location = new System.Drawing.Point(274, 318);
            this.btnsignin.Margin = new System.Windows.Forms.Padding(4);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(223, 64);
            this.btnsignin.TabIndex = 12;
            this.btnsignin.Text = "Sign-In";
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnshowpass);
            this.panel1.Controls.Add(this.btnhidepass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtemailid);
            this.panel1.Controls.Add(this.lblemailid);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.linklblforgotpassword);
            this.panel1.Controls.Add(this.linklblregisteranewaccount);
            this.panel1.Controls.Add(this.btnsignin);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panel1.Location = new System.Drawing.Point(502, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 514);
            this.panel1.TabIndex = 18;
            // 
            // btnshowpass
            // 
            this.btnshowpass.BackgroundImage = global::GayaSoftHRForum.Properties.Resources.Screenshot__27_2;
            this.btnshowpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnshowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshowpass.ForeColor = System.Drawing.Color.Transparent;
            this.btnshowpass.Image = global::GayaSoftHRForum.Properties.Resources.icons8_eye_321;
            this.btnshowpass.Location = new System.Drawing.Point(592, 197);
            this.btnshowpass.Name = "btnshowpass";
            this.btnshowpass.Size = new System.Drawing.Size(53, 40);
            this.btnshowpass.TabIndex = 17;
            this.btnshowpass.UseVisualStyleBackColor = true;
            this.btnshowpass.Click += new System.EventHandler(this.btnshowpass_Click);
            // 
            // btnhidepass
            // 
            this.btnhidepass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhidepass.BackgroundImage = global::GayaSoftHRForum.Properties.Resources.Screenshot__27_;
            this.btnhidepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhidepass.ForeColor = System.Drawing.Color.Transparent;
            this.btnhidepass.Image = global::GayaSoftHRForum.Properties.Resources.icons8_closed_eye_32;
            this.btnhidepass.Location = new System.Drawing.Point(592, 197);
            this.btnhidepass.Name = "btnhidepass";
            this.btnhidepass.Size = new System.Drawing.Size(53, 40);
            this.btnhidepass.TabIndex = 16;
            this.btnhidepass.UseVisualStyleBackColor = false;
            this.btnhidepass.Click += new System.EventHandler(this.btnhidepass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = global::GayaSoftHRForum.Properties.Resources.icons8_padlock_30;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(38, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "      Password";
            // 
            // lblemailid
            // 
            this.lblemailid.AutoSize = true;
            this.lblemailid.BackColor = System.Drawing.Color.Transparent;
            this.lblemailid.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblemailid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemailid.Image = global::GayaSoftHRForum.Properties.Resources.icons8_add_user_male_30;
            this.lblemailid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblemailid.Location = new System.Drawing.Point(38, 94);
            this.lblemailid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemailid.Name = "lblemailid";
            this.lblemailid.Size = new System.Drawing.Size(141, 26);
            this.lblemailid.TabIndex = 1;
            this.lblemailid.Text = "      Email ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(497, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Login To Your Account ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GayaSoftHRForum.Properties.Resources.download_removebg_preview_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(-18, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(269, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(698, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Welcome To HR Forum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1468, 828);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblpassword);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblemailid;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.LinkLabel linklblforgotpassword;
        private System.Windows.Forms.LinkLabel linklblregisteranewaccount;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnshowpass;
        private System.Windows.Forms.Button btnhidepass;
        private System.Windows.Forms.Label label1;
    }
}