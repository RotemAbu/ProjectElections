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
    public partial class BlockKalpi : Form
    {
        public AreaManager areaManager;
        public BlockKalpi(AreaManager areaManager)
        {
            this.areaManager = areaManager;
            InitializeComponent();
        }
        /// <summary>
        /// The function check kalpi code exist and block him.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                sqlConnection con = sqlConnection.Instance;//sql conection
                con.sqlCommand("getCalpiCode");//sql Procedure
                con.InsertValstring("@kalpiCode", textBox1.Text); //sql insert Value
                DataTable kCode = con.GetData("getCalpiCode");

                if (kCode.Rows.Count == 0)
                {
                    throw new Exception();
                }
                foreach (DataRow code in kCode.Rows)
                {

                    if (code["kalpiCode"].ToString().Equals(textBox1.Text))
                    {
                        areaManager.BlockCalpi(textBox1.Text); //call to blocked Function
                        MessageBox.Show("Block is sucsses");
                        this.Close();
                    }
                }

            }
            catch
            {
                MessageBox.Show("The Kalpi Code is invalid!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
