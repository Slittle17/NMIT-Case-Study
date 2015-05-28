using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_8
{
    [Serializable]
    class ClsTOPStudent : ClsStudent
    {
        private static FrmTOPStudent _Form = new FrmTOPStudent();

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        protected override string typeOfStudent()
        {
            return "TOP";
        }

        private string _ReferralAgency;

        public string ReferralAgency
        {
            get { return _ReferralAgency; }
            set { _ReferralAgency = value; }
        }
    }
}
