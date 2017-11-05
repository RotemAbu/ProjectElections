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
    public partial class ShowPrimeMinister : Form
    {
        public ShowPrimeMinister()
        {
            InitializeComponent();
            showPrimeMinister();
        }

        public void showPrimeMinister()
        {
            DataTable t = sqlConnection.getTableBycommand(CONSTANTS.GET_PR_MIN_PROC);//Get info from procedure
            foreach (DataRow element in t.Rows)//Loop that runs over the table fields
            {
                listView1.Items.Add(new ListViewItem(element[CONSTANTS.MEM_FN].ToString() + ' ' +
                element[CONSTANTS.MEM_LN].ToString()));//Adds the prime ministers names to list
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
