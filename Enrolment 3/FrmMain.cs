using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_3
{
    public partial class FrmMain : Form
    {
        private ClsStudent _Student;
        private FrmStudent _StudentForm;
        private FrmStudent _MOEStudentForm = new FrmMOEStudent();
        private FrmStudent _IntStudentForm = new FrmInternationalStudent();
        private FrmStudent _TOPStudentForm = new FrmTOPStudent();
        private string[] _StudentType = { "MOE (local)", "International", "TOP" };

        public FrmMain()
        {
            InitializeComponent();
            cboStudentType.DataSource = _StudentType;
            cboStudentType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            createStudent();
        }

        private void editStudent()
        {
            if (_Student != null &&
                _StudentForm.ShowDialog(_Student) == DialogResult.OK)
            {
                lblStudent.Text = "Student:\n" + _Student.ToString();
            }
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            if (_Student != null)
            {
                editStudent();
            }
            else
            {
                DialogResult noStudent = MessageBox.Show("Student doesn't exist would you like to create one now?", "Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (noStudent == DialogResult.Yes)
                {
                    createStudent();
                }
                else
                {
                    Close();
                }
            }
        }

        private void createStudent()
        {
            if (cboStudentType.SelectedIndex == 0)
            {
                _StudentForm = _MOEStudentForm;
                _Student = new ClsMOEStudent();
            }
            if (cboStudentType.SelectedIndex == 1)
            {
                _StudentForm = _IntStudentForm;
                _Student = new ClsInternationalStudent();
            }
            if (cboStudentType.SelectedIndex == 2)
            {
                _StudentForm = _TOPStudentForm;
                _Student = new ClsTOPStudent();
            }
            //_Student = new ClsStudent();
            editStudent();
        }
    }
}
