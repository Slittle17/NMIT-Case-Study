using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_8
{
    public partial class FrmStudent : Form
    {
        protected ClsStudent _Student;

        public FrmStudent()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsStudent prStudent)
        {
            _Student = prStudent;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void updateDisplay()
        {
            txtID.Text = _Student.ID;
            txtName.Text = _Student.Name;
            dtpDOB.Value = _Student.DOB;
            txtBalance.Text = Convert.ToString(_Student.Balance);
            txtID.Enabled = String.IsNullOrEmpty(_Student.ID);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtID.Enabled && ClsInstitute.StudentList.ContainsKey(txtID.Text))
                MessageBox.Show("Student with that ID already exists", "Duplicate ID");
            else
            {
                pushData();
                DialogResult = DialogResult.OK;
            }
            
        }

        protected virtual void pushData()
        {
            _Student.ID = txtID.Text;
            _Student.Name = txtName.Text;
            _Student.DOB = dtpDOB.Value;
            _Student.Balance = Convert.ToDecimal(txtBalance.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
