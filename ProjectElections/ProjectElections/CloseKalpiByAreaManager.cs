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
    public partial class CloseKalpiByAreaManager : Form
    {
       AreaManager manager;
       public CloseKalpiByAreaManager(AreaManager v)
        {
            InitializeComponent();
            manager = v;
            try
            {
                //Show the Manager details on the screen
                textBox1.Text = manager.Id;
                textBox2.Text = manager.FName;
                textBox3.Text = manager.LName;
                textBox4.Text = manager.City;
                textBox5.Text = manager.Address;
                textBox6.Text = manager.Area;
            }
            catch
            {
                MessageBox.Show("Try again");
            }
        } 

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseKalpiByAreaManager_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (manager.CloseKalpiByManagerArea(textBox6.Text.Trim()).Equals("1"))
                {
                    MessageBox.Show("All the kalpies are now closed");
                }
                else
                {
                    MessageBox.Show("Close failed");
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
