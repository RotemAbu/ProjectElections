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
    public partial class Kalpi_Manager_Menu : Form
    {
        private KalpiManager kalpi_manager;
        public Kalpi_Manager_Menu(KalpiManager k_mngr)
        {
            InitializeComponent();
            kalpi_manager = k_mngr;
        }
         
        private void add_voter_Click(object sender, EventArgs e)
        {
            using (AddVoterToKalpi addVoterKalpi = new AddVoterToKalpi(kalpi_manager))//option to add voter to kalpi.
            {
                addVoterKalpi.ShowDialog();
            }
        }

        private void remove_voter_Click(object sender, EventArgs e)
        {
            using (RemoveVoterFromKalpi RemoveVoterKalpi = new RemoveVoterFromKalpi(kalpi_manager))//option to add voter to kalpi.
            {
                RemoveVoterKalpi.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e) {}

        private void add_accomp_Click(object sender, EventArgs e)
        {
            new addAccompKalpMan(kalpi_manager).Show();
        }

        private void identify_voter_Click(object sender, EventArgs e)
        {
            new searchVoterKalpiMan(kalpi_manager).Show();
        }

        private void block_voter_Click(object sender, EventArgs e)
        {
            BlockCitizen blockCitizen = new BlockCitizen(kalpi_manager);//option to block Voter.
            blockCitizen.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UnblockCitizen unblockCitizen = new UnblockCitizen(kalpi_manager);//option to unblock Voter.
            unblockCitizen.Show();
        }
    }
}
