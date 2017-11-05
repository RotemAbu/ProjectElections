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
    public partial class RemoveMember : Form
    {
        PartyMember p;
        ElectionsManager manager;
        public RemoveMember(ElectionsManager v)
        {
            InitializeComponent();
            manager = v;
        }
        private void textBox1_TextChanged(object sender, EventArgs e){}
        /// <summary>
        /// This method calld when the user ( Elections Manager) press on the remove button.
        /// If the removing succeseed, a success message presented on the screen, if not an error message presented.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                manager.removePartyMember(int.Parse(memberCode1.Text.Trim()), party.Text.Trim(),memberName.Text.Trim(),
                    memberLName.Text.Trim(),DateTime.Parse(dob.Text.Trim()),int.Parse(listplace.Text.Trim()),
                    educ.Text.Trim(),exp.Text.Trim());
                if ((p.Mode==true)&&p.RemoveMember().Equals("1"))
                {
                    MessageBox.Show("Removed succesfully!");
                    mode.Text = "False".ToString();

                }
                else
                {
                    MessageBox.Show("Failed, already removed");
                }
            }
            catch
            {
                MessageBox.Show("Worng values, try again!");
            }
        }
        private void exBtn_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void RemoveBtn_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void edu_Click(object sender, EventArgs e) {}
        /// <summary>
        /// The function search if the member exist or not.If the member exists ,his details are presented to the screen if not error messege
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nbtn_Click(object sender, EventArgs e)
        {
            try
            {
                p = new PartyMember();
                DataRow t = p.SerachMember(int.Parse(memberCode1.Text));
                p = new PartyMember(t);
                party.Text = p.PartyName;
                memberName.Text = p.FName;
                memberLName.Text = p.LName;
                dob.Text = p.GetDobstring();
                expe.Text = p.Experience;
                educ.Text = p.Education;
                mode.Text = p.Mode.ToString();
                listplace.Text = p.ListPlace.ToString();
            }
            catch
            {
                MessageBox.Show("The member code not exist in the system");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
