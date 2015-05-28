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
    public partial class FrmStudentList : Form
    {
        
        public FrmStudentList()
        {
            InitializeComponent();
            cboStudentType.DataSource = ClsStudent.StudentType;
            cboStudentType.SelectedIndex = 0;
            cboSortChoice.DataSource = _SortStrings;
            cboSortChoice.SelectedIndex = 0;
        }
        
        class clsDOBComparer : IComparer<ClsStudent>
        {
            public int Compare(ClsStudent prStudentX, ClsStudent prStudentY)
            {
                return prStudentX.DOB.Date.CompareTo(prStudentY.DOB.Date);
            }
        }

        class clsNameComparer : IComparer<ClsStudent>
        {
            public int Compare(ClsStudent prStudentX, ClsStudent prStudentY)
            {
                return prStudentX.Name.CompareTo(prStudentY.Name);
            }
        }

        private IComparer<ClsStudent>[] _Comparer = { new clsNameComparer(), new clsDOBComparer() };

        private readonly string[] _SortStrings = { "Name", "DOB" };

        private void updateDisplay()
        {
            List<ClsStudent> lcStudentList = ClsInstitute.StudentList.Values.ToList();
            lcStudentList.Sort(_Comparer[cboSortChoice.SelectedIndex]);
            lstStudents.DataSource = lcStudentList;
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
            else
            {
                DialogResult deleteStudent = MessageBox.Show("You are about to delete a student, are you sure?", "Delete Student",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteStudent == DialogResult.Yes)
                {
                    removeStudent();
                }
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
                DialogResult emptyList = MessageBox.Show("Student doesn't exist, would you like to create one now?", "Find Error",
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

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void cboSortChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
