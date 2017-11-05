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
    public partial class UpdateKalpiDetails : Form
    {
        private AreaManager manager;

        public UpdateKalpiDetails(AreaManager v)
        {
            InitializeComponent();
            manager = v;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                  
                        DataRow temp = manager.SearchKalpiByArea(textBoxKal.Text.Trim(), manager.Area);
                        DataRow kalpi = temp;
                        textBoxAdres.Text = kalpi["address"].ToString();
                        textBoxcity.Text = kalpi["city"].ToString();
                        textBoxArea.Text = kalpi["area"].ToString();
                        textBox1.Text = kalpi["kalpiName"].ToString();
                        textBoxcity.Enabled = true;
                        textBoxArea.Enabled = true;
                        textBoxAdres.Enabled = true;
                        textBox1.Enabled = true;
                    
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
                if (manager.UpdateKalpi(textBoxKal.Text.Trim(), textBoxAdres.Text.Trim(),textBoxArea.Text.Trim(),textBoxcity.Text.Trim(),textBox1.Text.Trim()).Equals("1"))
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

        private void UpdateKalpiDetails_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
