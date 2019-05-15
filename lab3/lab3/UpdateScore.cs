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
    public partial class frmUpdateScore : Form
    {
        static bool valid;

        static int validCount = 100;

        int index;
        int gradeIndex;

        public frmUpdateScore()
        {
            InitializeComponent();
        }

        //Constructor to record selected student's index number and grade index number
        public frmUpdateScore(int index, int gradeIndex)
        {
            InitializeComponent();

            this.index = index;
            this.gradeIndex = gradeIndex;
        }

        //Listener for textbox
        private void tbScore_TextChanged(object sender, EventArgs e)
        {
            validator(tbScore.Text.ToString());
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

        //Function to update scores
        private void btUpdate_Click(object sender, EventArgs e)
        {
            validator(tbScore.Text.ToString());

            if (valid)
            {
                if (int.Parse(tbScore.Text.ToString()) < 101)
                {
                    try
                    {
                        FileManager.UpdateScore(index, gradeIndex, int.Parse(tbScore.Text.ToString()));
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

        //Function to exit dialog
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
