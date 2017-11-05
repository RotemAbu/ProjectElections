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
    public partial class searchVoterKalpiMan : Form
    {
        KalpiManager kalp_man;

        public searchVoterKalpiMan(KalpiManager klp)
        {
            kalp_man = klp;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            voterView.Items.Clear();
            Voter tmp = kalp_man.searchVoterById(textBox1.Text);
            if (tmp == null) return;
            ListViewItem data = new ListViewItem(tmp.FName);
            data.SubItems.Add(tmp.LName);
            data.SubItems.Add(tmp.DOB.ToString());
            data.SubItems.Add(tmp.IsVoted.ToString());
            data.SubItems.Add(tmp.Address + " ," + tmp.City);
            data.SubItems.Add(tmp.AccomId);
            data.SubItems.Add(tmp.IsBlocked.ToString());
            voterView.Items.Add(data);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
