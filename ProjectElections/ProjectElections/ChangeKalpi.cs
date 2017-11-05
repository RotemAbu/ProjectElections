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
    public partial class ChangeKalpi : Form
    {
        private static string PROC_CITIES = "getCities";
        private static string PROC_KALPI = "getKalpi";

        private Voter voter;
        private string kalpiCode;
        private sqlConnection con;

        private DataTable cities;
        private DataTable kName;

        public ChangeKalpi(Voter v)
        {
            InitializeComponent();
            voter = v;
            con = sqlConnection.Instance;
        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.sqlCommand(PROC_CITIES);
            con.InsertValstring("@area", comboBoxArea.Text);
            cities = con.GetData(PROC_CITIES);
            
            comboBoxCity.Text = "Select";
            comboBoxKalpiName.Text = "Select";

            comboBoxCity.Items.Clear();
            foreach (DataRow city in cities.Rows) 
                comboBoxCity.Items.Add(city["City"].ToString());
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.sqlCommand(PROC_KALPI);
            con.InsertValstring("@city", comboBoxCity.Text);
            kName = con.GetData(PROC_KALPI);

            comboBoxKalpiName.Text = "Select";

            comboBoxKalpiName.Items.Clear();
            foreach (DataRow kalpi in kName.Rows)
                comboBoxKalpiName.Items.Add(kalpi["kalpiName"].ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.sqlCommand("getKalpiCodeByCity");
            con.InsertValstring("@city",comboBoxCity.Text);
            DataTable kCode = con.GetData("getKalpiCodeByCity");

            foreach (DataRow code in kCode.Rows)
                if (code["kalpiName"].ToString() == comboBoxKalpiName.Text)
                    kalpiCode = code["kalpiCode"].ToString();

            try
            {
                int flag = voter.changeKalpiVote(kalpiCode);

                if (flag == 1)
                    MessageBox.Show("The kalpi is changed!", "message");
                else
                    MessageBox.Show("Error have been occured", "Error");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void ChangeKalpi_Load(object sender, EventArgs e) {}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
