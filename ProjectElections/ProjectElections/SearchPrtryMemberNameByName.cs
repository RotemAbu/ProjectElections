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
    public partial class SearchPartyMemberByName : Form
    {
        private Voter voter;
        private List<PartyMember> party;
        public SearchPartyMemberByName(Voter voter)
        {
            InitializeComponent();
            this.voter = voter;
            comboBox1.Text = "Select Name From List";
        }

        private void Serach_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Text = "Select Name From List";
                comboBox1.Items.Clear();
                party = voter.searchPartyNameBy(idName.Text);
                if (party.Count ==0)
                {
                    throw new Exception();
                }
                foreach (PartyMember i in party ){
                    comboBox1.Items.Add(i.FName + " " + i.LName);
                }
            }
            catch
            {
                MessageBox.Show("Not Exist such Name in System");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberCode.Text = party[comboBox1.SelectedIndex].MemberCode.ToString();
            namePartyMember.Text = party[comboBox1.SelectedIndex].PartyName;
            name.Text = party[comboBox1.SelectedIndex].FName;
            lastName.Text = party[comboBox1.SelectedIndex].LName;
            brithDay.Text = party[comboBox1.SelectedIndex].GetDobstring();
            expirence.Text = party[comboBox1.SelectedIndex].Experience;
            education.Text = party[comboBox1.SelectedIndex].Education;
            numberOfList.Text = party[comboBox1.SelectedIndex].ListPlace.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
