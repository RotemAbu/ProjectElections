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
    public partial class ShowPartyElecResult : Form
    {
        private KalpiManager kalpiManager;
      
        private List<string> partyNames = new List<string>();
        int i = 0;
        private sqlConnection con = sqlConnection.Instance;

        public ShowPartyElecResult(KalpiManager kal)
        {
            InitializeComponent();
            kalpiManager = kal;
            KalpiCodeTextBox.Text = kalpiManager.KalpiCode;
            showResults();
        }

        public void showResults()
        {
            DataTable t = sqlConnection.getTableBycommand(CONSTANTS.GET_PAR_PROC);//Get info from procedure
            foreach (DataRow element in t.Rows)//Loop that runs over the table fields
            {
                partyNames.Add(element[CONSTANTS.PA_PN].ToString());
                listView1.Items.Add(new ListViewItem(partyNames[i]));//Adds the parties names to list
                listView2.Items.Add(isInVoteDB(partyNames[i], KalpiCodeTextBox.Text).ToString());
                i++;
            }
        }

        public int isInVoteDB(string partyName,string kalpiCode)
        {
            con.sqlCommand("IsInVoteDB");
            con.InsertValstring("@partyName", partyName);
            con.InsertValstring("@kalpiCode", kalpiCode);
            return int.Parse(con.getVal("Result").ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numberCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
