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
   
    public partial class CountMandatByElectionsManager : Form
    {
        private sqlConnection con = sqlConnection.Instance;
        public CountMandatByElectionsManager(ElectionsManager eM)
        {

            InitializeComponent();
            ShowMandates();
        }

        public void ShowMandates()
        {
            con.sqlCommand("ShowMandat");//Get info from procedure
            DataTable t = con.GetData("ShowMandat");

            foreach (DataRow row in t.Rows)
            {
                listView1.Items.Add(row["Name"].ToString());
                int val = int.Parse(row["Total"].ToString())/3;
                listView2.Items.Add(val.ToString());
            }
        }

        public int CountMandate(string partyName)
        {
            con.sqlCommand("CountMandate");
            con.InsertValstring("@partyName", partyName);
            int res=int.Parse(con.getVal("Result").ToString());
            return (res/3);
        }

        private void ExBUT_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CountMandatByElectionsManager_Load(object sender, EventArgs e)
        {

        }
    }
}


