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
    public partial class AddWorkerToKalpi : Form
    {
        private string[] JOBS = { "Kalpi Member", "Deputy Manager", "Guard", "Usher" };

        private bool update;

        KalpiManager mannger;

        public AddWorkerToKalpi(KalpiManager k_mngr, bool _update = false)
        {
            InitializeComponent();
            FillComboBoxJobs();
            JobComboBox.SelectedIndex = 0;
            mannger = new KalpiManager(k_mngr);
            update = _update;
            kalpiCodeTextBox.Text = mannger.KalpiCode;
            if (update)
            {
                groupBox.Text = "Update Worker";
            }
        }

        public void FillComboBoxJobs()
        {
            for (int i = 0; i < JOBS.Length; i++)
            {
                JobComboBox.Items.Add(JOBS[i]);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            PhoneTextBox.Text = "";
            CityTextBox.Text = "";
            AreaTextBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            JobComboBox.SelectedIndex = 0;
            NameTextBox.Text = "";
            LastNameTextBox.Text = "";
            PasswordTextBox.Text = "";
            UserNameTextBox.Text = "";
            AddresTextBox.Text = "";
            idTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private Boolean CheckedBirthDay(DateTime birthDay)
        {
            int age = DateTime.Now.Year - birthDay.Year;
            if (DateTime.Now.Month < birthDay.Month || (DateTime.Now.Month == birthDay.Month && DateTime.Now.Day < birthDay.Day))
            {
                age--;
            }

            return age >= 18;

        }

        private Boolean CheckID(string id)
        {
            return id.Length == 9;
        }

        private Boolean CheckDetails(string kalpiCode, string name, string lastname, string username, string password, string permission, string addres, string area, string city, string tell)
        {
            if (kalpiCode == "" || name == "" || lastname == "" || username == "" || password == "" || permission == "" || addres == "" || area == "" || city == "" || tell == "")
            {
                return false;
            }
            return true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CheckDetails(kalpiCodeTextBox.Text, NameTextBox.Text, LastNameTextBox.Text, UserNameTextBox.Text,
               PasswordTextBox.Text, JobComboBox.Text, AddresTextBox.Text, AreaTextBox.Text,
               CityTextBox.Text, PhoneTextBox.Text))
            {
                if (CheckID(idTextBox.Text))
                {

                    if (CheckedBirthDay(dateTimePicker1.Value))
                    {
                        /////////////////////////////////////////////////////////////////////////////
                        if (this.update == false)
                        {
                            string values = mannger.AddWorker(idTextBox.Text, kalpiCodeTextBox.Text, NameTextBox.Text, LastNameTextBox.Text, UserNameTextBox.Text,
                                PasswordTextBox.Text, JobComboBox.Text, dateTimePicker1.Value, AddresTextBox.Text, AreaTextBox.Text,
                               CityTextBox.Text, PhoneTextBox.Text);
                            if (values == "0")
                            {
                                MessageBox.Show("There is work in");
                            }
                            else if (values == "2")
                            {
                                MessageBox.Show("Username already exists in the system please correct me");
                            }
                            else
                            {
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            string result = mannger.updateWorker(idTextBox.Text, kalpiCodeTextBox.Text, NameTextBox.Text, LastNameTextBox.Text, UserNameTextBox.Text,
                                PasswordTextBox.Text, JobComboBox.Text, dateTimePicker1.Value, AddresTextBox.Text, AreaTextBox.Text,
                               CityTextBox.Text, PhoneTextBox.Text);
                            if (result == "1")
                            {
                                MessageBox.Show("Worker has updated!");
                            }
                            else
                            {
                                MessageBox.Show("worker id is not exist at database");
                            }
                            this.Close();
                        }
                        /////////////////////////////////////////////////////////////////////////////
                    }
                    else
                    {
                        MessageBox.Show("A person under the age of 18");
                    }
                }
                else
                {
                    MessageBox.Show("The size of the improper ID");
                }
            }
            else
            {
                MessageBox.Show("One input is empty");
            }
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
