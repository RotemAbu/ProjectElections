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
    public partial class KalpiManagerCloseKalpi : Form
    {
        private KalpiManager kalpiManager;

        public KalpiManagerCloseKalpi(KalpiManager kalpiM)
        {
            InitializeComponent();
            kalpiManager = kalpiM;
        }

        private void KalpiManagerCloseKalpi_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection con = sqlConnection.Instance;//sql conection
                con.sqlCommand("getCalpiCode");//sql Procedure
                con.InsertValstring("@kalpiCode", KalpiCodetextBox.Text); //sql insert Value
                DataTable kCode = con.GetData("getCalpiCode");

                //Check if the kalpi does't exists
                if (kCode.Rows.Count == 0)
                {
                    throw new Exception();
                }

                //Check if equals to  kalpi manager kalpi code
                if (kalpiManager.KalpiCode.Equals(KalpiCodetextBox.Text))
                {
                    kalpiManager.CloseKalpi(KalpiCodetextBox.Text); //call to CloseKalpi Function
                    MessageBox.Show("Close kalpi is sucsses");
                }
                else
                {
                    MessageBox.Show("The input KalpiCode does not match to the Kalpi Manager kalpiCode!");
                }
            }
            catch
            {
                MessageBox.Show("The Kalpi Code is invalid!");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
