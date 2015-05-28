using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_7
{
    [Serializable]
    class ClsMOEStudent : ClsStudent
    {
        private static FrmMOEStudent _Form = new FrmMOEStudent();

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        protected override string typeOfStudent()
        {
            return "MOE";
        }

        private decimal _LoanAmount;
        private bool _FullTime;

        public decimal LoanAmount
        {
            get { return _LoanAmount; }
            set { _LoanAmount = value; }
        }

        public bool FullTime
        {
            get { return _FullTime; }
            set { _FullTime = value; }
        }
    }
}
