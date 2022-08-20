namespace GayaSoftHRForum
{
    partial class frmMemberSettingEditStaff
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
            this.lblRegisterAcccount = new System.Windows.Forms.Label();
            this.lblstate = new System.Windows.Forms.Label();
            this.lblcountry = new System.Windows.Forms.Label();
            this.cmbbxcountry = new System.Windows.Forms.ComboBox();
            this.cmbbxstate = new System.Windows.Forms.ComboBox();
            this.cmbbxcity = new System.Windows.Forms.ComboBox();
            this.DTPdob = new System.Windows.Forms.DateTimePicker();
            this.cmbbxposition = new System.Windows.Forms.ComboBox();
            this.rdbtnfemale = new System.Windows.Forms.RadioButton();
            this.rdbtnmale = new System.Windows.Forms.RadioButton();
            this.txtpincode = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.lblposition = new System.Windows.Forms.Label();
            this.lblpincode = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblmobileno = new System.Windows.Forms.Label();
            this.lblemailid = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegisterAcccount
            // 
            this.lblRegisterAcccount.AutoSize = true;
            this.lblRegisterAcccount.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterAcccount.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterAcccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegisterAcccount.Location = new System.Drawing.Point(738, 35);
            this.lblRegisterAcccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterAcccount.Name = "lblRegisterAcccount";
            this.lblRegisterAcccount.Size = new System.Drawing.Size(216, 31);
            this.lblRegisterAcccount.TabIndex = 15;
            this.lblRegisterAcccount.Text = "Edit Staff Details";
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.BackColor = System.Drawing.Color.Transparent;
            this.lblstate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblstate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstate.Location = new System.Drawing.Point(296, 438);
            this.lblstate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(64, 25);
            this.lblstate.TabIndex = 63;
            this.lblstate.Text = "State";
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.BackColor = System.Drawing.Color.Transparent;
            this.lblcountry.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblcountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcountry.Location = new System.Drawing.Point(928, 281);
            this.lblcountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(96, 25);
            this.lblcountry.TabIndex = 62;
            this.lblcountry.Text = "Country";
            // 
            // cmbbxcountry
            // 
            this.cmbbxcountry.FormattingEnabled = true;
            this.cmbbxcountry.Location = new System.Drawing.Point(1100, 277);
            this.cmbbxcountry.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxcountry.Name = "cmbbxcountry";
            this.cmbbxcountry.Size = new System.Drawing.Size(265, 24);
            this.cmbbxcountry.TabIndex = 61;
            this.cmbbxcountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxcountry_SelectedIndexChanged);
            // 
            // cmbbxstate
            // 
            this.cmbbxstate.FormattingEnabled = true;
            this.cmbbxstate.Location = new System.Drawing.Point(505, 434);
            this.cmbbxstate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxstate.Name = "cmbbxstate";
            this.cmbbxstate.Size = new System.Drawing.Size(265, 24);
            this.cmbbxstate.TabIndex = 60;
            this.cmbbxstate.SelectedIndexChanged += new System.EventHandler(this.cmbbxstate_SelectedIndexChanged);
            // 
            // cmbbxcity
            // 
            this.cmbbxcity.FormattingEnabled = true;
            this.cmbbxcity.Location = new System.Drawing.Point(1100, 356);
            this.cmbbxcity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxcity.Name = "cmbbxcity";
            this.cmbbxcity.Size = new System.Drawing.Size(265, 24);
            this.cmbbxcity.TabIndex = 59;
            // 
            // DTPdob
            // 
            this.DTPdob.Location = new System.Drawing.Point(505, 280);
            this.DTPdob.Margin = new System.Windows.Forms.Padding(4);
            this.DTPdob.MaxDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.DTPdob.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.DTPdob.Name = "DTPdob";
            this.DTPdob.Size = new System.Drawing.Size(265, 22);
            this.DTPdob.TabIndex = 58;
            this.DTPdob.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // cmbbxposition
            // 
            this.cmbbxposition.FormattingEnabled = true;
            this.cmbbxposition.Items.AddRange(new object[] {
            "Admin",
            "HR",
            "Assitant HR"});
            this.cmbbxposition.Location = new System.Drawing.Point(1100, 434);
            this.cmbbxposition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxposition.Name = "cmbbxposition";
            this.cmbbxposition.Size = new System.Drawing.Size(265, 24);
            this.cmbbxposition.TabIndex = 57;
            // 
            // rdbtnfemale
            // 
            this.rdbtnfemale.AutoSize = true;
            this.rdbtnfemale.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnfemale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.rdbtnfemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbtnfemale.Location = new System.Drawing.Point(1279, 204);
            this.rdbtnfemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnfemale.Name = "rdbtnfemale";
            this.rdbtnfemale.Size = new System.Drawing.Size(106, 29);
            this.rdbtnfemale.TabIndex = 56;
            this.rdbtnfemale.TabStop = true;
            this.rdbtnfemale.Text = "Female";
            this.rdbtnfemale.UseVisualStyleBackColor = false;
            // 
            // rdbtnmale
            // 
            this.rdbtnmale.AutoSize = true;
            this.rdbtnmale.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnmale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.rdbtnmale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbtnmale.Location = new System.Drawing.Point(1123, 204);
            this.rdbtnmale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnmale.Name = "rdbtnmale";
            this.rdbtnmale.Size = new System.Drawing.Size(84, 29);
            this.rdbtnmale.TabIndex = 55;
            this.rdbtnmale.TabStop = true;
            this.rdbtnmale.Text = "Male";
            this.rdbtnmale.UseVisualStyleBackColor = false;
            // 
            // txtpincode
            // 
            this.txtpincode.Location = new System.Drawing.Point(505, 510);
            this.txtpincode.Margin = new System.Windows.Forms.Padding(4);
            this.txtpincode.Name = "txtpincode";
            this.txtpincode.Size = new System.Drawing.Size(265, 22);
            this.txtpincode.TabIndex = 54;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(505, 355);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(265, 22);
            this.txtaddress.TabIndex = 53;
            // 
            // txtmobileno
            // 
            this.txtmobileno.Location = new System.Drawing.Point(505, 196);
            this.txtmobileno.Margin = new System.Windows.Forms.Padding(4);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(265, 22);
            this.txtmobileno.TabIndex = 52;
            // 
            // txtemailid
            // 
            this.txtemailid.Location = new System.Drawing.Point(1100, 129);
            this.txtemailid.Margin = new System.Windows.Forms.Padding(4);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(265, 22);
            this.txtemailid.TabIndex = 48;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(505, 131);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(265, 22);
            this.txtfullname.TabIndex = 47;
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.BackColor = System.Drawing.Color.Transparent;
            this.lblposition.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblposition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblposition.Location = new System.Drawing.Point(928, 434);
            this.lblposition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(91, 25);
            this.lblposition.TabIndex = 46;
            this.lblposition.Text = "Position";
            // 
            // lblpincode
            // 
            this.lblpincode.AutoSize = true;
            this.lblpincode.BackColor = System.Drawing.Color.Transparent;
            this.lblpincode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblpincode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpincode.Location = new System.Drawing.Point(296, 512);
            this.lblpincode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpincode.Name = "lblpincode";
            this.lblpincode.Size = new System.Drawing.Size(92, 25);
            this.lblpincode.TabIndex = 45;
            this.lblpincode.Text = "Pincode";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.BackColor = System.Drawing.Color.Transparent;
            this.lblcity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblcity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcity.Location = new System.Drawing.Point(928, 360);
            this.lblcity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(53, 25);
            this.lblcity.TabIndex = 44;
            this.lblcity.Text = "City";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbladdress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladdress.Location = new System.Drawing.Point(294, 355);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(93, 25);
            this.lbladdress.TabIndex = 43;
            this.lbladdress.Text = "Address";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblgender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgender.Location = new System.Drawing.Point(928, 204);
            this.lblgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(88, 25);
            this.lblgender.TabIndex = 42;
            this.lblgender.Text = "Gender";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.BackColor = System.Drawing.Color.Transparent;
            this.lbldob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbldob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldob.Location = new System.Drawing.Point(299, 280);
            this.lbldob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(63, 25);
            this.lbldob.TabIndex = 41;
            this.lbldob.Text = "DOB";
            // 
            // lblmobileno
            // 
            this.lblmobileno.AutoSize = true;
            this.lblmobileno.BackColor = System.Drawing.Color.Transparent;
            this.lblmobileno.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblmobileno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmobileno.Location = new System.Drawing.Point(299, 196);
            this.lblmobileno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmobileno.Name = "lblmobileno";
            this.lblmobileno.Size = new System.Drawing.Size(116, 25);
            this.lblmobileno.TabIndex = 40;
            this.lblmobileno.Text = "Mobile No";
            this.lblmobileno.Click += new System.EventHandler(this.lblmobileno_Click_1);
            // 
            // lblemailid
            // 
            this.lblemailid.AutoSize = true;
            this.lblemailid.BackColor = System.Drawing.Color.Transparent;
            this.lblemailid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblemailid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblemailid.Location = new System.Drawing.Point(928, 131);
            this.lblemailid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemailid.Name = "lblemailid";
            this.lblemailid.Size = new System.Drawing.Size(100, 25);
            this.lblemailid.TabIndex = 36;
            this.lblemailid.Text = "Email ID";
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.BackColor = System.Drawing.Color.Transparent;
            this.lblfullname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblfullname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfullname.Location = new System.Drawing.Point(294, 131);
            this.lblfullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(115, 25);
            this.lblfullname.TabIndex = 35;
            this.lblfullname.Text = "Full Name";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(570, 631);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(120, 41);
            this.btnupdate.TabIndex = 64;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(933, 631);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 41);
            this.btnclear.TabIndex = 65;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // frmMemberSettingEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1535, 745);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.lblcountry);
            this.Controls.Add(this.cmbbxcountry);
            this.Controls.Add(this.cmbbxstate);
            this.Controls.Add(this.cmbbxcity);
            this.Controls.Add(this.DTPdob);
            this.Controls.Add(this.cmbbxposition);
            this.Controls.Add(this.rdbtnfemale);
            this.Controls.Add(this.rdbtnmale);
            this.Controls.Add(this.txtpincode);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtmobileno);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.lblpincode);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblmobileno);
            this.Controls.Add(this.lblemailid);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.lblRegisterAcccount);
            this.Name = "frmMemberSettingEditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberSettingEditStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMemberSettingEditStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegisterAcccount;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.ComboBox cmbbxcountry;
        private System.Windows.Forms.ComboBox cmbbxstate;
        private System.Windows.Forms.ComboBox cmbbxcity;
        private System.Windows.Forms.DateTimePicker DTPdob;
        private System.Windows.Forms.ComboBox cmbbxposition;
        private System.Windows.Forms.RadioButton rdbtnfemale;
        private System.Windows.Forms.RadioButton rdbtnmale;
        private System.Windows.Forms.TextBox txtpincode;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Label lblpincode;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblmobileno;
        private System.Windows.Forms.Label lblemailid;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
    }
}