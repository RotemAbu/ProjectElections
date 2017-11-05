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
    public partial class RemoveVoterFromKalpi : Form
    {
        private Voter voter;
        private KalpiManager kalpiManager;

        public RemoveVoterFromKalpi(KalpiManager kal)
        {
            InitializeComponent();
            kalpiManager = kal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Try&Catch block to check if the currect inputs are in, if not show currect message and let the user to try again.
            //If succeeded manager call removeVoterKalpi method and remove the voter from Voter_T DB. 
            try
            {
                int flag = kalpiManager.removeVoterKalpi(IDtextBox.Text,kalpiManager.KalpiCode); //flag-for returning a result.

                if (flag == 1)
                {
                    MessageBox.Show("Removing Voter from Kalpi succeeded!");
                }
                else
                {
                    MessageBox.Show("Removing Voter from Kalpi failed!");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void nbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var factory = new FactroryVoter() as ICreateVoters; //factory that creates voters
                voter = factory.createVoter(); //create default Voter with the factory                
                DataRow t = voter.SearchVoterToRemove(IDtextBox.Text); //search for voter datarow in database
                voter = factory.createVoter(t); //create Voter with datarow details

                KalpiCodetextBox.Text = voter.KalpiCode;
                FirstNametextBox.Text = voter.FName;
                LastNametextBox.Text = voter.LName;
                UserNametextBox.Text = voter.username;
                PasswordtextBox.Text = voter.Passowrd;
                PermissiontextBox.Text = voter.Permission;
                DOBtextBox.Text = voter.DOB.ToString();
                AddresstextBox.Text = voter.Address;
                AreatextBox.Text = voter.Area;
                CitytextBox.Text = voter.City;
                TelltextBox.Text = voter.Tell;
                AccomulateIDtextBox.Text = voter.AccomId;
                IsBlockedcheckBox.Checked = voter.IsBlocked;
                IsVotedcheckBox.Checked = voter.IsVoted;
            }
            catch
            {
                MessageBox.Show("The voter not exist in the system");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
