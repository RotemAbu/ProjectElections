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
    public partial class Vote_page : Form
    {
        private string party_choose = null;
        private int pm_choose = -1;
        Voter voter;

        /// <summary>
        /// initialize vote page for given voter
        /// </summary>
        /// <param name="tmp">Voter to vote</param>
        public Vote_page(Voter tmp)
        {
            if (tmp == null)
                throw new Exception(CONSTANTS.EXC_TEXT);
            voter = tmp;
            InitializeComponent();
            setPrimeMinstersListView();
            setPartiesListView();
        }

        /// <summary>
        /// setting the listview of prime ministers
        /// using SQL procedure
        /// </summary>
        private void setPrimeMinstersListView()
        {
            DataTable t = sqlConnection.getTableBycommand(CONSTANTS.GET_PR_MIN_PROC);
            ListViewItem tmp = null;
            foreach (DataRow element in t.Rows)
            {
                tmp = new ListViewItem(element[CONSTANTS.MEM_CODE].ToString());
                tmp.SubItems.Add(element[CONSTANTS.MEM_FN].ToString() + ' ' +
                element[CONSTANTS.MEM_LN].ToString());
                prime_ministers_lv.Items.Add(tmp);
            }
        }

        /// <summary>
        /// setting the listview of parties
        /// using SQL procedure
        /// </summary>
        private void setPartiesListView()
        {
            DataTable t = sqlConnection.getTableBycommand(CONSTANTS.GET_PAR_PROC);
            foreach (DataRow element in t.Rows)
                parties_lv.Items.Add(new ListViewItem(element[CONSTANTS.PA_PN].ToString()));
        }

        /// <summary>
        /// voting control for party
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (parties_lv.SelectedItems.Count != 1) return;
            party_choose = parties_lv.SelectedItems[0].Text;
        }

        /// <summary>
        /// voting control for prime minister
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (prime_ministers_lv.SelectedItems.Count != 1) return;
            pm_choose = int.Parse(prime_ministers_lv.SelectedItems[0].Text);
        }

        /// <summary>
        /// WhiteNote voting button control for prime minister
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            voter.whiteNote(); this.Close();
        }

        /// <summary>
        /// save voting options manager (button)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            if ((pm_choose == -1) && (party_choose == null)) { MessageBox.Show(CONSTANTS.CHOOSE_MSG1); return; }
            else if ((pm_choose != -1) && (party_choose == null)) voter.primeMinisterVote(pm_choose);
            else if ((pm_choose == -1) && (party_choose != null)) voter.PartyVote(party_choose);
            else { voter.partyAndPrime(party_choose, pm_choose); } this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    /// <summary>
    /// Constants fields for program
    /// </summary>

    public static class CONSTANTS
    {
        public static string CHOOSE_MSG1 = "Please choose something";
        public static string GET_PAR_PROC = "getParties";
        public static string PA_PN = "partyName";
        public static string MEM_LN = "lName";
        public static string MEM_FN = "fName";
        public static string MEM_CODE = "memberCode";
        public static string GET_PR_MIN_PROC = "getPrimeMinisters";
        public static string EXC_TEXT = "Error ocourd trying to load Voter";
    }
}