namespace GayaSoftHRForum
{
    partial class Frm_DashBoard
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnLineUp = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 87);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnCompany);
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.btnLineUp);
            this.panel1.Controls.Add(this.btnCandidate);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 675);
            this.panel1.TabIndex = 2;
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCompany.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompany.Location = new System.Drawing.Point(8, 549);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(183, 41);
            this.btnCompany.TabIndex = 4;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = false;
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnContact.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Location = new System.Drawing.Point(8, 474);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(183, 41);
            this.btnContact.TabIndex = 5;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = false;
            // 
            // btnLineUp
            // 
            this.btnLineUp.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnLineUp.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnLineUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLineUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLineUp.Location = new System.Drawing.Point(8, 399);
            this.btnLineUp.Name = "btnLineUp";
            this.btnLineUp.Size = new System.Drawing.Size(183, 41);
            this.btnLineUp.TabIndex = 6;
            this.btnLineUp.Text = "Line Up";
            this.btnLineUp.UseVisualStyleBackColor = false;
            // 
            // btnCandidate
            // 
            this.btnCandidate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCandidate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnCandidate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCandidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidate.Location = new System.Drawing.Point(8, 317);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(183, 41);
            this.btnCandidate.TabIndex = 7;
            this.btnCandidate.Text = "Candidate";
            this.btnCandidate.UseVisualStyleBackColor = false;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDashBoard.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(8, 236);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(183, 41);
            this.btnDashBoard.TabIndex = 2;
            this.btnDashBoard.Text = "Dash Board";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            // 
            // Frm_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 675);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_DashBoard";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnLineUp;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Button btnDashBoard;
    }
}

