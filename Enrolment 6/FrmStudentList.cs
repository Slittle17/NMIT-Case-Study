using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment_6
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
            lstStudents.DataSource = ClsInstitute.StudentList.Values.ToList<ClsStudent>();
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
                ClsInstitute.StudentList.Add(lcStudent.ID, lcStudent);
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
            ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
            if (lcStudent == null)
                {
                    DialogResult cantDelete = MessageBox.Show("No students exist to delete", "Delete Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (cantDelete == DialogResult.OK)
                    {
                        return;
                    }
                }
            DialogResult deleteStudent = MessageBox.Show("You are about to delete a student, are you sure?", "Delete Student",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (deleteStudent == DialogResult.Yes)
            {
                removeStudent();
            }
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent;
            if (ClsInstitute.StudentList.TryGetValue(txtStudentID.Text,out lcStudent))
            {
                lstStudents.SelectedItem = lcStudent;
            }
            else if (lcStudent == null)
            {
                DialogResult emptyList = MessageBox.Show("No student(s) exist, would you like to create one now?", "Find Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (emptyList == DialogResult.Yes)
                {
                    createStudent();
                }
            }
        }

        private void removeStudent()
        {
            ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedItem;
            {
                ClsInstitute.StudentList.Remove(lcStudent.ID);
                updateDisplay();
            }
        }
    }
}
