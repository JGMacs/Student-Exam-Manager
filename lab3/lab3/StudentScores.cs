using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class frmStudentScores : Form
    {
        private static string selectedStudentName;
        private static IList<int> selectedStudentGrades;

        //Default constructor
        public frmStudentScores()
        {
            InitializeComponent();
        }

        private void lblScoretotal_Click(object sender, EventArgs e)
        {

        }

        //Populates listbox and updates totals on form load
        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            FileManager.TestStudents();

            IList<string> names = FileManager.NameList;

            lbStudents.DataSource = names;

            lbStudents.Update();

            Calculator();
        }

        //Populates listbox and updates totals on form enter
        private void frmStudentScores_Enter(object sender, EventArgs e)
        {
            IList<string> names = FileManager.NameList;

            lbStudents.DataSource = names;

            lbStudents.Update();

            Calculator();
        }

        //Updates total boxes
        private void Calculator()
        {
            int _total = 0;
            int _average = 0;
            int _count = 0;

            try {
                IList<int> _gradesList = FileManager.StudentList[lbStudents.SelectedIndex].GradesList;

                _count = _gradesList.Count;

                for (int i = 0; i <= _gradesList.Count; i++)
                {
                    _total += _gradesList[i];
                }
            } catch {

            }

            try { _average = _total / _count; } catch { }

            tbTotal.Text = "" + _total;

            tbAverage.Text = "" + _average;

            tbCount.Text = "" + _count;
        }

        //Getter function for currently selected student's name
        public static string GetName
        {
            get { return selectedStudentName; }
        }

        //Getter function for list of currently selected student's grades
        public static IList<int> GetGrades
        {
            get { return selectedStudentGrades; }
        }

        //Listener function to maintain currently selected student info
        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculator();

            try {
                selectedStudentName = FileManager.StudentList[lbStudents.SelectedIndex].GetName();

                selectedStudentGrades = FileManager.StudentList[lbStudents.SelectedIndex].GradesList;
            } catch { }
        }

/**** Button Listeners ****/

        //Function to add new student - calls "Add New Student" form
        private void btAddnew_Click(object sender, EventArgs e)
        {
            frmAddNewStudent newStudent = new frmAddNewStudent();

            newStudent.Activate();
            newStudent.Show();
        }

        //Function to update selected student's profile - calls "Update Student Scores" form
        private void btUpdate_Click(object sender, EventArgs e)
        {
            try {
                selectedStudentName = FileManager.StudentList[lbStudents.SelectedIndex].GetName();

                selectedStudentGrades = FileManager.StudentList[lbStudents.SelectedIndex].GradesList;

                frmUpdateStudentScores studentScoresUpdate = new frmUpdateStudentScores(
                        lbStudents.SelectedIndex, selectedStudentName);

                studentScoresUpdate.Activate();
                studentScoresUpdate.ShowDialog();
            } catch {
                MessageBox.Show("No student selected; please select a student to update", "Error");
            }
        }

        //Function to delete student's profile - calls "File Manager" class
        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete;

            if (lbStudents.SelectedIndex >= 0)
            {
               delete  = MessageBox.Show("Are you sure you want to permanently delete this record?", "WARNING!", MessageBoxButtons.YesNo);

                if (delete == DialogResult.Yes)
                {
                    try
                    {
                        FileManager.StudentList.RemoveAt(lbStudents.SelectedIndex);
                        FileManager.NameList.RemoveAt(lbStudents.SelectedIndex);

                        lbStudents.DataSource = null;

                        IList<string> names = FileManager.NameList;

                        lbStudents.DataSource = names;
                        lbStudents.Update();
                    }
                    catch
                    {
                        MessageBox.Show("No student selected; please select a student to delete", "Error");
                    }
                }
            }
            else
                { MessageBox.Show("No student selected; please select a student to delete", "Error"); }
        }

        //Function to exit application when exit is clicked
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
