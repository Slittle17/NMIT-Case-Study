namespace Enrolment_6
{
    partial class FrmMOEStudent
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
            this.lblLoanAmt = new System.Windows.Forms.Label();
            this.lblFullTime = new System.Windows.Forms.Label();
            this.chkFullTime = new System.Windows.Forms.CheckBox();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLoanAmt
            // 
            this.lblLoanAmt.AutoSize = true;
            this.lblLoanAmt.Location = new System.Drawing.Point(34, 125);
            this.lblLoanAmt.Name = "lblLoanAmt";
            this.lblLoanAmt.Size = new System.Drawing.Size(61, 13);
            this.lblLoanAmt.TabIndex = 13;
            this.lblLoanAmt.Text = "Loan Amt $";
            // 
            // lblFullTime
            // 
            this.lblFullTime.AutoSize = true;
            this.lblFullTime.Location = new System.Drawing.Point(46, 148);
            this.lblFullTime.Name = "lblFullTime";
            this.lblFullTime.Size = new System.Drawing.Size(49, 13);
            this.lblFullTime.TabIndex = 14;
            this.lblFullTime.Text = "Full Time";
            // 
            // chkFullTime
            // 
            this.chkFullTime.AutoSize = true;
            this.chkFullTime.Location = new System.Drawing.Point(101, 148);
            this.chkFullTime.Name = "chkFullTime";
            this.chkFullTime.Size = new System.Drawing.Size(15, 14);
            this.chkFullTime.TabIndex = 15;
            this.chkFullTime.UseVisualStyleBackColor = true;
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(101, 122);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(100, 20);
            this.txtLoan.TabIndex = 16;
            // 
            // FrmMOEStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.chkFullTime);
            this.Controls.Add(this.lblFullTime);
            this.Controls.Add(this.lblLoanAmt);
            this.Name = "FrmMOEStudent";
            this.Text = "MOE Student";
            this.Controls.SetChildIndex(this.lblLoanAmt, 0);
            this.Controls.SetChildIndex(this.lblFullTime, 0);
            this.Controls.SetChildIndex(this.chkFullTime, 0);
            this.Controls.SetChildIndex(this.txtLoan, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmt;
        private System.Windows.Forms.Label lblFullTime;
        private System.Windows.Forms.CheckBox chkFullTime;
        private System.Windows.Forms.TextBox txtLoan;
    }
}
