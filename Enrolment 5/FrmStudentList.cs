using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_5
{
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
            cboStudentType.DataSource = ClsStudent.StudentType;
            cboStudentType.SelectedIndex = 0;
        }

        private void updateDisplay()
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = ClsInstitute.StudentList;
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            createStudent();
        }

        private void createStudent()
        {
            ClsStudent lcStudent = ClsStudent.NewStudent(cboStudentType.SelectedIndex);
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                ClsInstitute.StudentList.Add(lcStudent);
                updateDisplay();
            }
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
            if (lcStudent != null)
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
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editStudent()
        {
            ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                updateDisplay();
            }
        }

        private void lstStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteStudent = MessageBox.Show("You are about to delete a student, are you sure?", "Delete Student",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteStudent == DialogResult.Yes)
            {
                removeStudent();
            }
        }

        private void removeStudent()
        {
            ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
            {
                ClsInstitute.StudentList.Remove(lcStudent);
                updateDisplay();
            }
        }
    }
}
