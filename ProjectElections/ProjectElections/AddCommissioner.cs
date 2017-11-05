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
    public partial class AddCommissioner : Form
    {
        private ElectionsManager electionManager;
        private KalpiManager KalpiManager;
        private Voter worker;
        private Boolean flag;

        private sqlConnection con;
        private DataTable cities;
        private static string PROC_CITIES = "getCities";

        public AddCommissioner(ElectionsManager man)
        {
            InitializeComponent();
            con = sqlConnection.Instance;
            electionManager = new ElectionsManager(man);
            KalpiManager = new KalpiManager(man);
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
                worker = electionManager.SearchWorker(id);
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

        private void UpdateJobButton_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                worker.Permission = "Commissioner";
                string value = electionManager.updateWorker(worker.Id,worker.KalpiCode,worker.FName,worker.LName,worker.username,worker.Passowrd,worker.Permission,worker.DOB,worker.Address,worker.Area,worker.City,worker.Tell);
                if (value == "1")
                {
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
            else if (flag)
            {
                MessageBox.Show("You need try to sreach Worker");
            }
           
        }

        private void addVoterButton_Click(object sender, EventArgs e)
        {
            KalpiManager.City = comboBoxCity.Text;

            using (AddNewVoterToKalpi voter = new AddNewVoterToKalpi(KalpiManager))
            {
                voter.ShowDialog();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.sqlCommand(PROC_CITIES);
            con.InsertValstring("@area", comboBoxArea.Text);
            cities = con.GetData(PROC_CITIES);

            comboBoxCity.Text = "Select";

            comboBoxCity.Items.Clear();
            foreach (DataRow city in cities.Rows)
                comboBoxCity.Items.Add(city["City"].ToString());
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
