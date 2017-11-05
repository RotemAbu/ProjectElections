using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectElections
{
    //a class that creates and returns different types of voters according to the request, implements interface ICreateVoters
    class FactroryVoter: ICreateVoters
    {
        /// <summary>
        /// method that creates Voters with details of a given voter.
        /// </summary>
        /// <param name="v">Voter whose details are used to create different voters</param>
        /// <returns> a new voter who is: Voter or Elections Manager or Kalpi Manager, according to permission </returns>
        public Voter createVoter(Voter v)
        {
            Voter tmp = null;

            switch (v.Permission)
            {
                case "0":
                    tmp = new Voter(v); //create casic voter
                    break;

                case "1":
                    tmp = new ElectionsManager(v); //create voter who is also an elections manager
                    break; 
              
                    
                case "2":
                    tmp = new KalpiManager(v); //create voter who is also a kalpi manager
                    break;

                case "3":
                    tmp = new AreaManager(new KalpiManager(v)); //create voter who is also a area manager
                    break;

                
                default:
                    tmp = new Voter(v); //create casic voter
                    break;
                 
            }
            return tmp;
        }

        /// <summary>
        /// //creates and returns default voters
        /// </summary>
        /// <returns>default Voter</returns>
        public Voter createVoter()
        {
            Voter tmp = null;
            tmp = new Voter();
            return tmp;
        }

        /// <summary>
        /// method that creates Voters with details from a given datarow.
        /// </summary>
        /// <param name="row">datarow from Voter table in database.</param>
        /// <returns>a new voter who is: Voter or Elections Manager or Kalpi Manager, according to permission</returns>
        public Voter createVoter(DataRow row)
        {
            Voter tmp = null;
            switch (row["permission"].ToString())
            {
                case "0":
                    tmp = new Voter(row);
                    break;

                case "1":
                    tmp = new ElectionsManager(row);
                    break;

                case "2":
                    tmp = new KalpiManager(row);
                    break;

                case "3":
                    tmp = new AreaManager(row);
                    break;
                
                    
                default:
                    tmp = new Voter(row); //create casic voter
                    break;
                     
            }
            return tmp;
        }
    }
}
