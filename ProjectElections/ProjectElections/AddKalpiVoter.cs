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
    public partial class AddKalpiVoter : Form
    {
        
        private const int SIZEID = 9;
        AreaManager areaManager;
        public AddKalpiVoter(AreaManager areaManager)
        {
            this.areaManager = areaManager;
            InitializeComponent();
        }

        /// <summary>
        /// The 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!(Char.IsDigit(key)) && key != 8)
            {
                e.Handled = true;
            }
        }

        private Boolean CheckId(string id)
        {
            return id.Length == SIZEID;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckId(IdTextBox.Text))
            {
                String val = areaManager.addKalpiToVoter(IdTextBox.Text, KalpiCodeTextBox.Text);

                if (val == "1")
                {
                    MessageBox.Show("Added successfully");
                }
                else if (val == "0")
                {
                    MessageBox.Show("Id is not Valid");
                }
                else
                {
                    MessageBox.Show("Kalpi Code not Valid");
                }
            }
            else
            {
                MessageBox.Show("The size of the improper ID");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
