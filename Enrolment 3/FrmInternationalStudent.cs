using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrolment_3
{
    public partial class FrmInternationalStudent : Enrolment_3.FrmStudent
    {
        public FrmInternationalStudent()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            txtCountry.Text = lcStudent.Country;
            txtIELTS.Text = Convert.ToString(lcStudent.IELTS_Score);
        }

        protected override void pushData()
        {
            base.pushData();
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            lcStudent.Country = txtCountry.Text;
            lcStudent.IELTS_Score = float.Parse(txtIELTS.Text);
            //lcStudent.IELTS_Score = Convert.ToSingle(txtIELTS.Text);
        }
    }
}
