using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class frmAddNewStudent : Form
    {
        string name;

        bool valid = false;
        int validCount = 100;

        IList<int> scoreList = new List<int>();

        public frmAddNewStudent()
        {
            InitializeComponent();
        }

        //Function to validate textbox input
        private void validator(string temp)
        {
            if (temp == null || temp.Equals("") )
                { valid = false; }
            else
            {
                for (int i = 0; i < validCount; i++)
                {
                    if (temp.Equals("" + i) )
                    { valid = true; }
                }
            }
        }

        //Function to update Scores textbox's text
        private void updateScores()
        {
            tbScores.Clear();
            tbNewScore.Clear();

            for (int i=0; i< scoreList.Count; i++)
            {
                tbScores.AppendText(scoreList[i] + ((i==scoreList.Count-1)?"" : ", ") );
            }
        }

        //Button listener function for Add Score
        private void btAddScore_Click(object sender, EventArgs e)
        {
            validator(tbNewScore.Text.ToString() );

            if (valid)
            {
                try {
                    scoreList.Add(int.Parse(tbNewScore.Text.ToString()));
                    updateScores();
                } catch {
                    MessageBox.Show("Please enter a valid score in integer format.");
                    tbNewScore.Focus();
                    tbNewScore.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid score in integer format.");
                tbNewScore.Focus();
                tbNewScore.SelectAll();
            }
        }

        //Button listener function for Clear Scores
        private void btClearScores_Click(object sender, EventArgs e)
        {
            tbNewScore.Clear();
            tbScores.Clear();
            scoreList.Clear();
        }

        //Button listener function for Cancel
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button listener function for OK
        private void btOK_Click(object sender, EventArgs e)
        {
            validator(tbNewScore.Text.ToString());

            if (name.Equals(null) || name.Length <= 0)
            {
                MessageBox.Show("Please enter a valid student name");
                tbName.SelectAll();
            }
            else if (name.Length > 0)
            {
                FileManager.CreateStudent(name, scoreList);
                this.Close();
            }
            else if (!valid)
            {
                MessageBox.Show("Please enter a valid score in integer format.");
                tbNewScore.SelectAll();
            }
            else
            {
                MessageBox.Show("Unknown Error: AddNewStudent - ln 115");
            }
        }

        //Listener to update name textbox
        private void tbName_Leave(object sender, EventArgs e)
        {
            name = tbName.Text.ToString();
        }

        //Listener to update name textbox
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            name = tbName.Text.ToString();
        }

        private void frmAddNewStudent_Load(object sender, EventArgs e)
        {

        }

    }
}
