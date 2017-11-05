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
    public partial class SearchPartiesByName : Form
    {
        private Voter voter;
        public SearchPartiesByName(Voter voter)
        {
            InitializeComponent();
            this.voter = voter;
        }
        private void Serach_Click(object sender, EventArgs e)
        {
            try
            {
                Parties party = voter.searchPartyName(idName.Text);
                    nameParty.Text = party.PartyName;
                    sizeParty.Text = party.MembersSize.ToString();
                    platform.Text = party.Platform;             
            }
            catch
            {
                MessageBox.Show("Not Exist such Name in System");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
