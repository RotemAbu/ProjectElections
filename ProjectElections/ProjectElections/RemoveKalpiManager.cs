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
    /// <summary>
    /// allows the user to remove a Kalpi Manager:
    /// search for the Kalpi Manager by id, if he exists shows his details and his kalpi details
    /// then turn him to a simple voter, and deleting his id from the kalpi.  
    /// </summary>
    public partial class RemoveKalpiManager : Form
    {
        private AreaManager area_mngr;
        private Voter kalpi_mngr;
        private Kalpi kalpi;
        private bool search_success;       

        public RemoveKalpiManager(AreaManager mngr)
        {
            InitializeComponent();
            area_mngr = mngr;
            search_success = false;
        }

        /// <summary>
        /// check if inputted id is an integer length 9
        /// </summary>
        /// <returns>true if the id is valid, false - if not.</returns>
        private bool isIdValid()
        {
            uint n;
            return (IDtextBox.Text.Length == 9 && uint.TryParse(IDtextBox.Text, out n));           
        }

        

        /// <summary>
        /// make all text boxes blank
        /// </summary>
        private void clearFields()
        {
            
            first_text.Text = "";            
            last_text.Text = "";
            address_text.Text = "";
            phone_text.Text = "";
            code_text.Text = "";
            area_text.Text = "";
            city_text.Text = "";
            location_text.Text = "";            
        }

        /// <summary>
        /// Search for kalpi manager by his id, and show his details and his kalpi details 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_button_Click(object sender, EventArgs e)
        {
            clearFields();
            search_success = false;

            if (isIdValid() == false)
            {
                MessageBox.Show("Enter Valid ID.");
            }
            else
            {
                kalpi_mngr = area_mngr.SearchKalpiManager(IDtextBox.Text.ToString().Trim(), area_mngr.Area);
                if (kalpi_mngr == null)
                {
                    MessageBox.Show("No such kalpi manager in " + area_mngr.Area + " area.");
                }
                else
                {
                    search_success = true;

                    first_text.Text = kalpi_mngr.FName;
                    last_text.Text = kalpi_mngr.LName;
                    address_text.Text = kalpi_mngr.Address + ", " + kalpi_mngr.City;
                    phone_text.Text = kalpi_mngr.Tell;

                    kalpi = area_mngr.SearchKalpiByManager(IDtextBox.Text.ToString().Trim());
                    if (kalpi != null)                    
                    {
                        code_text.Text = kalpi.KalpiCode;
                        area_text.Text = kalpi.Area;
                        city_text.Text = kalpi.City;
                        location_text.Text = kalpi.Address;
                    }                    
                }
            }

        }

        /// <summary>
        /// Remove Kalpi Manager after finding him by his id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void remove_button_Click(object sender, EventArgs e)
        {
            if (search_success == false)
            {
                MessageBox.Show("First search for the kalpi manager you wish to remove");
            }
            else{
                DialogResult result = MessageBox.Show("Are you sure you want to remove the Kalpi Manager?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string value = area_mngr.RemoveKalpiManager(kalpi_mngr.Id);
                    if (value == "1")
                    {
                        MessageBox.Show("Kalpi Manager Successfully Removed.");   
                     
                    }else if (value == "0"){
                        MessageBox.Show("Kalpi Manager doesn't exist.");

                    }else{                       
                        MessageBox.Show("Error Removing Kalpi Manager.");
                    }

                    clearFields();
                    search_success = false;
                    IDtextBox.Text = "";
                }
                
            }
        }

        /// <summary>
        /// Close this GUI when exit button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       

        /// <summary>
        /// clear fields if a different id is typed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            clearFields();
            search_success = false;           
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}
