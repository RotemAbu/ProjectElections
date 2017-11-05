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
    public partial class ShowPrimeVotes : Form
    {
        KalpiManager kalpiManager;
        sqlConnection con = sqlConnection.Instance;
        public ShowPrimeVotes(KalpiManager kaMan)
        {
            InitializeComponent();
            kalpiManager = kaMan;
        }

        private void ShowPrimeVotes_Load(object sender, EventArgs e)
        {
            fillDtatGridView();

            DataTable votes = kalpiManager.getVotesForPrime();

            foreach (DataRow row in votes.Rows)
            {
                string fName = "", lName = "", Votes = "";

                foreach (DataGridViewRow gridRow in dataGridView1.Rows)
                {
                    if (gridRow.Cells[0].Value.ToString().Equals(row["primeCode"].ToString()))
                    {
                        fName = gridRow.Cells[2].Value.ToString();
                        lName = gridRow.Cells[3].Value.ToString();
                        Votes = row["Total"].ToString();
                        break;
                    }
                }
               
                listBoxRes.Items.Add(fName + " " + lName);
                listBoxVotes.Items.Add(Votes);
            }
        }

        private void fillDtatGridView()
        {
            this.party_MembersTableAdapter.Fill(this.projectDBDataSet1.Party_Members);
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "listPlace=1 and mode=1";
            dataGridView1.DataSource = bs;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
