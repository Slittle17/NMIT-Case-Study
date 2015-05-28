﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_6
{
    class ClsInternationalStudent : ClsStudent
    {
        private static FrmInternationalStudent _Form = new FrmInternationalStudent();

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        protected override string typeOfStudent()
        {
            return "Intl";
        }

        private string _Country;
        private float _IELTS_Score;

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public float IELTS_Score
        {
            get { return _IELTS_Score; }
            set { _IELTS_Score = value; }
        }
    }
}
