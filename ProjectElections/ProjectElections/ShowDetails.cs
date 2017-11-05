using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectElections
{
    public partial class showDetails : Form
    {
        public showDetails(Voter vot)
        {
            InitializeComponent();
            this.Text = "Personal Details: " + vot.FName;
            show(vot);
        }

        private void textBox3_TextChanged(object sender, EventArgs e){}

        private void show(Voter voter)
        {
            textBoxID.Text = voter.Id;
            textBoxFName.Text = voter.FName;
            textBoxLName.Text = voter.LName;
            textBoxBD.Text = (voter.DOB).ToString();
            textBoxAddress.Text = voter.Address;
            textBoxArea.Text = voter.Area;
            textBoxCity.Text = voter.City;
            textBoxTel.Text = voter.Tell;
            if (voter.IsVoted)
            {
                checkBoxVoted.Checked = true;
            }
            else
            {
                checkBoxVoted.Checked = false;
            }

            if (voter.IsBlocked)
            {
                checkBoxBlocked.Checked = true;
            }
            else
            {
                checkBoxBlocked.Checked = false;
            }
        }
        private void showVoter_Load(object sender, EventArgs e){}
        private void textBoxID_TextChanged(object sender, EventArgs e){}
        private void textBoxFName_TextChanged(object sender, EventArgs e){}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
