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
    public partial class Form1 : Form
    {
        private Voter voter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Login login = new Login())//open login window.
            {
                if (login.ShowDialog() == DialogResult.OK)//if all details of the user are matched to data base.
                {
                    voter = (Voter)login.get();
                    var factory = new FactroryVoter() as ICreateVoters; //factory that creates voters
                    voter = factory.createVoter(voter); //create a user according to permission   
                    if (voter.LastConnection.AddMonths(2) < DateTime.Now.Date)
                    {
                        try
                        {
                            String val = RemoveVoter(voter.Id);
                            if (val == "1")
                            {
                                MessageBox.Show("The user can not enter to system , due the fact that the user not enter to system more then 2 months ");
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else if (Math.Abs((voter.LastConnection - DateTime.Now.Date).TotalDays) <= 61 && Math.Abs((voter.LastConnection - DateTime.Now.Date).TotalDays) >= 29)
                    {
                        using (changePass changepass = new changePass(voter))
                        {
                            if (!(changepass.ShowDialog() == DialogResult.OK))
                            {
                                this.Close();
                            }
                            else
                            {
                                UpdateLastDate(voter.Id);
                            }

                        }
                    }
                    else
                    {
                        //update date lsat 
                        try
                        {
                            UpdateLastDate(voter.Id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            this.Close();
                        }
                    }
                }
            }

            try
            {

                OpenMenu command = new OpenMenu(); //create a new command, that opens user menues
                command.execute(voter); //open the correct menu of current user              

            }
            catch
            {

            }
            finally
            {
                this.Close();
            }
        }

        private string RemoveVoter(string id)
        {
            sqlConnection con = sqlConnection.Instance;
            con.sqlCommand("RemoveVoter");
            con.InsertValstring("@id", id);
            return con.getVal("@result");
        }
        private string UpdateLastDate(string id)
        {
            sqlConnection con = sqlConnection.Instance;
            con.sqlCommand("UpdateLastDate");
            con.InsertValstring("@id", id);
            con.InsertValDate("@lastdate", DateTime.Now.Date);
            return con.getVal("@result");
        }
    }
}
