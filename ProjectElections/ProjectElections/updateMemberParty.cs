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
    public partial class updateMemberParty : Form
    {
        PartyMember p;
        ElectionsManager manager;
        public updateMemberParty(ElectionsManager v)
        {
            InitializeComponent();
            manager = v;
        }

        private void Serach_Click(object sender, EventArgs e)
        {
            try
            {
                p = new PartyMember();
                DataRow t = p.SerachMember(int.Parse(idNumberCode.Text));
                p = new PartyMember(t);
                numberCode.Text = p.MemberCode.ToString();
                namePartyMember.Text = p.PartyName;
                name.Text = p.FName;
                lastName.Text = p.LName;
                brithDay.Text = p.GetDobstring();
                expirence.Text = p.Experience;
                education.Text = p.Education;
                numberOfList.Text = p.ListPlace.ToString();
            }
            catch
            {
                MessageBox.Show("Doesn't Exist such code in System");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //p.Experience = expirence.Text;
                //p.Education = education.Text;
                //p.ListPlace = int.Parse(numberOfList.Text);
                //p.PartyName = namePartyMember.Text;
                //p.SetDob( DateTime.Parse(brithDay.Text));
                //p.FName = name.Text;
                //p.LName = lastName.Text;
                //p.ListPlace = int.Parse(numberOfList.Text);

                if (manager.UpdateMemberParty(p.MemberCode,expirence.Text, education.Text, int.Parse(numberOfList.Text), namePartyMember.Text, DateTime.Parse(brithDay.Text), name.Text, lastName.Text).Equals("1"))
                {
                    MessageBox.Show("Successfully updated");
                }
                else
                {
                    MessageBox.Show("Please check the name of the party or the party location");
                }
            }
            catch
            {
                MessageBox.Show("One of the data entered incorrect");
            }
        }

        private void idNumberCode_TextChanged(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void groupBox4_Enter(object sender, EventArgs e){}
        private void groupBox1_Enter(object sender, EventArgs e){}
        private void expirence_TextChanged(object sender, EventArgs e){}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
