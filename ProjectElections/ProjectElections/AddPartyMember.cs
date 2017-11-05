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
    public partial class AddPartyMember : Form
    {
        private ElectionsManager manager; 
        public AddPartyMember(ElectionsManager v)
        {
            InitializeComponent();
            manager = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string listPlace = listpalce.Text;
                int listPlac = int.Parse(listPlace);
                string codeMember = codePartyMember.Text;
                int code = int.Parse(codeMember);
                if (manager.newPartyMember(code, nameParty.Text, name.Text, lastName.Text, brithDate.Value, listPlac, expirence.Text, educasion.Text).Equals("1"))
                {
                    MessageBox.Show("Successfully added");
                }
                else
                {
                    MessageBox.Show("Already Exist In System Someone With This Details");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void listpalce_TextChanged(object sender, EventArgs e){}
        private void brithDate_ValueChanged(object sender, EventArgs e){}
        private void AddPartyMember_Load(object sender, EventArgs e){}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
