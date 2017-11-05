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
    public partial class AddNewVoterToKalpi : Form
    {
        private KalpiManager kalpiManager;

        public AddNewVoterToKalpi(KalpiManager kal)
        {
            InitializeComponent();
            kalpiManager = kal;
            CitytextBox.Text = kalpiManager.City;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Try&Catch block to check if the currect inputs are in, if not show currect message and let the user to try again.
            //If succeeded manager call addNewVoterToKalpi method and create a new voter. 
            try
            {
                int flag = kalpiManager.addnewVoterToKalpi(idtextBox.Text, kalpiManager.KalpiCode, FirstNametextBox.Text, LastNametextBox.Text, UserNametextBox.Text, PasswordtextBox.Text, "0", brithDate.Value, AddresstextBox.Text, AreatextBox.Text, CitytextBox.Text, TelltextBox.Text, AccomulateIDtextBox.Text); //flag-for returning a result.

                if (flag == 1)
                {
                    MessageBox.Show("Add New Voter to Kalpi succeeded!");
                }
                else
                {
                    MessageBox.Show("Add New Voter to Kalpi failed!");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brithDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CitytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
