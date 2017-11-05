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
    /// <summary>
    /// Menu of user Kalpi Manager
    /// </summary>
    public partial class KalpiManagerMenu : Form
    {
        private KalpiManager kalpi_manager; //the user of this menu - a Kalpi Manager

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="k_mngr">kalpi manager with details of the current user</param>
        public KalpiManagerMenu(KalpiManager k_mngr)
        {
            InitializeComponent();
            kalpi_manager = k_mngr;
        }
        
        //opens GUI where kalpi manager can add an existing voter to his kalpi
        private void add_voter_Click(object sender, EventArgs e)
        {
            using (AddVoterToKalpi addVoterKalpi = new AddVoterToKalpi(kalpi_manager))//option to add voter to kalpi.
            {
                addVoterKalpi.ShowDialog();
            }
        }

        //opens GUI where kalpi manager can remove a voter from his kalpi
        private void remove_voter_Click(object sender, EventArgs e)
        {
            using (RemoveVoterFromKalpi RemoveVoterKalpi = new RemoveVoterFromKalpi(kalpi_manager))//option to add voter to kalpi.
            {
                RemoveVoterKalpi.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e) {}

        //opens GUI where kalpi manager can add an accompanier to a voter in his kalpi
        private void add_accomp_Click(object sender, EventArgs e)
        {
            new addAccompKalpMan(kalpi_manager).Show();
        }

        //opens GUI where kalpi manager can search and view details of voters in his kalpi
        private void identify_voter_Click(object sender, EventArgs e)
        {
            new searchVoterKalpiMan(kalpi_manager).Show();
        }

        //opens GUI where kalpi manager can block a voter from voting
        private void block_voter_Click(object sender, EventArgs e)
        {
            BlockCitizen blockCitizen = new BlockCitizen(kalpi_manager);//option to block Voter.
            blockCitizen.Show();
        }

        ////opens GUI where kalpi manager can unblock a voter and let him vote
        private void button1_Click_1(object sender, EventArgs e)
        {
            UnblockCitizen unblockCitizen = new UnblockCitizen(kalpi_manager);//option to unblock Voter.
            unblockCitizen.Show();
        }

        //opens GUI where kalpi manager see the parties that are up for election
        private void show_parties_Click(object sender, EventArgs e)
        {
            new ShowParties().Show();
        }

        //opens GUI where kalpi manager see the prime ministers that are up for election
        private void show_prime_Click(object sender, EventArgs e)
        {
            new ShowPrimeMinister().Show();
        }

        //kalpi manager can remove his own accompanier
        private void remove_accomp_Click(object sender, EventArgs e)
        {
            if (kalpi_manager.AccomId.Equals("0"))
            {
                MessageBox.Show("Accompany not exsist!");
            }
            else
            {
                kalpi_manager.RemoveAcompanier(kalpi_manager.Id);
                MessageBox.Show("Accompany removed suucesfully!");
            }
        }

        //opens GUI where kalpi manager can update voter details
        private void update_details_Click(object sender, EventArgs e)
        {
            UpdateVoter up = new UpdateVoter(kalpi_manager);
            up.Show();
        }

        //opens GUI where kalpi manager can search for details of specific party memeber
        private void button2_Click(object sender, EventArgs e)
        {
            using (SearchPartyMemberByName search = new SearchPartyMemberByName(kalpi_manager))
            {
                search.ShowDialog();
            }
        }

        //opens GUI where kalpi manager can see details of his kalpi
        private void kalpi_details_Click(object sender, EventArgs e)
        {
            using (WatchKalpi viewkalpi = new WatchKalpi(kalpi_manager))
            {
                viewkalpi.ShowDialog();
            }
        }

        //opens GUI where kalpi manager can search for details of specific party that is up for elections
        private void search_party_Click(object sender, EventArgs e)
        {
            using (SearchPartiesByName search = new SearchPartiesByName(kalpi_manager))
            {
                search.ShowDialog();
            }
        }

        //opens GUI where kalpi manager can see his personal details
        private void personal_details_Click(object sender, EventArgs e)
        {
            showDetails voterd = new showDetails(kalpi_manager);//option to show personal details.
            voterd.Show();
        }

        //opens GUI where kalpi manager can change his password
        private void change_password_Click(object sender, EventArgs e)
        {
            changePass passChange = new changePass(kalpi_manager);//option to change password.
            passChange.Show();
        }

        //opens GUI where kalpi manager can vote in the elections
        private void vote_button_Click(object sender, EventArgs e)
        {
            if (kalpi_manager.IsVoted || kalpi_manager.IsBlocked)
                MessageBox.Show("Your voting option is not available!");
            else new Vote_page(kalpi_manager).Show();
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            using (AddWorkerToKalpi worker = new AddWorkerToKalpi(kalpi_manager))
            {
                if (worker.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Successfully Saved. ");
                }
                else
                {
                    MessageBox.Show("Save Failed");
                }
            }
        }

        private void RemoveWorkerButton_Click(object sender, EventArgs e)
        {
            using (RemoveWorker worker = new RemoveWorker(kalpi_manager))
            {
                if (worker.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Successfully Saved. ");
                }
                else
                {
                    MessageBox.Show("Save Failed");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddWorkerToKalpi(kalpi_manager, true).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (AddNewVoterToKalpi addNewVoterKalpi = new AddNewVoterToKalpi(kalpi_manager))//option to add voter to kalpi.
            {
                addNewVoterKalpi.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (ShowPrimeVotes primeVotes = new ShowPrimeVotes(kalpi_manager))
            {
                primeVotes.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;

            count = kalpi_manager.countWhiteNots(kalpi_manager);

            MessageBox.Show("Number of white notes in your kalpi is: " + count + "!","White Notes",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ShowPartyElecResult(kalpi_manager).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (KalpiManagerCloseKalpi closeKalpi = new KalpiManagerCloseKalpi(kalpi_manager))//option to add voter to kalpi.
            {
                closeKalpi.ShowDialog();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (SearchInvaildAccess access = new SearchInvaildAccess(kalpi_manager))
            {
                access.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you stay in your safe zone, and not making decision Nothing happens for better or worse...");
        }
    }
}
