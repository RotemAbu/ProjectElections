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
    public partial class AddNewParty : Form
    {
        ElectionsManager manager;
        public AddNewParty(ElectionsManager v)
        {
            InitializeComponent();
            manager = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Try&Catch block to check if the currect inputs are in, if not show currect message and let the user to try again.
            //If succeeded manager call newParty method and create a new party. 
            try
            {
                int flag = manager.newParty(partyname.Text, int.Parse(partysize.Text), platformText.Text); //flag-for returning a result.

                if (flag == 1)
                {
                    MessageBox.Show("Add new Party succeeded!");
                }
                else
                {
                    MessageBox.Show("Add new party failed!");
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void partyname_TextChanged(object sender, EventArgs e){}
        private void partysize_TextChanged(object sender, EventArgs e){}
        private void platform_TextChanged(object sender, EventArgs e){}
        private void AddNewParty_Load(object sender, EventArgs e){}
        //EXIT
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
