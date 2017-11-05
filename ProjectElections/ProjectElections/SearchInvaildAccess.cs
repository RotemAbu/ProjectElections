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
    public partial class SearchInvaildAccess : Form
    {
        sqlConnection con;
        private Voter voter;
        public SearchInvaildAccess(Voter v)
        {
      
            InitializeComponent();
            voter = v;
            con = sqlConnection.Instance;
        }
        //the procedur of searching invalid kalpies
        private void butt_Click(object sender, EventArgs e)
        {
            comBox1.Text = "Select"; //show at first "select"
            con.sqlCommand("SearchKalpiByCity"); //the procedure
            con.InsertValstring("@city", voter.City);
            String result = con.getVal("@Result");
            if(result.Equals("1"))
            {
                con.sqlCommand("SearchInvalidKalpies"); //the procedure
                con.InsertValstring("@city", voter.City);
                DataTable KalpiCode = con.GetData("SearchInvalidKalpies");
                
                foreach (DataRow code in KalpiCode.Rows)
                   comBox1.Items.Add(code["kalpiCode"].ToString()); //add kalpies codes
            }
            else
            {
                MessageBox.Show("There are no kalpies with invalid access");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //the procedure to update the choose of the invalid kalpi in the relevent city
        private void butt8_Click(object sender, EventArgs e)
        {
           try
            {
                con.sqlCommand("UpdateInvalidKalpiChoose"); //the procedure
                con.InsertValstring("@id", voter.Id);
                con.InsertValstring("@kalpiCode", comBox1.Text);
                String result = con.getVal("@Result");
                if (result.Equals("1")) MessageBox.Show("Your choose is saved");
            }
            catch
            {
                MessageBox.Show("Your kalpi choose faild");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchInvaildAccess_Load(object sender, EventArgs e)
        {

        }
    }
}
