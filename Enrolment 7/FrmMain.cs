using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_7
{
    public partial class FrmMain : Form
    {
        //private ClsStudent _Student;
        //private FrmStudent _StudentForm;
        //private FrmStudent _MOEStudentForm = new FrmMOEStudent();
        //private FrmStudent _IntStudentForm = new FrmInternationalStudent();
        //private FrmStudent _TOPStudentForm = new FrmTOPStudent();
        private FrmStudentList _StudentListForm = new FrmStudentList();

        public FrmMain()
        {
            InitializeComponent();
            try 
	        {
                ClsInstitute.Retrieve();
                updateTotalStudents();
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
	        }
        }

        private void updateTotalStudents()
        {
            lblStudent.Text = string.Format("{0} Student(s)\nTotal Balance: {1:C}",
                ClsInstitute.StudentList.Count, ClsInstitute.TotalBalance());
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            _StudentListForm.ShowDialog();
            updateTotalStudents();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClsInstitute.Save();
            Close();
        }

    //    private void btnCreateStudent_Click(object sender, EventArgs e)
    //    {
    //        createStudent();
    //    }

    //    private void editStudent(ClsStudent prStudent)
    //    {
    //        if (prStudent != null && prStudent.ViewEdit())
    //        {
    //            _Student = prStudent;
    //            lblStudent.Text = "Student:\n" + _Student.ToString();
    //        }
    //    }

    //    private void btnModifyStudent_Click(object sender, EventArgs e)
    //    {
    //        if (_Student != null)
    //        {
    //            editStudent(_Student);
    //        }
    //        else
    //        {
    //            DialogResult noStudent = MessageBox.Show("Student doesn't exist would you like to create one now?", "Error",
    //                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
    //            if (noStudent == DialogResult.Yes)
    //            {
    //                createStudent();
    //            }
    //            else
    //            {
    //                Close();
    //            }
    //        }
    //    }

    //    private void createStudent()
    //    {
    //        ClsStudent lcStudent = ClsStudent.NewStudent(cboStudentType.SelectedIndex);
    //        editStudent(lcStudent);
    //    }
    }
}
