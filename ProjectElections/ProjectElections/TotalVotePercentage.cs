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
    public partial class TotalVotePercentage : Form
    {
        private ElectionsManager manager;
        sqlConnection con = sqlConnection.Instance;
        public TotalVotePercentage(ElectionsManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void TotalVotePercentage_Load(object sender, EventArgs e)
        {
            con.sqlCommand("getTotalprecentage");
            DataTable t = con.GetData("getTotalprecentage");
            DataRow r = t.Rows[0];

            double res = 0;

            try
            {
                res = double.Parse(r[0].ToString());
            }
            catch
            {
                MessageBox.Show("Unknown error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            labelRes.Text = res.ToString() + " %";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
