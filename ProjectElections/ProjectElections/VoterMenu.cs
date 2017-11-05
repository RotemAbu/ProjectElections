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
    public partial class VoterMenu : Form
    {
        private Voter voter;

        public VoterMenu(Voter temp)
        {
            InitializeComponent();
            voter = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showDetails voterd = new showDetails(voter);//option to show personal details.
            voterd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addAccompanierId addAccom = new addAccompanierId(voter);//option to add accompanier.
            addAccom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changePass passChange = new changePass(voter);//option to change password.
            passChange.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (voter.IsVoted || voter.IsBlocked)
                MessageBox.Show("Your voting option is not available!");
            else new Vote_page(voter).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ShowParties().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new ShowPrimeMinister().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (voter.AccomId.Equals("0"))
                {
                    MessageBox.Show("Accompany not exsist!");
                }
                else
                {
                    voter.RemoveAcompanier(voter.Id);
                    MessageBox.Show("Accompany removed suucesfully!");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateVoter up = new UpdateVoter(voter);
            up.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
                using (SearchPartiesByName search = new SearchPartiesByName(voter))
                {
                    search.ShowDialog();
                }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (SearchPartyMemberByName search = new SearchPartyMemberByName(voter))
            {
                search.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (ChangeKalpi changeKalpi = new ChangeKalpi(voter))
            {
                changeKalpi.ShowDialog();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (WatchKalpi viewkalpi = new WatchKalpi(voter))
            {
                viewkalpi.ShowDialog();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (SearchInvaildAccess access = new SearchInvaildAccess(voter))
            {
                access.ShowDialog();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you stay in your safe zone, and not making decision Nothing happens for better or worse...");
        }
    }
}