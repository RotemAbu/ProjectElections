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
    public partial class Login : Form
    {
        private sqlConnection con;
        private Voter user;
        public Object get()
        { return user;  }

        public Login() //class constructor
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
            con = sqlConnection.Instance;
        }
    
        public Boolean login(string id, string username, string password)//this function check the details accordingly to the data base.
        {
            con.sqlCommand("login");
            con.InsertValstring("@id", id.Trim());
            con.InsertValstring("@username", username.Trim());
            con.InsertValstring("@password", password.Trim());
            DataTable temp = con.GetData("login");

            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "")) //check if One or more of the fields are empty.
            {
                MessageBox.Show("One or more of the fields are empty");
                return false;
            }
            try
            {
                int.Parse(textBox1.Text);//check id field - contain only numbers.
            }
            catch
            {
                MessageBox.Show("Invalid input in Id Field");
                return false;
            }
            if (temp.Rows.Count > 0)
            {
                var factory = new FactroryVoter() as ICreateVoters;                
                user = factory.createVoter(temp.Rows[0]);//if the user found in data base
                return true;
            }
            else
            {
                MessageBox.Show("Doesn't Exist In Data Base!!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";//clean fields
                return false;
            }
        }
        private void Login_Load(object sender, EventArgs e){}
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (login(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                this.DialogResult = DialogResult.OK;//all the details match - enter to system.
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e){}
        private void textBox1_TextChanged_1(object sender, EventArgs e){}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text.Equals("Show Password"))//change visibility of the password for security.
            {
                linkLabel1.Text = "Hide Password";
                textBox3.PasswordChar = '\0';
            }
            else
            {
                linkLabel1.Text = "Show Password";
                textBox3.PasswordChar = '*';
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you stay in your safe zone, and not making decision Nothing happens for better or worse...");
        }
    }
}
