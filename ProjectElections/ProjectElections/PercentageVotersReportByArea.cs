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
    public partial class PercentageVotersReportByArea : Form
    {

        private AreaManager area_manager;
        private sqlConnection con;

        public PercentageVotersReportByArea(AreaManager area_m)
        {
            InitializeComponent();
            area_manager = area_m;
            con = sqlConnection.Instance;
        }

        private void PercentageVotersReportByArea_Load(object sender, EventArgs e)
        {
            double amount = 0, sum = 0;
            
            con.sqlCommand("ReturnKalpiesCodes");
            con.InsertValstring("@area", area_manager.Area);
            DataTable KalpiCode = con.GetData("ReturnKalpiesCodes");


            for (int i = 0; i < KalpiCode.Rows.Count; i++)
            {
                DataRow code = KalpiCode.Rows[i];
                con.sqlCommand("getSumOfVoters");
                con.InsertValstring("@kalpiCode", code["kalpiCode"].ToString());
                DataTable amou = con.GetData("getSumOfVoters");
                sum += amou.Rows.Count;

            }

            con.sqlCommand("getAmountVOtersInArea");
            con.InsertValstring("@area", area_manager.Area);
            DataTable temp = con.GetData("getAmountVOtersInArea");


            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow perVoters = temp.Rows[i];
                amount += int.Parse(perVoters["votersAmount"].ToString());
            }

           textBox.Text = ((sum * 100) / amount).ToString() + "%";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
