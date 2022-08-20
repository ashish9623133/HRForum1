namespace GayaSoftHRForum
{
    partial class FrmAdminCompany
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
            this.lblAcc = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanySize = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanySize = new System.Windows.Forms.TextBox();
            this.cmbTimeZone = new System.Windows.Forms.ComboBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAcc.Location = new System.Drawing.Point(608, 139);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(437, 35);
            this.lblAcc.TabIndex = 0;
            this.lblAcc.Text = "Setup Account and Finish Signup";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCompanyName.Location = new System.Drawing.Point(591, 217);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(155, 23);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name :";
            // 
            // lblCompanySize
            // 
            this.lblCompanySize.AutoSize = true;
            this.lblCompanySize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanySize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCompanySize.Location = new System.Drawing.Point(591, 316);
            this.lblCompanySize.Name = "lblCompanySize";
            this.lblCompanySize.Size = new System.Drawing.Size(142, 23);
            this.lblCompanySize.TabIndex = 2;
            this.lblCompanySize.Text = "Company Size :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(591, 402);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(169, 23);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Select Time Zone :";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrency.Location = new System.Drawing.Point(591, 487);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(158, 23);
            this.lblCurrency.TabIndex = 4;
            this.lblCurrency.Text = "Select Currency :";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(913, 217);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(174, 22);
            this.txtCompanyName.TabIndex = 7;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // txtCompanySize
            // 
            this.txtCompanySize.Location = new System.Drawing.Point(913, 310);
            this.txtCompanySize.Name = "txtCompanySize";
            this.txtCompanySize.Size = new System.Drawing.Size(174, 22);
            this.txtCompanySize.TabIndex = 8;
            this.txtCompanySize.TextChanged += new System.EventHandler(this.txtCompanySize_TextChanged);
            // 
            // cmbTimeZone
            // 
            this.cmbTimeZone.FormattingEnabled = true;
            this.cmbTimeZone.Location = new System.Drawing.Point(913, 394);
            this.cmbTimeZone.Name = "cmbTimeZone";
            this.cmbTimeZone.Size = new System.Drawing.Size(174, 24);
            this.cmbTimeZone.TabIndex = 9;
            this.cmbTimeZone.SelectedIndexChanged += new System.EventHandler(this.cmbTimeZone_SelectedIndexChanged);
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(913, 479);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(174, 24);
            this.cmbCurrency.TabIndex = 10;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(770, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmAdminCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1341, 722);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.cmbTimeZone);
            this.Controls.Add(this.txtCompanySize);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCompanySize);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblAcc);
            this.Name = "FrmAdminCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminCompany";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanySize;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanySize;
        private System.Windows.Forms.ComboBox cmbTimeZone;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Button btnSave;
    }
}

