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
    public partial class ManagerMenu : Form
    {
        private ElectionsManager manager;

        public ManagerMenu(ElectionsManager v)
        {
            InitializeComponent();
            manager = v;
        }

        private void ManagerMenu_Load(object sender, EventArgs e){}
        private void button4_Click(object sender, EventArgs e)
        {
            using (AddPartyMember add = new AddPartyMember(manager))//option to add new party member.
            {
                add.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (updateMemberParty updatemem = new updateMemberParty(manager))//option to update member party.
            {
                updatemem.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePartyDetails updateMemParty = new UpdatePartyDetails(manager);//option to update party details.
            updateMemParty.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RemoveMember removeMem = new RemoveMember(manager);//option to remove party member.
            removeMem.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddNewParty addNewParty = new AddNewParty(manager))//option to add new party.
            {
                addNewParty.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (removeParty remove = new removeParty(manager))//option to remove party.
            {
                remove.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            changePass passChange = new changePass(manager);//option to change password.
            passChange.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addAccompanierId addAccom = new addAccompanierId(manager);//option to add accompanier.
            addAccom.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showDetails voterd = new showDetails(manager);//option to show personal details.
            voterd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(manager.IsVoted || manager.IsBlocked)
                MessageBox.Show("Your voting option is not available!");
            else 
            { 
               var tmp = new Vote_page(manager);
               tmp.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ShowParties().Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                if (manager.AccomId.Equals("0"))
                {
                    MessageBox.Show("Accompany not exsist!");
                }
                else
                {
                    manager.RemoveAcompanier(manager.Id);
                    MessageBox.Show("Accompany removed suucesfully!");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            showDetails voterd = new showDetails(manager);//option to show personal details.
            voterd.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new ShowPrimeMinister().Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            UpdateVoter up = new UpdateVoter(manager);
            up.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (SearchPartyMemberByName search = new SearchPartyMemberByName(manager))
            {
                search.ShowDialog();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            using (ChangeKalpi changeKalpi = new ChangeKalpi(manager))
            {
                changeKalpi.ShowDialog();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            using (WatchKalpi viewkalpi = new WatchKalpi(manager))
            {
                viewkalpi.ShowDialog();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            using (AddNewAreaManager addNewAreaManager = new AddNewAreaManager(manager))//option to add voter to kalpi.
            {
                addNewAreaManager.ShowDialog();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            using (RemoveAreaManager removeAreaManager = new RemoveAreaManager(manager))//option to add voter to kalpi.
            {
                removeAreaManager.ShowDialog();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            new AddNewAreaManager(manager, true).Show();
        }

        private void openKalpiButton_Click(object sender, EventArgs e)
        {
            try
            {
                manager.OpenKalpi();
                MessageBox.Show("All Kalpis Is Open \n Good luck !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addInspectorButton_Click(object sender, EventArgs e)
        {
            using (AddCommissioner inspector = new AddCommissioner(manager))
            {
                if (inspector.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Added Successfully !");
                }
                else
                {
                    MessageBox.Show("Failed To Add!");
                }
            }
        }

        
        
        /// <summary>
        /// Lets the Elections Manager close all kalpis in the country.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeAllKalpi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close all kalpi in the country?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    manager.CloseAllKalpi();
                    MessageBox.Show("All Kalpis Are Now Closed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            using (SearchInvaildAccess access = new SearchInvaildAccess(manager))
            {
                access.ShowDialog();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            using (TotalVotePercentage tot = new TotalVotePercentage(manager))
            {
                tot.ShowDialog();
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            using (CountMandatByElectionsManager count = new CountMandatByElectionsManager(manager))
            {
                count.ShowDialog();
            }
        }
    }
}
