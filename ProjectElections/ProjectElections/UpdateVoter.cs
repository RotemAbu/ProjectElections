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
    public partial class UpdateVoter : Form
    {
        Voter voter;
        public UpdateVoter(Voter v)
        {

            InitializeComponent();
            voter = v;
        }

        private void labelAddress_Click(object sender, EventArgs e) {}
        private void Updatebt_Click(object sender, EventArgs e)
        {
            try
            {
                if (voter.UpdateVoterDetails(textBox1.Text.Trim(),textBox2.Text.Trim(), textBox3.Text.Trim(),textBox4.Text.Trim(), textBox5.Text.Trim(), textBox6.Text.Trim(), textBox7.Text.Trim()).Equals("1"))
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Nbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow t = voter.SearchVoterToUpdate(textBox1.Text);// Using the function searchVoter, to find the relevent Voter.              
                //Show the voter details on the screen
                textBox2.Text = voter.FName;
                textBox3.Text = voter.LName;
                textBox4.Text=voter.Address;
                textBox5.Text=voter.Area;
                textBox6.Text = voter.City;
                textBox7.Text = voter.Tell;
            }
            catch
            {
                MessageBox.Show("The voter not exist in the system");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLName_Click(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void textBox3_TextChanged(object sender, EventArgs e) {}
        private void textBoxID_TextChanged(object sender, EventArgs e) {}
        private void textBox4_TextChanged(object sender, EventArgs e) {}
        private void textBox5_TextChanged(object sender, EventArgs e) {}
        private void textBox6_TextChanged(object sender, EventArgs e) {}
        private void textBox7_TextChanged(object sender, EventArgs e) {}
        private void labelId_Click(object sender, EventArgs e) {}

        private void Exbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateVoter_Load(object sender, EventArgs e)
        {}
        
    }
}
