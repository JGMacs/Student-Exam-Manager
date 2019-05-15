using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class frmNewScore : Form
    {
        static bool valid;

        static int validCount = 100;

        int index;

        //Default constructor
        public frmNewScore()
        {
            InitializeComponent();
        }

        //Constructor to record selected student's index number
        public frmNewScore(int index)
        {
            InitializeComponent();

            this.index = index;
        }

        //Textbox listener to see if text changed
        private void tbScore_TextChanged(object sender, EventArgs e)
        {
            validator(tbScore.Text.ToString() );
        }

        //Function to validate textbox input
        private void validator(string temp)
        {
            if (temp.Equals(null) || temp.Equals(""))
            { valid = false; }
            else
            {
                for (int i = 0; i < validCount; i++)
                {
                    if (temp.Equals("" + i))
                    { valid = true; }
                }
            }
        }

        //Function to add score to student's profile - calls "File Manager" class
        private void btAdd_Click(object sender, EventArgs e)
        {
            validator(tbScore.Text.ToString());

            if (valid)
            {
                if (int.Parse(tbScore.Text.ToString()) < 101)
                {
                    try
                    {
                        FileManager.AddScore(index, int.Parse(tbScore.Text.ToString()));
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a valid score in integer format.");
                        tbScore.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid score between 0-100.");
                    tbScore.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid score in integer format.");
                tbScore.SelectAll();
            }
        }

        //Function to close form
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewScore_Load(object sender, EventArgs e)
        {

        }
    }
}
