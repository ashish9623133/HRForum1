namespace GayaSoftHRForum
{
    partial class frmAddCity
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
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddState = new System.Windows.Forms.Label();
            this.cmbbxStateAddCity = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.btnSaveCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(43, 178);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(116, 27);
            this.lblCity.TabIndex = 39;
            this.lblCity.Text = "City Name";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // lblAddState
            // 
            this.lblAddState.AutoSize = true;
            this.lblAddState.BackColor = System.Drawing.Color.Transparent;
            this.lblAddState.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblAddState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddState.Location = new System.Drawing.Point(151, 40);
            this.lblAddState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddState.Name = "lblAddState";
            this.lblAddState.Size = new System.Drawing.Size(120, 31);
            this.lblAddState.TabIndex = 41;
            this.lblAddState.Text = "Add City";
            // 
            // cmbbxStateAddCity
            // 
            this.cmbbxStateAddCity.FormattingEnabled = true;
            this.cmbbxStateAddCity.Location = new System.Drawing.Point(175, 109);
            this.cmbbxStateAddCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxStateAddCity.Name = "cmbbxStateAddCity";
            this.cmbbxStateAddCity.Size = new System.Drawing.Size(213, 24);
            this.cmbbxStateAddCity.TabIndex = 43;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(43, 109);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 27);
            this.lblState.TabIndex = 42;
            this.lblState.Text = "State";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(175, 183);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(213, 22);
            this.txtCityName.TabIndex = 44;
            // 
            // btnSaveCity
            // 
            this.btnSaveCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSaveCity.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnSaveCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveCity.Location = new System.Drawing.Point(157, 233);
            this.btnSaveCity.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCity.Name = "btnSaveCity";
            this.btnSaveCity.Size = new System.Drawing.Size(102, 52);
            this.btnSaveCity.TabIndex = 45;
            this.btnSaveCity.Text = "Save";
            this.btnSaveCity.UseVisualStyleBackColor = false;
            this.btnSaveCity.Click += new System.EventHandler(this.btnSaveCity_Click);
            // 
            // frmAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(427, 298);
            this.Controls.Add(this.btnSaveCity);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.cmbbxStateAddCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAddState);
            this.Controls.Add(this.lblCity);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddCity";
            this.Text = "frmAddCity";
            this.Load += new System.EventHandler(this.frmAddCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddState;
        private System.Windows.Forms.ComboBox cmbbxStateAddCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnSaveCity;
    }
}