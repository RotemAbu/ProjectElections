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
    public partial class RemoveWorker : Form
    {
        private KalpiManager manager;
        private Voter worker;
        private Boolean flag;
      
        public RemoveWorker(KalpiManager k_mngr)
        {
            InitializeComponent();
            manager = new KalpiManager(k_mngr);
            worker = null;
            flag = false;
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private Boolean CheckId(string id)
        {
            return id.Length == 9;
        }

        private void SearchWorker(string id)
        {
            if (CheckId(id))
            {
                worker = manager.SearchWorker(id);
                if (worker != null)
                {
                    idTextBox.Text = worker.Id;
                    kalpiCodeTextBox.Text = worker.KalpiCode;
                    NameTextBox.Text = worker.FName;
                    LastNameTextBox.Text = worker.LName;
                    UserNameTextBox.Text = worker.username;
                    PasswordTextBox.Text = worker.Passowrd;
                    JobTextBox.Text = worker.Permission;
                    dateTimePicker1.Value = worker.DOB;
                    AddresTextBox.Text = worker.Address;
                    AreaTextBox.Text = worker.Area;
                    CityTextBox.Text = worker.City;
                    PhoneTextBox.Text = worker.Tell;
                    flag = true;
                }
                else
                {
                    MessageBox.Show("The Worker not exists");
                    flag = false;
                    ClearDetails();
                }
            }
            else
            {
                MessageBox.Show("The size of the improper ID");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchWorker(idTextBoxSearch.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (flag && worker.Permission!="2")
            {
                string value = manager.DeleteWorker(worker);
                if (value == "1" )
                {
                    MessageBox.Show("Successfully Removed");
                    this.DialogResult = DialogResult.OK;
                }
                else if (value == "0")
                {
                    MessageBox.Show("The Worker not exists");
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show(value);
                }
            }
            else if(flag)
            {
                MessageBox.Show("You Try Remove Manager , You cant do that");
            }
           
        }

        private void ClearDetails()
        {
            idTextBox.Text = "";
            kalpiCodeTextBox.Text = "";
            NameTextBox.Text = "";
            LastNameTextBox.Text = "";
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
            JobTextBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            AddresTextBox.Text = "";
            AreaTextBox.Text = "";
            CityTextBox.Text = "";
            PhoneTextBox.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
