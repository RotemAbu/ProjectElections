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
    public partial class changePass : Form
    {
        Voter vot;
        public changePass(Voter vot)
        {
            this.vot = vot;
            InitializeComponent();
        }
        /// <summary>
        /// The function chacking ןnput trim and send the new password to database
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(vot.Passowrd))// Chacking of Current password
            {
                MessageBox.Show("Check Existing Password");
            }
            else if (!textBox2.Text.Equals(textBox3.Text)) // A validator two new passwords
            {
                MessageBox.Show("Check Your New Password");
            }
            else //Send parameters to database
            { 
                vot.Passowrd = textBox2.Text;
                vot.changePass(textBox2.Text, vot.Id);
                MessageBox.Show("Password Changed");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void textBox3_TextChanged(object sender, EventArgs e){}
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chengePass_Load(object sender, EventArgs e){}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
