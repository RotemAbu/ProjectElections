using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectElections
{
    public partial class UpdatePartyDetails : Form
    {
        ElectionsManager manager;
        public UpdatePartyDetails(ElectionsManager v)
        {
            InitializeComponent();
            manager = v;
        }
        private void label2_Click(object sender, EventArgs e){}
        private void Updatebt_Click(object sender, EventArgs e)
        {
            try
            {
                if (manager.UpdatePartyDetails(textBox4.Text.Trim(), int.Parse(textBox3.Text.Trim()), textBox2.Text.Trim()).Equals("1"))
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void Exbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e){}
        private void HC_Click(object sender, EventArgs e) { }
        /// <summary>
        /// The function calld when the user press on the button "search". 
        /// This method using the function SerachParty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow t = manager.SerachParty(textBox4.Text);// Using the function searchParty, to find the relevent party.
                Parties party = new Parties(t);// Creating Party object
                //Show the party details on the screen
                textBox4.Text = party.PartyName;
                textBox3.Text = party.MembersSize.ToString();
                textBox2.Text = party.Platform;
                textBox3.Enabled = true;
                textBox2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("The party name not exist in the system");
            }
        }
        private void UpdatePartyDetails_Load(object sender, EventArgs e){}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

