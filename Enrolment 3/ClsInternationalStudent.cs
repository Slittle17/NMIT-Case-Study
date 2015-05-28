using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_3
{
    class ClsInternationalStudent : ClsStudent
    {
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
