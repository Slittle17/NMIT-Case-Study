namespace Enrolment_3
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
            this.lblReferralAgency = new System.Windows.Forms.Label();
            this.txtReferralAgency = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblReferralAgency
            // 
            this.lblReferralAgency.AutoSize = true;
            this.lblReferralAgency.Location = new System.Drawing.Point(-5, 125);
            this.lblReferralAgency.Name = "lblReferralAgency";
            this.lblReferralAgency.Size = new System.Drawing.Size(83, 13);
            this.lblReferralAgency.TabIndex = 17;
            this.lblReferralAgency.Text = "Referral Agency";
            // 
            // txtReferralAgency
            // 
            this.txtReferralAgency.Location = new System.Drawing.Point(84, 122);
            this.txtReferralAgency.Name = "txtReferralAgency";
            this.txtReferralAgency.Size = new System.Drawing.Size(100, 20);
            this.txtReferralAgency.TabIndex = 18;
            // 
            // FrmTOPStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.txtReferralAgency);
            this.Controls.Add(this.lblReferralAgency);
            this.Name = "FrmTOPStudent";
            this.Controls.SetChildIndex(this.lblReferralAgency, 0);
            this.Controls.SetChildIndex(this.txtReferralAgency, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReferralAgency;
        private System.Windows.Forms.TextBox txtReferralAgency;
    }
}
