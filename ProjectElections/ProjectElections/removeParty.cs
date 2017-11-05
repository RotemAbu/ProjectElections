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
    public partial class removeParty : Form
    {
        ElectionsManager manager;
        public removeParty(ElectionsManager v)
        {
            InitializeComponent();
            manager = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Try&Catch block to check if the currect inputs are in, if not show currect message and let the user to try again.
            //If succeeded manager call removeParty method and remove the requested party from Parties DB.
            int flag = manager.removeParty(textPartyName.Text, false); //flag-for returning a result.

            if (flag == 1)
            {
                MessageBox.Show("delete Party succeeded!");
            }
            else
            {
                MessageBox.Show("delete party failed!");
            }
        }

        //EXIT
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void removeParty_Load(object sender, EventArgs e){}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
