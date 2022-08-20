namespace GayaSoftHRForum
{
    partial class frmAddJobStream
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblJobstream = new System.Windows.Forms.Label();
            this.txtJobStreamName = new System.Windows.Forms.TextBox();
            this.btnSaveJobStream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Job Stream";
            // 
            // lblJobstream
            // 
            this.lblJobstream.AutoSize = true;
            this.lblJobstream.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobstream.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJobstream.Location = new System.Drawing.Point(13, 91);
            this.lblJobstream.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobstream.Name = "lblJobstream";
            this.lblJobstream.Size = new System.Drawing.Size(129, 26);
            this.lblJobstream.TabIndex = 1;
            this.lblJobstream.Text = "Job Stream";
            // 
            // txtJobStreamName
            // 
            this.txtJobStreamName.Location = new System.Drawing.Point(182, 95);
            this.txtJobStreamName.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobStreamName.Name = "txtJobStreamName";
            this.txtJobStreamName.Size = new System.Drawing.Size(144, 22);
            this.txtJobStreamName.TabIndex = 2;
            // 
            // btnSaveJobStream
            // 
            this.btnSaveJobStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSaveJobStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveJobStream.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveJobStream.Location = new System.Drawing.Point(117, 146);
            this.btnSaveJobStream.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveJobStream.Name = "btnSaveJobStream";
            this.btnSaveJobStream.Size = new System.Drawing.Size(105, 43);
            this.btnSaveJobStream.TabIndex = 41;
            this.btnSaveJobStream.Text = "Save";
            this.btnSaveJobStream.UseVisualStyleBackColor = false;
            this.btnSaveJobStream.Click += new System.EventHandler(this.btnSaveJobStream_Click);
            // 
            // frmAddJobStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(353, 202);
            this.Controls.Add(this.btnSaveJobStream);
            this.Controls.Add(this.txtJobStreamName);
            this.Controls.Add(this.lblJobstream);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddJobStream";
            this.Text = "frmAddJobStream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJobstream;
        private System.Windows.Forms.TextBox txtJobStreamName;
        private System.Windows.Forms.Button btnSaveJobStream;
    }
}