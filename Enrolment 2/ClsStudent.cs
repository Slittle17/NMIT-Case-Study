using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_2
{
    public class ClsStudent
    {
        private string _ID;
        private string _Name;
        private DateTime _DOB = DateTime.Today.AddYears(-20);
        private decimal _Balance;

        public string ID
        {
            get { return _ID; }
            set 
            {
                _ID = value;
                //if (!string.IsNullOrEmpty(value.Trim()))
                //    _ID = value;
                //else
                //    throw new Exception("You.............%$%$%#%%@@#$%$%#");
            }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        public decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
        public override string ToString()
        {
            return _ID + "\n" + _Name;
        }
    }
}
