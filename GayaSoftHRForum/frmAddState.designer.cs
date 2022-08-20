namespace GayaSoftHRForum
{
    partial class frmAddState
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
            this.lblAddState = new System.Windows.Forms.Label();
            this.lblStateName = new System.Windows.Forms.Label();
            this.cmbbxCountryAddState = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtAddState = new System.Windows.Forms.TextBox();
            this.btnSaveState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddState
            // 
            this.lblAddState.AutoSize = true;
            this.lblAddState.BackColor = System.Drawing.Color.Transparent;
            this.lblAddState.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddState.Location = new System.Drawing.Point(97, 20);
            this.lblAddState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddState.Name = "lblAddState";
            this.lblAddState.Size = new System.Drawing.Size(129, 31);
            this.lblAddState.TabIndex = 0;
            this.lblAddState.Text = "Add State";
            this.lblAddState.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStateName
            // 
            this.lblStateName.AutoSize = true;
            this.lblStateName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStateName.Location = new System.Drawing.Point(16, 145);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(129, 25);
            this.lblStateName.TabIndex = 1;
            this.lblStateName.Text = "State Name";
            // 
            // cmbbxCountryAddState
            // 
            this.cmbbxCountryAddState.FormattingEnabled = true;
            this.cmbbxCountryAddState.Location = new System.Drawing.Point(160, 84);
            this.cmbbxCountryAddState.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxCountryAddState.Name = "cmbbxCountryAddState";
            this.cmbbxCountryAddState.Size = new System.Drawing.Size(160, 24);
            this.cmbbxCountryAddState.TabIndex = 38;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCountry.Location = new System.Drawing.Point(16, 84);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(98, 26);
            this.lblCountry.TabIndex = 37;
            this.lblCountry.Text = "Country";
            // 
            // txtAddState
            // 
            this.txtAddState.Location = new System.Drawing.Point(160, 145);
            this.txtAddState.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddState.Name = "txtAddState";
            this.txtAddState.Size = new System.Drawing.Size(160, 22);
            this.txtAddState.TabIndex = 39;
            // 
            // btnSaveState
            // 
            this.btnSaveState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSaveState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveState.Location = new System.Drawing.Point(105, 194);
            this.btnSaveState.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveState.Name = "btnSaveState";
            this.btnSaveState.Size = new System.Drawing.Size(121, 39);
            this.btnSaveState.TabIndex = 40;
            this.btnSaveState.Text = "Save";
            this.btnSaveState.UseVisualStyleBackColor = false;
            this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // frmAddState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(360, 255);
            this.Controls.Add(this.btnSaveState);
            this.Controls.Add(this.txtAddState);
            this.Controls.Add(this.cmbbxCountryAddState);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblStateName);
            this.Controls.Add(this.lblAddState);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddState";
            this.Text = "frmAddState";
            this.Load += new System.EventHandler(this.frmAddState_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddState;
        private System.Windows.Forms.Label lblStateName;
        private System.Windows.Forms.ComboBox cmbbxCountryAddState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtAddState;
        private System.Windows.Forms.Button btnSaveState;
    }
}