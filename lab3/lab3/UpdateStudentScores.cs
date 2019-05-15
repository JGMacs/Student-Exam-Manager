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
    public partial class frmUpdateStudentScores : Form
    {
        int index;

        //Default constructor
        public frmUpdateStudentScores()
        {
            InitializeComponent();
        }

        //Constructor to populate controls
        public frmUpdateStudentScores(int index, string name)
        {
            InitializeComponent();

            this.index = index;

            tbName.Clear();
            tbName.AppendText(name);

            lbScores.DataSource = FileManager.StudentList[index].GradesList;
        }

        //Populates listbox on form load
        private void frmUpdateStudentScores_Load(object sender, EventArgs e)
        {
            IList<int> grade = FileManager.StudentList[index].GradesList;

            lbScores.DataSource = grade;
            lbScores.Update();
        }

        //Populates listbox on form enter
        private void frmUpdateStudentScores_Enter(object sender, EventArgs e)
        {
            IList<int> grade = FileManager.StudentList[index].GradesList;

            lbScores.DataSource = grade;
            lbScores.Update();
        }

        //Function to add new score - calls "New Score" form
        private void btAdd_Click(object sender, EventArgs e)
        {
            frmNewScore newScore = new frmNewScore(index);

            newScore.Activate();
            newScore.ShowDialog();
        }

        //Function to update score - calls "Update Score" form
        private void btUpdate_Click(object sender, EventArgs e)
        {
            int selectedGrade = lbScores.SelectedIndex;

            frmUpdateScore updateScore = new frmUpdateScore(index, selectedGrade);

            updateScore.Activate();
            updateScore.ShowDialog();
        }

        //Function to delete score
        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lbScores.SelectedIndex >= 0)
            {
                DialogResult delete = MessageBox.Show("Are you sure you want to delete this grade?", "WARNING!", MessageBoxButtons.YesNo);

                if (delete == DialogResult.Yes)
                {
                    FileManager.StudentList[index].GradesList.RemoveAt(lbScores.SelectedIndex);
                }

                this.Update();
            }
            else
            {
                MessageBox.Show("No grade selected; please select a grade to delete", "Error");
            }
            
        }

        //Function to clear scores
        private void btClearScores_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure you want to delete all of this student's scores?", "WARNING!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                FileManager.StudentList[index].GradesList.Clear();
                this.Update();
            }
        }

        //Listener for OK button
        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Listener for Cancel button
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
