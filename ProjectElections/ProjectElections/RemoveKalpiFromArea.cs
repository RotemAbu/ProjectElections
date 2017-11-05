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
    public partial class RemoveKalpiFromArea : Form
    {
        AreaManager areaManager;
        public RemoveKalpiFromArea(AreaManager areaMan)
        {
            InitializeComponent();
            areaManager = areaMan;
        }

        private void RemoveKalpiFromArea_Load(object sender, EventArgs e)
        {
            fillDtatGridView();
        }

        private void fillDtatGridView()
        {
            this.kalpiTableAdapter.Fill(this.electionsProjectDataSet.Kalpi);
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "area like '%" + areaManager.Area + "%'" + "and mode=1";
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kalpiCode;

            try
            {
                kalpiCode = (dataGridView1.SelectedRows[0].Cells[0].Value).ToString().Trim();
            }
            catch
            {
                MessageBox.Show("You did not select a row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                areaManager.removeKalpi(kalpiCode);
            }
            catch
            {
                MessageBox.Show("Error with procedure.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            fillDtatGridView();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
