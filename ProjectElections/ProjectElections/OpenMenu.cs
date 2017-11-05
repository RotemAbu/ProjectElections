using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectElections
{
    /// <summary>
    /// the class is responsible for opening the correct user menu, implements interface ICommand
    /// </summary>
    class OpenMenu: ICommand
    {
        /// <summary>
        /// the method opens the required user menu according to permission of given user
        /// </summary>
        /// <param name="voter">the user whose menu needs to be opened</param>
        public void execute(Voter voter)
        {
            switch (voter.Permission)
            {
                case "0":
                    using (VoterMenu vote = new VoterMenu(voter))
                    {
                        vote.ShowDialog();//show voter menu.
                    }                    
                    break;

                case "2":
                    using (KalpiManagerMenu k_man = new KalpiManagerMenu(((KalpiManager)voter)))
                    {
                        k_man.ShowDialog();//show kalpi menager menu.
                    }
                    break;
                 
                case "1":
                    using (ManagerMenu man = new ManagerMenu(((ElectionsManager)voter)))
                    {
                        man.ShowDialog();//show elections menager menu.
                    }
                    break;

                case "3":
                    using (AreaManagerMenu area_man = new AreaManagerMenu(((AreaManager)voter)))
                    {
                        area_man.ShowDialog();//show area menager menu.
                    }
                    break;

                default:
                    MessageBox.Show("Unknown permission");
                    break; 
            }
        }
    }
}
