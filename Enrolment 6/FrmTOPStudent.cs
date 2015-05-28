using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrolment_6
{
    public partial class FrmTOPStudent : Enrolment_6.FrmStudent
    {
        public FrmTOPStudent()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsTOPStudent lcStudent = (ClsTOPStudent)_Student;
            txtReferralAgency.Text = lcStudent.ReferralAgency;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsTOPStudent lcStudent = (ClsTOPStudent)_Student;
            lcStudent.ReferralAgency = txtReferralAgency.Text;
        }
    }
}
