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
    public partial class addAccompKalpMan : Form
    {

        KalpiManager kal_man=null;

        public addAccompKalpMan(KalpiManager man)
        {
            kal_man = man;
            InitializeComponent();
        }

        private bool checkValidId(string id)
        {
            int tmp;
            if (/*(id.Length == CONSTANTS.ID_LENGTH) &&*/ (id.IndexOf("-") == (-1)) &&
                int.TryParse(id, out tmp)) return true; 
            return false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (checkValidId(voterIdText.Text) && checkValidId(accompIdText.Text))
            {
                kal_man.AddAccompanierId(voterIdText.Text, accompIdText.Text);
                this.Close();
            }
            else
                MessageBox.Show("Invalid field");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
