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
    public partial class ShowKalpiesInArea : Form
    {
        private AreaManager area_manager;
        private sqlConnection con;

        public ShowKalpiesInArea(AreaManager area_m)
        {
            InitializeComponent();
            area_manager = area_m;
            con = sqlConnection.Instance;
        }


        private void ShowKalpiesInArea_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Select"; //show at first "select"
            con.sqlCommand("SearchKalpiesByArea"); 
            con.InsertValstring("@area", area_manager.Area); //pass the area manager area
            String result = con.getVal("@Result");
            if (result.Equals("1"))
            {
                con.sqlCommand("ReturnKalpiesCodes");
                con.InsertValstring("@area", area_manager.Area);
                DataTable KalpiCode = con.GetData("ReturnKalpiesCodes");

                foreach (DataRow code in KalpiCode.Rows)
                    comboBox1.Items.Add(code["kalpiCode"].ToString()); //add kalpies codes
            }
            else
            {
                MessageBox.Show("There are no kalpies in your area");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              
                con.sqlCommand("RetuenKalpiesDetails");
                con.InsertValstring("@kalpiCode", comboBox1.SelectedItem.ToString());
                DataTable temp = con.GetData("RetuenKalpiesDetails");

                DataRow kalpi = temp.Rows[0];
                textBox.Text = kalpi["kalpiCode"].ToString();
                textBox1.Text = kalpi["managerID"].ToString();
                textBox2.Text = kalpi["kalpiName"].ToString();
                textBox3.Text = kalpi["address"].ToString();
                textBox4.Text = kalpi["city"].ToString();
                textBox5.Text = kalpi["area"].ToString();
                textBox6.Text = kalpi["votersAmount"].ToString();
                textBox7.Text = kalpi["maxVoters"].ToString();
                if (kalpi["invalidAccess"].ToString().Equals("True"))
                {
                    checkBox.Checked = true;
                }
                else
                {
                    checkBox.Checked = false;
                }

                if (kalpi["openKalpi"].ToString().Equals("True"))
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
