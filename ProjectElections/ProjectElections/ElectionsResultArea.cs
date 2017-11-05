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
    /// displays amount of votes for prime ministers and parties, in the area of the given area manager.
    /// </summary>
    public partial class ElectionsResultArea : Form
    {
        private AreaManager area_manager; //will hold area manager details of manager that entered the system            
        private sqlConnection con = sqlConnection.Instance;
        private DataTable kalpies; //will hold kalpis details in area manager area

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="mngr">instance of area manager</param>
        public ElectionsResultArea(AreaManager mngr)
        {
            InitializeComponent();
            area_manager = mngr;
            l_area.Text = mngr.Area;
            con.sqlCommand("ReturnKalpiesInArea");
            con.InsertValstring("@area", area_manager.Area); //sending parameters
            kalpies = con.GetData("ReturnKalpiesInArea");
            showPartyResults();
            showPrimeResults();
        }

        /// <summary>
        /// displays votes amount in current area for all parties
        /// </summary>
        private void showPartyResults()
        {            
            List<string> partyNames = new List<string>();             
            DataTable parties = sqlConnection.getTableBycommand(CONSTANTS.GET_PAR_PROC);
            
            int i = 0;
            int res = 0;
            foreach (DataRow party in parties.Rows)
            {
                
                partyNames.Add(party[CONSTANTS.PA_PN].ToString());
                listView1.Items.Add(new ListViewItem(partyNames[i]));//Adds the parties names to list
                foreach (DataRow kalpi in kalpies.Rows)
                {
                    res = res + partyVoteNum(partyNames[i], kalpi["kalpiCode"].ToString());              
                    
                }
                listView2.Items.Add(res.ToString());
                res = 0;
                i++;
                 
            } 
        }

        /// <summary>
        /// displays votes amount in current area for all prime ministers
        /// </summary>
        private void showPrimeResults()
        {
            DataTable primes = sqlConnection.getTableBycommand("getPrimeMinisters");            
            int res = 0;
            foreach (DataRow prime in primes.Rows)
            {               
                listView3.Items.Add(new ListViewItem(prime["fName"].ToString() + " " + prime["lName"].ToString()));//Adds the prime ministers to list
                foreach (DataRow kalpi in kalpies.Rows)
                {
                    res = res + primeVoteNum(prime["memberCode"].ToString(), kalpi["kalpiCode"].ToString());

                }
                listView4.Items.Add(res.ToString());
                res = 0;       

            }    

        }

        /// <summary>
        /// calculates votes amount ,in a given kalpi, for a given party
        /// </summary>
        /// <param name="partyName">name of given party</param>
        /// <param name="kalpiCode">code of given kalpi</param>
        /// <returns></returns>
        private int partyVoteNum(string partyName, string kalpiCode)
        {
            con.sqlCommand("IsInVoteDB");
            con.InsertValstring("@partyName", partyName);
            con.InsertValstring("@kalpiCode", kalpiCode);
            return int.Parse(con.getVal("Result").ToString());
        }

        /// <summary>
        /// calculates votes amount ,in a given kalpi, for a given prime minister
        /// </summary>
        /// <param name="primeCode">code of given prime ministers</param>
        /// <param name="kalpiCode">code of given kalpi</param>
        /// <returns></returns>
        private int primeVoteNum(string primeCode, string kalpiCode)
        {
            con.sqlCommand("getPrimeVotesInKalpi");
            con.InsertValstring("@primeCode", primeCode);
            con.InsertValstring("@kalpiCode", kalpiCode);
            return int.Parse(con.getVal("Result").ToString());
        }

        private void ElectionsResultArea_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
