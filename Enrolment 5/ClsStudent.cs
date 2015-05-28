using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_5
{
    public abstract class ClsStudent
    {
        public static readonly string[] StudentType = { "MOE (local)", "International", "TOP" };
        
        public static ClsStudent NewStudent(int prChoice)
        {
            if (prChoice == 0)
                return new ClsMOEStudent();
            else if (prChoice == 1)
                return new ClsInternationalStudent();
            else
                return new ClsTOPStudent();
        }

        public abstract bool ViewEdit();

        protected abstract string typeOfStudent();

        private string _ID;
        private string _Name;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
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
            return _ID + "\t" + _Name + "\t" + typeOfStudent();
        }
    }
}
