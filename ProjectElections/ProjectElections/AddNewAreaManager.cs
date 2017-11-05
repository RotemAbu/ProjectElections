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
    public partial class AddNewAreaManager : Form
    {
        private ElectionsManager electionsManager;

        bool update;

        public AddNewAreaManager(ElectionsManager eM,bool _update=false)
        {
            InitializeComponent();
            electionsManager = eM;
            update = _update;
            if (update)
                this.setUpdateMenu();
        }

        public void setUpdateMenu()
        {
            label13.Visible = false;
            AccomulateIDtextBox.Visible = false;
            IsBlockedcheckBox.Visible = false;
            IsVotedcheckBox.Visible = false;
            button1.Text = "Update Area Manager details";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Try&Catch block to check if the currect inputs are in, if not show currect message and let the user to try again.
            //If succeeded elections manager call addNewAreaManager method and create new area manager. 
            if (!this.update)
            {
                try
                {
                    //flag-for returning a result.
                    int flag = electionsManager.addnewAreaManager(idtextBox.Text, FirstNametextBox.Text, LastNametextBox.Text, UserNametextBox.Text, PasswordtextBox.Text, "3", brithDate.Value, AddresstextBox.Text, AreatextBox.Text, CitytextBox.Text, TelltextBox.Text, AccomulateIDtextBox.Text);

                    if (flag == 1)
                    {
                        MessageBox.Show("Add New area manager succeeded!");
                    }
                    else
                    {
                        MessageBox.Show("Add New area manager failed!");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                    // this.Close();
                }
            }
            else
            {
                string res = electionsManager.updateAreaManager(idtextBox.Text, FirstNametextBox.Text, LastNametextBox.Text ,
                                                             UserNametextBox.Text, PasswordtextBox.Text, brithDate.Value ,
                                                             AddresstextBox.Text, AreatextBox.Text, CitytextBox.Text,
                                                             TelltextBox.Text);
                if (res == "0")
                {
                    MessageBox.Show("Can't find area manager ID!");
                }
                else 
                {
                    MessageBox.Show("Area manager details succesfully updated!");
                    this.Close();
                }
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
