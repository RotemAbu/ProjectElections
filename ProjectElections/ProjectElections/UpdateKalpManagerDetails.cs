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
    public partial class UpdateKalpManagerDetails : Form
    {
        private AreaManager manager;

        public UpdateKalpManagerDetails(AreaManager v)
        {
            InitializeComponent();
            manager = v;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                    DataRow temp = manager.SearchKalpiManagerByKalpiCode(textBoxKalp.Text.Trim(), manager.Area);
                    textBox1.Text = temp["fname"].ToString();
                    textBox2.Text = temp["lname"].ToString();
                    textBox3.Text = temp["id"].ToString();
                    textBox4.Text = temp["address"].ToString();
                    textBox5.Text = temp["city"].ToString();
                    textBox7.Text = temp["area"].ToString();
                    textBox8.Text = temp["tell"].ToString();

                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    textBox7.Enabled = true;
                    textBox8.Enabled = true;
                }

            
            catch
            {
                MessageBox.Show("The kalpi code not exist in the system");
            }
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (manager.UpdateKalpiManager(textBoxKalp.Text.Trim(), textBox1.Text.Trim(), textBox2.Text.Trim(),textBox3.Text.Trim(), textBox4.Text.Trim(), textBox5.Text.Trim(), textBox7.Text.Trim(), textBox8.Text.Trim()).Equals("1"))
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void exBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxKalp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
