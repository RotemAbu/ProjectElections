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
    public partial class WatchKalpi : Form
    {
        private Voter voter;
        private sqlConnection con;

        public WatchKalpi(Voter v)
        {
            InitializeComponent();
            voter = v;
            con = sqlConnection.Instance;
        }

        private void WatchKalpi_Load(object sender, EventArgs e)
        {
            if (voter.KalpiCode == "0")
            {
                MessageBox.Show("You are not assigned to any Kalpi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            con.sqlCommand("getKalpiByCode");
            con.InsertValstring("@kalpiCode", voter.KalpiCode);
            DataTable temp = con.GetData("getKalpiByCode");
            DataRow kalpi = temp.Rows[0];
            textBoxCity.Text = kalpi["city"].ToString();
            textBoxKalpi.Text = kalpi["kalpiName"].ToString();
            textBoxAddress.Text = kalpi["address"].ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
