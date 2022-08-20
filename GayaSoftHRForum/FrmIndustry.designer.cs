namespace GayaSoftHRForum
{
    partial class FrmIndustry
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
            this.txtAddIndustry = new System.Windows.Forms.TextBox();
            this.btnSaveIndustry = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddIndustry
            // 
            this.txtAddIndustry.Location = new System.Drawing.Point(210, 62);
            this.txtAddIndustry.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddIndustry.Name = "txtAddIndustry";
            this.txtAddIndustry.Size = new System.Drawing.Size(220, 22);
            this.txtAddIndustry.TabIndex = 0;
            // 
            // btnSaveIndustry
            // 
            this.btnSaveIndustry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSaveIndustry.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnSaveIndustry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveIndustry.Location = new System.Drawing.Point(85, 112);
            this.btnSaveIndustry.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveIndustry.Name = "btnSaveIndustry";
            this.btnSaveIndustry.Size = new System.Drawing.Size(100, 38);
            this.btnSaveIndustry.TabIndex = 1;
            this.btnSaveIndustry.Text = "Save";
            this.btnSaveIndustry.UseVisualStyleBackColor = false;
            this.btnSaveIndustry.Click += new System.EventHandler(this.btnSaveIndustry_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(270, 112);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Industry";
            // 
            // FrmIndustry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(460, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveIndustry);
            this.Controls.Add(this.txtAddIndustry);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIndustry";
            this.Text = "FrmIndustry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddIndustry;
        private System.Windows.Forms.Button btnSaveIndustry;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}