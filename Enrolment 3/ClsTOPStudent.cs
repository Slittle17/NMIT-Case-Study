using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_3
{
    class ClsTOPStudent : ClsStudent
    {
        private string _ReferralAgency;

        public string ReferralAgency
        {
            get { return _ReferralAgency; }
            set { _ReferralAgency = value; }
        }
    }
}
