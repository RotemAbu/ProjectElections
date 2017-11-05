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
    public partial class AddNewKalpiManager : Form
    {
        private AreaManager area_manager;
        sqlConnection con;

        public AddNewKalpiManager(AreaManager area_m)
        {
            InitializeComponent();
            area_manager = area_m;
            con = sqlConnection.Instance;
        }

        private void AddNewKalpiManager_Load(object sender, EventArgs e)
        {
            textBox.Text = area_manager.Area; //set the same area to the new kalpi manager

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            comboBox1.Text = "Select"; //show at first "select"
            con.sqlCommand("SearchKalpiesByArea"); //the procedure
            con.InsertValstring("@area", area_manager.Area); //pass the area manager area
            String result = con.getVal("@Result");
            if (result.Equals("1"))
            {
              con.sqlCommand("ReturnKalpiCode"); //the procedure
              DataTable KalpiCode = con.GetData("ReturnKalpiCode");
              
              foreach (DataRow code in KalpiCode.Rows)
                  comboBox1.Items.Add(code["kalpiCode"].ToString()); //add kalpies codes
            }
            else
            {
                MessageBox.Show("There are no kalpies who don't hava manager");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {}

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (id.Text.Trim() == "" || fname.Text.Trim() == "" || lname.Text.Trim() == "" || username.Text.Trim() == "" || password.Text.Trim() == "" || address.Text.Trim() == "" || city.Text.Trim() == "" || tell.Text.Trim() == "" || comboBox1.SelectedItem.ToString() == "Select")
               {
                    MessageBox.Show("One or more of the fields is empty.");
                    return;
               }
           

            if (id.Text.Length == 9)
            {

                try
                {
                    if (area_manager.AddNewKalpiManagerToArea(id.Text.Trim(), fname.Text.Trim(), lname.Text.Trim(), username.Text.Trim(), password.Text.Trim(), dob.Value, address.Text.Trim(), city.Text.Trim(), tell.Text.Trim(), area_manager.Area, comboBox1.SelectedItem.ToString()) == 1) //flag-for returning a result.
                    {
                        MessageBox.Show("Kalpi manager successfully add to area");
                    }

                    else
                    {
                        id.Text = "";
                        MessageBox.Show("Already exist voter with this id, please re enter new id");
                    }
                }
                catch
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                id.Text = "";
                MessageBox.Show("Id is not valid, please enter 9 characters.");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            this.Close();
        }
    }
}
