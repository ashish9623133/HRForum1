namespace GayaSoftHRForum
{
    partial class frmPersonalInformation
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmmbxCity = new System.Windows.Forms.ComboBox();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.cmbbxCountry = new System.Windows.Forms.ComboBox();
            this.dateTimeDob = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.rdbbtnOther = new System.Windows.Forms.RadioButton();
            this.rdbbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbbtnMale = new System.Windows.Forms.RadioButton();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.btnSavePersonalInfo = new System.Windows.Forms.Button();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblAddState = new System.Windows.Forms.Label();
            this.lblAddCity = new System.Windows.Forms.Label();
            this.btnUpdatePI = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblCoNOError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(649, 402);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(516, 30);
            this.txtAddress.TabIndex = 40;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(431, 395);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(95, 26);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // cmmbxCity
            // 
            this.cmmbxCity.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.cmmbxCity.FormattingEnabled = true;
            this.cmmbxCity.Location = new System.Drawing.Point(1373, 354);
            this.cmmbxCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmmbxCity.Name = "cmmbxCity";
            this.cmmbxCity.Size = new System.Drawing.Size(160, 33);
            this.cmmbxCity.TabIndex = 38;
            this.cmmbxCity.Text = "Select City";
            this.cmmbxCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmmbxCity_MouseClick);
            // 
            // cmbbxState
            // 
            this.cmbbxState.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(998, 352);
            this.cmbbxState.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(160, 33);
            this.cmbbxState.TabIndex = 37;
            this.cmbbxState.Text = "Select State";
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            this.cmbbxState.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbxState_MouseClick);
            // 
            // cmbbxCountry
            // 
            this.cmbbxCountry.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.cmbbxCountry.FormattingEnabled = true;
            this.cmbbxCountry.Location = new System.Drawing.Point(649, 354);
            this.cmbbxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxCountry.Name = "cmbbxCountry";
            this.cmbbxCountry.Size = new System.Drawing.Size(160, 33);
            this.cmbbxCountry.TabIndex = 36;
            this.cmbbxCountry.Text = "Select Country";
            this.cmbbxCountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged);
            this.cmbbxCountry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbxCountry_MouseClick);
            // 
            // dateTimeDob
            // 
            this.dateTimeDob.CustomFormat = "yyyy-MM-dd";
            this.dateTimeDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDob.Location = new System.Drawing.Point(649, 295);
            this.dateTimeDob.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeDob.MaxDate = new System.DateTime(2022, 3, 23, 0, 0, 0, 0);
            this.dateTimeDob.Name = "dateTimeDob";
            this.dateTimeDob.Size = new System.Drawing.Size(137, 30);
            this.dateTimeDob.TabIndex = 35;
            this.dateTimeDob.Value = new System.DateTime(2022, 3, 23, 0, 0, 0, 0);
            this.dateTimeDob.ValueChanged += new System.EventHandler(this.dateTimeDob_ValueChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(649, 249);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(516, 30);
            this.txtContactNo.TabIndex = 34;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // rdbbtnOther
            // 
            this.rdbbtnOther.AutoSize = true;
            this.rdbbtnOther.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnOther.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.rdbbtnOther.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbbtnOther.Location = new System.Drawing.Point(891, 197);
            this.rdbbtnOther.Margin = new System.Windows.Forms.Padding(4);
            this.rdbbtnOther.Name = "rdbbtnOther";
            this.rdbbtnOther.Size = new System.Drawing.Size(95, 30);
            this.rdbbtnOther.TabIndex = 33;
            this.rdbbtnOther.TabStop = true;
            this.rdbbtnOther.Text = "Other";
            this.rdbbtnOther.UseVisualStyleBackColor = false;
            // 
            // rdbbtnFemale
            // 
            this.rdbbtnFemale.AutoSize = true;
            this.rdbbtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnFemale.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.rdbbtnFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbbtnFemale.Location = new System.Drawing.Point(753, 197);
            this.rdbbtnFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbbtnFemale.Name = "rdbbtnFemale";
            this.rdbbtnFemale.Size = new System.Drawing.Size(108, 30);
            this.rdbbtnFemale.TabIndex = 32;
            this.rdbbtnFemale.TabStop = true;
            this.rdbbtnFemale.Text = "Female";
            this.rdbbtnFemale.UseVisualStyleBackColor = false;
            // 
            // rdbbtnMale
            // 
            this.rdbbtnMale.AutoSize = true;
            this.rdbbtnMale.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnMale.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.rdbbtnMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbbtnMale.Location = new System.Drawing.Point(633, 197);
            this.rdbbtnMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbbtnMale.Name = "rdbbtnMale";
            this.rdbbtnMale.Size = new System.Drawing.Size(86, 30);
            this.rdbbtnMale.TabIndex = 31;
            this.rdbbtnMale.TabStop = true;
            this.rdbbtnMale.Text = "Male";
            this.rdbbtnMale.UseVisualStyleBackColor = false;
            // 
            // txtEmailID
            // 
            this.txtEmailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailID.Location = new System.Drawing.Point(649, 155);
            this.txtEmailID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(516, 30);
            this.txtEmailID.TabIndex = 30;
            this.txtEmailID.CursorChanged += new System.EventHandler(this.txtEmailID_CursorChanged);
            this.txtEmailID.TextChanged += new System.EventHandler(this.txtEmailID_TextChanged);
            this.txtEmailID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailID_KeyPress);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(649, 95);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(516, 30);
            this.txtFullName.TabIndex = 29;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFullName_Validating);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(1308, 356);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 26);
            this.lblCity.TabIndex = 28;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(917, 355);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(64, 26);
            this.lblState.TabIndex = 27;
            this.lblState.Text = "State";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCountry.Location = new System.Drawing.Point(433, 348);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(98, 26);
            this.lblCountry.TabIndex = 26;
            this.lblCountry.Text = "Country";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.BackColor = System.Drawing.Color.Transparent;
            this.lblDob.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblDob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDob.Location = new System.Drawing.Point(433, 297);
            this.lblDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(153, 26);
            this.lblDob.TabIndex = 25;
            this.lblDob.Text = "Date Of Birth";
            this.lblDob.Click += new System.EventHandler(this.lblDob_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblContactNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContactNo.Location = new System.Drawing.Point(433, 244);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(134, 26);
            this.lblContactNo.TabIndex = 24;
            this.lblContactNo.Text = "Contact No.";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGender.Location = new System.Drawing.Point(433, 199);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 26);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Gender";
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailId.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmailId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmailId.Location = new System.Drawing.Point(433, 148);
            this.lblEmailId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(105, 26);
            this.lblEmailId.TabIndex = 22;
            this.lblEmailId.Text = "Email ID";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFullName.Location = new System.Drawing.Point(431, 90);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(119, 26);
            this.lblFullName.TabIndex = 21;
            this.lblFullName.Text = "Full Name";
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.AutoSize = true;
            this.lblPersonalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonalInfo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblPersonalInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPersonalInfo.Location = new System.Drawing.Point(747, 9);
            this.lblPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(266, 31);
            this.lblPersonalInfo.TabIndex = 41;
            this.lblPersonalInfo.Text = "Personal Information";
            // 
            // btnSavePersonalInfo
            // 
            this.btnSavePersonalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSavePersonalInfo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnSavePersonalInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSavePersonalInfo.Location = new System.Drawing.Point(947, 487);
            this.btnSavePersonalInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePersonalInfo.Name = "btnSavePersonalInfo";
            this.btnSavePersonalInfo.Size = new System.Drawing.Size(264, 48);
            this.btnSavePersonalInfo.TabIndex = 42;
            this.btnSavePersonalInfo.Text = "Next ";
            this.btnSavePersonalInfo.UseVisualStyleBackColor = false;
            this.btnSavePersonalInfo.Click += new System.EventHandler(this.btnSavePersonalInfo_Click);
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAddCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCountry.Location = new System.Drawing.Point(824, 353);
            this.lblAddCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(30, 31);
            this.lblAddCountry.TabIndex = 43;
            this.lblAddCountry.Text = "+";
            this.lblAddCountry.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAddState
            // 
            this.lblAddState.AutoSize = true;
            this.lblAddState.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAddState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddState.Location = new System.Drawing.Point(1167, 354);
            this.lblAddState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddState.Name = "lblAddState";
            this.lblAddState.Size = new System.Drawing.Size(30, 31);
            this.lblAddState.TabIndex = 44;
            this.lblAddState.Text = "+";
            this.lblAddState.Click += new System.EventHandler(this.lblAddState_Click);
            // 
            // lblAddCity
            // 
            this.lblAddCity.AutoSize = true;
            this.lblAddCity.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAddCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCity.Location = new System.Drawing.Point(1541, 354);
            this.lblAddCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(30, 31);
            this.lblAddCity.TabIndex = 45;
            this.lblAddCity.Text = "+";
            this.lblAddCity.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnUpdatePI
            // 
            this.btnUpdatePI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnUpdatePI.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdatePI.Location = new System.Drawing.Point(528, 487);
            this.btnUpdatePI.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePI.Name = "btnUpdatePI";
            this.btnUpdatePI.Size = new System.Drawing.Size(317, 48);
            this.btnUpdatePI.TabIndex = 46;
            this.btnUpdatePI.Text = "Update and Next ";
            this.btnUpdatePI.UseVisualStyleBackColor = false;
            this.btnUpdatePI.Click += new System.EventHandler(this.btnUpdatePI_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(1192, 165);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(2, 22);
            this.lblEmailError.TabIndex = 50;
            // 
            // lblCoNOError
            // 
            this.lblCoNOError.AutoSize = true;
            this.lblCoNOError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoNOError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoNOError.ForeColor = System.Drawing.Color.Red;
            this.lblCoNOError.Location = new System.Drawing.Point(1192, 256);
            this.lblCoNOError.Name = "lblCoNOError";
            this.lblCoNOError.Size = new System.Drawing.Size(2, 22);
            this.lblCoNOError.TabIndex = 51;
            // 
            // frmPersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1755, 660);
            this.Controls.Add(this.lblCoNOError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.btnUpdatePI);
            this.Controls.Add(this.lblAddCity);
            this.Controls.Add(this.lblAddState);
            this.Controls.Add(this.lblAddCountry);
            this.Controls.Add(this.btnSavePersonalInfo);
            this.Controls.Add(this.lblPersonalInfo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cmmbxCity);
            this.Controls.Add(this.cmbbxState);
            this.Controls.Add(this.cmbbxCountry);
            this.Controls.Add(this.dateTimeDob);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.rdbbtnOther);
            this.Controls.Add(this.rdbbtnFemale);
            this.Controls.Add(this.rdbbtnMale);
            this.Controls.Add(this.txtEmailID);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.lblFullName);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonalInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonalInformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonalInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmmbxCity;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.ComboBox cmbbxCountry;
        private System.Windows.Forms.DateTimePicker dateTimeDob;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.RadioButton rdbbtnOther;
        private System.Windows.Forms.RadioButton rdbbtnFemale;
        private System.Windows.Forms.RadioButton rdbbtnMale;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Button btnSavePersonalInfo;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblAddState;
        private System.Windows.Forms.Label lblAddCity;
        private System.Windows.Forms.Button btnUpdatePI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCoNOError;
        private System.Windows.Forms.Label lblEmailError;
    }
}