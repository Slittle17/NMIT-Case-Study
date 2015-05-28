namespace Enrolment_7
{
    partial class FrmTOPStudent
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
            this.txtReferralAgency = new System.Windows.Forms.TextBox();
            this.lblReferralAgency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReferralAgency
            // 
            this.txtReferralAgency.Location = new System.Drawing.Point(101, 122);
            this.txtReferralAgency.Name = "txtReferralAgency";
            this.txtReferralAgency.Size = new System.Drawing.Size(100, 20);
            this.txtReferralAgency.TabIndex = 13;
            // 
            // lblReferralAgency
            // 
            this.lblReferralAgency.AutoSize = true;
            this.lblReferralAgency.Location = new System.Drawing.Point(12, 125);
            this.lblReferralAgency.Name = "lblReferralAgency";
            this.lblReferralAgency.Size = new System.Drawing.Size(83, 13);
            this.lblReferralAgency.TabIndex = 16;
            this.lblReferralAgency.Text = "Referral Agency";
            // 
            // FrmTOPStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.lblReferralAgency);
            this.Controls.Add(this.txtReferralAgency);
            this.Name = "FrmTOPStudent";
            this.Text = "TOP Student";
            this.Controls.SetChildIndex(this.txtReferralAgency, 0);
            this.Controls.SetChildIndex(this.lblReferralAgency, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReferralAgency;
        private System.Windows.Forms.Label lblReferralAgency;
    }
}
