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
    public partial class addAccompanierId : Form
    {
        Voter vot;
        public addAccompanierId(Voter vot)
        {
            this.vot = vot;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// The function add a new Accompanier</summary>
        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            bool success = int.TryParse(textBox1.Text, out i);
            if (textBox1.Text.Length == 9 && success == true && int.Parse(textBox1.Text) > 0) // Checks for valid input
            {
                vot.addAccompanierId(textBox1.Text, vot.Id);
                MessageBox.Show("Add Accompanier Id is Succeeded");
                this.Close();
            }
            else { MessageBox.Show("The id is invalid!"); }
        }
        private void addAccompanierId_Load(object sender, EventArgs e){}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
