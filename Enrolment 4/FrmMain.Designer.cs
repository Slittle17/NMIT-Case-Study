namespace Enrolment_4
{
    partial class FrmMain
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
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnModifyStudent = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboStudentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(12, 12);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(93, 23);
            this.btnCreateStudent.TabIndex = 0;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.Location = new System.Drawing.Point(12, 41);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(93, 23);
            this.btnModifyStudent.TabIndex = 1;
            this.btnModifyStudent.Text = "Modify Student";
            this.btnModifyStudent.UseVisualStyleBackColor = true;
            this.btnModifyStudent.Click += new System.EventHandler(this.btnModifyStudent_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(12, 155);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(161, 94);
            this.lblStudent.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboStudentType
            // 
            this.cboStudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentType.FormattingEnabled = true;
            this.cboStudentType.Location = new System.Drawing.Point(151, 14);
            this.cboStudentType.Name = "cboStudentType";
            this.cboStudentType.Size = new System.Drawing.Size(121, 21);
            this.cboStudentType.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cboStudentType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnModifyStudent);
            this.Controls.Add(this.btnCreateStudent);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnModifyStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboStudentType;
    }
}

