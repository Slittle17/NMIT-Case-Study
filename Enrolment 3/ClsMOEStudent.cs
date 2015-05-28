using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_3
{
    class ClsMOEStudent : ClsStudent
    {
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
