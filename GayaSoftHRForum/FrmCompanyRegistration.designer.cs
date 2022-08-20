namespace GayaSoftHRForum
{
    partial class FrmCompanyRegistration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyRegistration));
            this.lblCompanyRegistration = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblIndustry = new System.Windows.Forms.Label();
            this.cmbbxIndustry = new System.Windows.Forms.ComboBox();
            this.btnAddIndustry = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblLinkedIn = new System.Windows.Forms.Label();
            this.txtLinkedIn = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbbxCountry = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblHRdetails = new System.Windows.Forms.Label();
            this.txtHRname = new System.Windows.Forms.TextBox();
            this.txtHRemail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rchtxtAddress = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblHRname = new System.Windows.Forms.Label();
            this.lblHRemail = new System.Windows.Forms.Label();
            this.lblHRphonNo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyRegistration
            // 
            this.lblCompanyRegistration.AutoSize = true;
            this.lblCompanyRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyRegistration.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyRegistration.Location = new System.Drawing.Point(658, 19);
            this.lblCompanyRegistration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompanyRegistration.Name = "lblCompanyRegistration";
            this.lblCompanyRegistration.Size = new System.Drawing.Size(284, 32);
            this.lblCompanyRegistration.TabIndex = 0;
            this.lblCompanyRegistration.Text = "Company Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(210, 84);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 109);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 27);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(546, 83);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(439, 109);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblIndustry
            // 
            this.lblIndustry.AutoSize = true;
            this.lblIndustry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIndustry.Location = new System.Drawing.Point(1209, 85);
            this.lblIndustry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIndustry.Name = "lblIndustry";
            this.lblIndustry.Size = new System.Drawing.Size(122, 20);
            this.lblIndustry.TabIndex = 5;
            this.lblIndustry.Text = "Industry Type";
            // 
            // cmbbxIndustry
            // 
            this.cmbbxIndustry.FormattingEnabled = true;
            this.cmbbxIndustry.Location = new System.Drawing.Point(1164, 109);
            this.cmbbxIndustry.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbbxIndustry.Name = "cmbbxIndustry";
            this.cmbbxIndustry.Size = new System.Drawing.Size(279, 28);
            this.cmbbxIndustry.TabIndex = 6;
            // 
            // btnAddIndustry
            // 
            this.btnAddIndustry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddIndustry.BackgroundImage")));
            this.btnAddIndustry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddIndustry.Location = new System.Drawing.Point(2173, 104);
            this.btnAddIndustry.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddIndustry.Name = "btnAddIndustry";
            this.btnAddIndustry.Size = new System.Drawing.Size(66, 35);
            this.btnAddIndustry.TabIndex = 7;
            this.btnAddIndustry.UseVisualStyleBackColor = true;
            this.btnAddIndustry.Click += new System.EventHandler(this.btnAddIndustry_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(1209, 243);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 20);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(1164, 263);
            this.cmbbxCity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(279, 28);
            this.cmbbxCity.TabIndex = 9;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebsite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWebsite.Location = new System.Drawing.Point(210, 169);
            this.lblWebsite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(90, 25);
            this.lblWebsite.TabIndex = 11;
            this.lblWebsite.Text = "Website";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(118, 192);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(278, 27);
            this.txtWebsite.TabIndex = 12;
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacebook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFacebook.Location = new System.Drawing.Point(532, 166);
            this.lblFacebook.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(110, 25);
            this.lblFacebook.TabIndex = 13;
            this.lblFacebook.Text = "Facebook";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(439, 191);
            this.txtFacebook.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(294, 27);
            this.txtFacebook.TabIndex = 14;
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTwitter.Location = new System.Drawing.Point(909, 168);
            this.lblTwitter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(84, 25);
            this.lblTwitter.TabIndex = 15;
            this.lblTwitter.Text = "Twitter";
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(807, 193);
            this.txtTwitter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(294, 27);
            this.txtTwitter.TabIndex = 16;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwner.Location = new System.Drawing.Point(909, 85);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(81, 25);
            this.lblOwner.TabIndex = 17;
            this.lblOwner.Text = "Owner";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(807, 110);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(294, 27);
            this.txtOwner.TabIndex = 18;
            this.txtOwner.TextChanged += new System.EventHandler(this.txtOwner_TextChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCountry.Location = new System.Drawing.Point(1209, 170);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(74, 20);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Country";
            // 
            // lblLinkedIn
            // 
            this.lblLinkedIn.AutoSize = true;
            this.lblLinkedIn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkedIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLinkedIn.Location = new System.Drawing.Point(210, 243);
            this.lblLinkedIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLinkedIn.Name = "lblLinkedIn";
            this.lblLinkedIn.Size = new System.Drawing.Size(103, 25);
            this.lblLinkedIn.TabIndex = 20;
            this.lblLinkedIn.Text = "LinkedIn";
            // 
            // txtLinkedIn
            // 
            this.txtLinkedIn.Location = new System.Drawing.Point(118, 268);
            this.txtLinkedIn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLinkedIn.Name = "txtLinkedIn";
            this.txtLinkedIn.Size = new System.Drawing.Size(278, 27);
            this.txtLinkedIn.TabIndex = 21;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(252, 349);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 25);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            // 
            // cmbbxCountry
            // 
            this.cmbbxCountry.FormattingEnabled = true;
            this.cmbbxCountry.Location = new System.Drawing.Point(1164, 193);
            this.cmbbxCountry.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbbxCountry.Name = "cmbbxCountry";
            this.cmbbxCountry.Size = new System.Drawing.Size(279, 28);
            this.cmbbxCountry.TabIndex = 24;
            this.cmbbxCountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(909, 244);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(64, 25);
            this.lblState.TabIndex = 25;
            this.lblState.Text = "State";
            // 
            // cmbbxState
            // 
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(807, 266);
            this.cmbbxState.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(294, 28);
            this.cmbbxState.TabIndex = 26;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegistrationDate.Location = new System.Drawing.Point(492, 242);
            this.lblRegistrationDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(188, 25);
            this.lblRegistrationDate.TabIndex = 29;
            this.lblRegistrationDate.Text = "Registration Date";
            // 
            // lblHRdetails
            // 
            this.lblHRdetails.AutoSize = true;
            this.lblHRdetails.BackColor = System.Drawing.Color.Transparent;
            this.lblHRdetails.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRdetails.Location = new System.Drawing.Point(671, 522);
            this.lblHRdetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHRdetails.Name = "lblHRdetails";
            this.lblHRdetails.Size = new System.Drawing.Size(200, 31);
            this.lblHRdetails.TabIndex = 31;
            this.lblHRdetails.Text = "Add HR Details";
            // 
            // txtHRname
            // 
            this.txtHRname.AccessibleDescription = "";
            this.txtHRname.Location = new System.Drawing.Point(89, 641);
            this.txtHRname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtHRname.Name = "txtHRname";
            this.txtHRname.Size = new System.Drawing.Size(278, 27);
            this.txtHRname.TabIndex = 32;
            // 
            // txtHRemail
            // 
            this.txtHRemail.Location = new System.Drawing.Point(619, 641);
            this.txtHRemail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtHRemail.Name = "txtHRemail";
            this.txtHRemail.Size = new System.Drawing.Size(294, 27);
            this.txtHRemail.TabIndex = 33;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(1175, 641);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(294, 27);
            this.txtPhoneNo.TabIndex = 34;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(424, 730);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 45);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(975, 730);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(156, 45);
            this.btnRegister.TabIndex = 37;
            this.btnRegister.Text = " Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rchtxtAddress
            // 
            this.rchtxtAddress.Location = new System.Drawing.Point(256, 374);
            this.rchtxtAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rchtxtAddress.Name = "rchtxtAddress";
            this.rchtxtAddress.Size = new System.Drawing.Size(1058, 103);
            this.rchtxtAddress.TabIndex = 38;
            this.rchtxtAddress.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(439, 267);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 27);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblHRname
            // 
            this.lblHRname.AutoSize = true;
            this.lblHRname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHRname.Location = new System.Drawing.Point(181, 599);
            this.lblHRname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHRname.Name = "lblHRname";
            this.lblHRname.Size = new System.Drawing.Size(112, 25);
            this.lblHRname.TabIndex = 40;
            this.lblHRname.Text = "HR Name";
            // 
            // lblHRemail
            // 
            this.lblHRemail.AutoSize = true;
            this.lblHRemail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHRemail.Location = new System.Drawing.Point(713, 599);
            this.lblHRemail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHRemail.Name = "lblHRemail";
            this.lblHRemail.Size = new System.Drawing.Size(109, 25);
            this.lblHRemail.TabIndex = 41;
            this.lblHRemail.Text = "HR Email";
            // 
            // lblHRphonNo
            // 
            this.lblHRphonNo.AutoSize = true;
            this.lblHRphonNo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRphonNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHRphonNo.Location = new System.Drawing.Point(1261, 599);
            this.lblHRphonNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHRphonNo.Name = "lblHRphonNo";
            this.lblHRphonNo.Size = new System.Drawing.Size(158, 25);
            this.lblHRphonNo.TabIndex = 42;
            this.lblHRphonNo.Text = "HR Phone No.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCompanyRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1924, 792);
            this.Controls.Add(this.lblHRphonNo);
            this.Controls.Add(this.lblHRemail);
            this.Controls.Add(this.lblHRname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rchtxtAddress);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtHRemail);
            this.Controls.Add(this.txtHRname);
            this.Controls.Add(this.lblHRdetails);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.cmbbxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.cmbbxCountry);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtLinkedIn);
            this.Controls.Add(this.lblLinkedIn);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.lblTwitter);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.cmbbxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnAddIndustry);
            this.Controls.Add(this.cmbbxIndustry);
            this.Controls.Add(this.lblIndustry);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCompanyRegistration);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmCompanyRegistration";
            this.Text = "FrmCompanyRegistration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCompanyRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyRegistration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblIndustry;
        private System.Windows.Forms.ComboBox cmbbxIndustry;
        private System.Windows.Forms.Button btnAddIndustry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblLinkedIn;
        private System.Windows.Forms.TextBox txtLinkedIn;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbbxCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblHRdetails;
        private System.Windows.Forms.TextBox txtHRname;
        private System.Windows.Forms.TextBox txtHRemail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RichTextBox rchtxtAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblHRname;
        private System.Windows.Forms.Label lblHRemail;
        private System.Windows.Forms.Label lblHRphonNo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}