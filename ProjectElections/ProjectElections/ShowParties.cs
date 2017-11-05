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
    public partial class ShowParties : Form
    {
        public ShowParties()
        {
            InitializeComponent();
            showparties();
        }

        public void showparties()
        {
            DataTable t = sqlConnection.getTableBycommand(CONSTANTS.GET_PAR_PROC);//Get info from procedure
            foreach (DataRow element in t.Rows)//Loop that runs over the table fields
                listView1.Items.Add(new ListViewItem(element[CONSTANTS.PA_PN].ToString()));//Adds the parties names to list
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
