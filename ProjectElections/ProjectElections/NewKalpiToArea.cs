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
    public partial class NewKalpiToArea : Form
    {
        AreaManager areaManager;
        
        public NewKalpiToArea(AreaManager areaMan)
        {
            InitializeComponent();
            areaManager = areaMan;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Trim() == "" || textBoxCity.Text.Trim() == ""
                || textBoxCode.Text.Trim() == "" || textBoxKalpiName.Text.Trim() == ""
                || textBoxMaxVoters.Text.Trim() == "")
            {
                MessageBox.Show("One or more of the fields is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maxVoters = 0;

            try
            {
                maxVoters = int.Parse(textBoxMaxVoters.Text.Trim());
                if (maxVoters <= 0 || maxVoters > 1000)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Invalid input in 'maximum Voters'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Kalpi kalpi = new Kalpi(textBoxCode.Text, "", textBoxKalpiName.Text, textBoxAddress.Text, textBoxCity.Text, areaManager.Area, 0, maxVoters, true);
                int flag = areaManager.addNewKalpi(kalpi);
                if(flag == 1)
                {
                    MessageBox.Show("The new Kalpi added to the DataBase.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There is already kalpi with that kalpiCode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Add New Kalpi Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
