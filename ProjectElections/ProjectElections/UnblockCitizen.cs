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
    public partial class UnblockCitizen : Form
    {
        KalpiManager manager;
        public UnblockCitizen(KalpiManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }
        /// <summary>
        /// The function Chack if kalpi Name Equals with kalpi manager 
        /// and unblocked Voter.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                bool success = int.TryParse(textBox1.Text, out i);
                if (textBox1.Text.Length == 9 && success == true && int.Parse(textBox1.Text) > 0) // Checks for valid input
                {
                    sqlConnection con = sqlConnection.Instance;//sql conection
                    con.sqlCommand("getCalpiCodeById");//sql Procedure
                    con.InsertValstring("@id", textBox1.Text.Trim());//sql insert Value
                    DataTable kCode = con.GetData("getCalpiCodeById");

                    if (kCode.Rows.Count == 0)
                    {
                        throw new Exception();
                    }
                    foreach (DataRow code in kCode.Rows)
                    {

                        if (code["kalpiCode"].ToString().Equals(manager.KalpiCode))
                        {
                            manager.UnblockedCitizen(textBox1.Text); //call to unblocked Function
                            MessageBox.Show("Un Block Voter Succeeded");
                            this.Close();
                        }
                        MessageBox.Show("can't unblock voter, he doesn't belong to your kalpi");
                        this.Close();
                    }
                }
                else { MessageBox.Show(" Invalid input"); }
               
            }
            catch {
                MessageBox.Show("The Id is invalid!");
            }
        }

        private void UnblockCitizen_Load(object sender, EventArgs e) {}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

