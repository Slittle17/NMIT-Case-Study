using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_4
{
    class ClsTOPStudent : ClsStudent
    {
        private static FrmTOPStudent _Form = new FrmTOPStudent();

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        private string _ReferralAgency;

        public string ReferralAgency
        {
            get { return _ReferralAgency; }
            set { _ReferralAgency = value; }
        }
    }
}
