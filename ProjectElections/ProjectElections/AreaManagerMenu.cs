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
    public partial class AreaManagerMenu : Form
    {

        private AreaManager area_manager; //the user of this menu - area Manager
        // Menu of user Area Manager
        public AreaManagerMenu(AreaManager a_manager)
        {
            InitializeComponent();
            area_manager = a_manager;
        }


        //opens GUI where area manager can change his password
        private void button1_Click(object sender, EventArgs e)
        {
            changePass passChange = new changePass(area_manager);//option to change password.
            passChange.Show();
        }

        //opens GUI where area manager can add an accompanier to a voter in his area
        private void button2_Click(object sender, EventArgs e)
        {
            new addAccompKalpMan(area_manager).Show();
        }

        //opens GUI where area manager see the parties that are up for election
        private void button5_Click(object sender, EventArgs e)
        {
            new ShowParties().Show();
        }

        //area manager can remove his own accompanier
        private void button7_Click(object sender, EventArgs e)
        {
            if (area_manager.AccomId.Equals("0"))
            {
                MessageBox.Show("Accompany not exsist!");
            }
            else
            {
                area_manager.RemoveAcompanier(area_manager.Id);
                MessageBox.Show("Accompany removed suucesfully!");
            }
        }

        //opens GUI where area manager can search for details of specific party that is up for elections
        private void button9_Click(object sender, EventArgs e)
        {
            using (SearchPartiesByName search = new SearchPartiesByName(area_manager))
            {
                search.ShowDialog();
            }
        }

        //opens GUI where area manager can vote in the elections
        private void button4_Click(object sender, EventArgs e)
        {
            if (area_manager.IsVoted || area_manager.IsBlocked)
                MessageBox.Show("Your voting option is not available!");
            else new Vote_page(area_manager).Show();
        }

        //opens GUI where area manager can see his personal details
        private void button3_Click(object sender, EventArgs e)
        {
            showDetails voterd = new showDetails(area_manager);//option to show personal details.
            voterd.Show();
        }

        //opens GUI where area manager see the prime ministers that are up for election
        private void button6_Click(object sender, EventArgs e)
        {
            new ShowPrimeMinister().Show();
        }

        //opens GUI where area manager can update voter details
        private void button8_Click(object sender, EventArgs e)
        {
            UpdateVoter up = new UpdateVoter(area_manager);
            up.Show();
        }

        //opens GUI where area manager can search for details of specific party memeber
        private void button10_Click(object sender, EventArgs e)
        {
            using (SearchPartyMemberByName search = new SearchPartyMemberByName(area_manager))
            {
                search.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {}

        //opens GUI where area manager can see details of his kalpi
        private void button12_Click(object sender, EventArgs e)
        {
            using (WatchKalpi viewkalpi = new WatchKalpi(area_manager))
            {
                viewkalpi.ShowDialog();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            using (NewKalpiToArea newKalpiToArea = new NewKalpiToArea(area_manager))
            {
                newKalpiToArea.ShowDialog();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (BlockKalpi blockKalpi = new BlockKalpi(area_manager))
            {
                blockKalpi.ShowDialog();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (UnblockKalpi unblockKalpi = new UnblockKalpi(area_manager))
            {
                unblockKalpi.ShowDialog();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (UpdateKalpiDetails up = new UpdateKalpiDetails(area_manager))
            {
                up.ShowDialog();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (UpdateKalpManagerDetails up = new UpdateKalpManagerDetails(area_manager))
            {
                up.ShowDialog();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (RemoveKalpiFromArea removeKalpi = new RemoveKalpiFromArea(area_manager))
            {
                removeKalpi.ShowDialog();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            using (AddNewKalpiManager new_manager = new AddNewKalpiManager(area_manager))
            {
                new_manager.ShowDialog();
            }
        }

        //button that opens GUI, where the area manager can remove a kalpi manager by id.
        private void removeKalpiMngr_Click(object sender, EventArgs e)
        {
            using (RemoveKalpiManager remove_mngr = new RemoveKalpiManager(area_manager))
            {
                remove_mngr.ShowDialog();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (ShowKalpiesInArea showkalpies = new ShowKalpiesInArea(area_manager))
            {
                showkalpies.ShowDialog();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            using (PercentageVotersReportByArea showper = new PercentageVotersReportByArea(area_manager))
            {
                showper.ShowDialog();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            using (AddKalpiVoter addKalpi = new AddKalpiVoter(area_manager))
            {
                addKalpi.ShowDialog();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            using (CloseKalpiByAreaManager cls = new CloseKalpiByAreaManager(area_manager))
            {
                cls.ShowDialog();
            }  
           

        }

        /// <summary>
        /// Elections results for parties and prime ministers in area.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElectionResultArea_Click(object sender, EventArgs e)
        {
            using (ElectionsResultArea res = new ElectionsResultArea(area_manager))
            {
                res.ShowDialog();
            }  
        }

        private void button24_Click(object sender, EventArgs e)
        {
            using (SearchInvaildAccess access = new SearchInvaildAccess(area_manager))
            {
                access.ShowDialog();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            using (ChangeKalpi changeKalpi = new ChangeKalpi(area_manager))
            {
                changeKalpi.ShowDialog();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            using (AddNewVoterToKalpi addNewVoterKalpi = new AddNewVoterToKalpi(area_manager))//option to add voter to kalpi.
            {
                addNewVoterKalpi.ShowDialog();
            }
        }

        private void add_voter_Click(object sender, EventArgs e)
        {
            using (AddVoterToKalpi addVoterKalpi = new AddVoterToKalpi(area_manager))//option to add voter to kalpi.
            {
                addVoterKalpi.ShowDialog();
            }
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            using (AddWorkerToKalpi worker = new AddWorkerToKalpi(area_manager))
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

        private void button27_Click(object sender, EventArgs e)
        {
            new AddWorkerToKalpi(area_manager, true).Show();
        }

        private void RemoveWorkerButton_Click(object sender, EventArgs e)
        {
            using (RemoveWorker worker = new RemoveWorker(area_manager))
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

        private void identify_voter_Click(object sender, EventArgs e)
        {
            new searchVoterKalpiMan(area_manager).Show();
        }

        private void block_voter_Click(object sender, EventArgs e)
        {
            BlockCitizen blockCitizen = new BlockCitizen(area_manager);//option to block Voter.
            blockCitizen.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            UnblockCitizen unblockCitizen = new UnblockCitizen(area_manager);//option to unblock Voter.
            unblockCitizen.Show();
        }

        private void remove_voter_Click(object sender, EventArgs e)
        {
            using (RemoveVoterFromKalpi RemoveVoterKalpi = new RemoveVoterFromKalpi(area_manager))//option to add voter to kalpi.
            {
                RemoveVoterKalpi.ShowDialog();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int count = 0;

            count = area_manager.countWhiteNots(area_manager);

            MessageBox.Show("Number of white notes in your kalpi is: " + count + "!", "White Notes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            using (ShowPrimeVotes primeVotes = new ShowPrimeVotes(area_manager))
            {
                primeVotes.ShowDialog();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            using (KalpiManagerCloseKalpi closeKalpi = new KalpiManagerCloseKalpi(area_manager))//option to add voter to kalpi.
            {
                closeKalpi.ShowDialog();
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            new ShowPartyElecResult(area_manager).Show();
        }

        private void AreaManagerMenu_Load(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            using (ElectionsResultArea res = new ElectionsResultArea(area_manager))
            {
                res.ShowDialog();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you stay in your safe zone,and not making decision Nothing happens for better or worse...");
        }









        
    }
}
