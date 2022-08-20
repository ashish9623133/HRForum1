namespace GayaSoftHRForum
{
    partial class frmAddCountry
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
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnSaveCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCountry.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblAddCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddCountry.Location = new System.Drawing.Point(119, 9);
            this.lblAddCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(168, 31);
            this.lblAddCountry.TabIndex = 0;
            this.lblAddCountry.Text = "Add Country";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCountryName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCountryName.Location = new System.Drawing.Point(13, 82);
            this.lblCountryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(154, 27);
            this.lblCountryName.TabIndex = 1;
            this.lblCountryName.Text = "Country Name";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(197, 86);
            this.txtCountryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(175, 22);
            this.txtCountryName.TabIndex = 2;
            // 
            // btnSaveCountry
            // 
            this.btnSaveCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSaveCountry.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btnSaveCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveCountry.Location = new System.Drawing.Point(143, 150);
            this.btnSaveCountry.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCountry.Name = "btnSaveCountry";
            this.btnSaveCountry.Size = new System.Drawing.Size(107, 35);
            this.btnSaveCountry.TabIndex = 46;
            this.btnSaveCountry.Text = "Save";
            this.btnSaveCountry.UseVisualStyleBackColor = false;
            this.btnSaveCountry.Click += new System.EventHandler(this.btnSaveCountry_Click);
            // 
            // frmAddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(401, 208);
            this.Controls.Add(this.btnSaveCountry);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblAddCountry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Button btnSaveCountry;
    }
}