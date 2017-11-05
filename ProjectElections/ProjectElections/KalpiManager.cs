using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProjectElections;

namespace ProjectElections
{   
   //This class represents a Kalpi Manager, that extends a Voter
    public class KalpiManager: Voter
    {
        private sqlConnection con;
        
        //default constructor
        public KalpiManager():base()
        {
            con = sqlConnection.Instance;
        }

        /// <summary>
        /// a constructor that creates a kalpi manager with a given datarow
        /// </summary>
        /// <param name="voter">datarow with details from Voter table in database</param>
        public KalpiManager(DataRow voter):base(voter)
        {
            con = sqlConnection.Instance;
        }

        /// <summary>
        /// copy constructor
        /// </summary>
        /// <param name="v">another voter</param>
        public KalpiManager(Voter v)
            : base(v)
        {
            con = sqlConnection.Instance;
        }

        /// <summary>
        /// method that adds a voter with the given id to the kalpi of the kalpi manager that calls the method
        /// </summary>
        /// <param name="id">id of voter that is added</param>
        /// <param name="kalpiCode">kalpi code of current kalpi manager</param>
        /// <returns>1 id added successfully, 0 - therwise</returns>
        public int addNewVoterToKalpi(string id, string kalpiCode)
        {
            var factory = new FactroryVoter() as ICreateVoters;
            Voter v = factory.createVoter();
            v.Id = id;
            v.KalpiCode = kalpiCode;           
            return v.addNewVoterToKalpi(kalpiCode);
        }

        /// <summary>
        /// method that adds a new voter with the given all the details of the voter that calls the method
        /// </summary>
        /// <param name="id">id of voter that is added</param>
        /// <param name="kalpiCode">kalpi code of current kalpi manager</param>
        /// <param name="firstName">first name of current kalpi manager</param>
        /// <param name="lastName">last name of current kalpi manager</param>
        /// <param name="userName">user name of current kalpi manager</param>
        /// <param name="password">password of current kalpi manager</param>
        /// <param name="permission">permission of current kalpi manager</param>
        /// <param name="dob">date of birth of current kalpi manager</param>
        /// <param name="address">address of current kalpi manager</param>
        /// <param name="area">area of current kalpi manager</param>
        /// <param name="city">city of current kalpi manager</param>
        /// <param name="tell">tell of current kalpi manager</param>
        /// <param name="accomid">accomulate id of current kalpi manager</param>
        /// <returns>1 id added successfully, 0 - therwise</returns>
        public int addnewVoterToKalpi(string id, string kalpiCode, string firstName, string lastName, string userName, string password, string permission, DateTime dob, string address, string area, string city, string tell, string accomid)
        {
            var factory = new FactroryVoter() as ICreateVoters;
            Voter v = factory.createVoter();
            v.Id = id;
            v.KalpiCode = kalpiCode;
            v.FName = firstName;
            v.LName = lastName;
            v.username = userName;
            v.Passowrd = password;
            v.Permission = permission;
            v.DOB = dob;
            v.Address = address;
            v.Area = area;
            v.City = city;
            v.Tell = tell;
            v.AccomId = accomid;

            return v.addNewVoterToKalpi(id, kalpiCode, firstName, lastName, userName, password, permission, dob, address, area, city, tell, accomid);
        }

        /// <summary>
        /// method that removes a voter with a given id from the kalpi of the kalpi manager that calls the method
        /// </summary>
        /// <param name="id">id of the voter that needs to be removed</param>
        /// <param name="kalpiCode">the current kalpi code of the voter</param>
        /// <returns>1 if remove was successfull, 0- otherwise</returns>
        public int removeVoterKalpi(string id, string kalpiCode)
        {
            var factory = new FactroryVoter() as ICreateVoters;
            Voter v = factory.createVoter();
            v.Id = id;
            v.KalpiCode = kalpiCode;           
            return v.removeVoterFromKalpi();
        }

        /// <summary>
        /// the method adds an accompanier to a voter
        /// </summary>
        /// <param name="voter_id">id of the voter to whom the accompanier is added</param>
        /// <param name="accom_id">the id of the accompanier</param>
        public void AddAccompanierId(string voter_id, string accom_id)
        {
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@kalpi_code", base.KalpiCode);
            parm[1] = new SqlParameter("@voter_id", voter_id);
            parm[2] = new SqlParameter("@accomp_id", accom_id);
            sqlConnection.getTableBycommand("setVoterAccompByKalMan", parm);
        }
        
        /// <summary>
        /// the method searches for a voter in the data base
        /// </summary>
        /// <param name="id">the id of the wanted voter</param>
        /// <returns>if the voter was found in the database, a new instance with his details is returned, else null is returned</returns>
        public Voter searchVoterById(string id)
        {
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", id);
            DataTable t = sqlConnection.getTableBycommand("SearchVoter", parm);
            try
            {
                var factory = new FactroryVoter() as ICreateVoters;
                return factory.createVoter(t.Rows[0]); 
               
            }
            catch (IndexOutOfRangeException) { return null; }
        }

        /// <summary>
        /// the method blocks a voter from voting
        /// </summary>
        /// <param name="id">the id of the voter that needs to be blocked</param>
        public void BlockedCitizen(string id)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("blockCitizen"); //sql Procedure
            p1.InsertValstring("@id", id); //sending parameters
            p1.InsertValstring("@isBlocked", "True"); //sending parameters
            p1.NonQueryE(); //Updating
        }

        /// <summary>
        /// the method unblockes a voter, allowing him to vote
        /// </summary>
        /// <param name="id">the id of the voter needs to be unblocked</param>
        public void UnblockedCitizen(string id)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("unblockCitizen"); //sql Procedure
            p1.InsertValstring("@id", id); //sending parameters
            p1.InsertValstring("@isBlocked", "False"); //sending parameters
            p1.NonQueryE(); //Updating
        }

        //The method adds a new employee system
        public string AddWorker(string id, string kalpiCode, string name, string lastname, string username, string password, string permission, DateTime birthDay, string addres, string area, string city, string tell)
        {
            Voter worker = new Voter(id, kalpiCode, name, lastname, username, password, permission, birthDay, addres, area, city, tell, "0", true, false, true);

            sqlConnection con = sqlConnection.Instance;
            con.sqlCommand("AddWorker");
            con.InsertValstring("@idVoter", worker.Id);
            con.InsertValstring("@kalpiCode", worker.KalpiCode);
            con.InsertValstring("@name", worker.FName);
            con.InsertValstring("@lastname", worker.LName);
            con.InsertValstring("@username", worker.username);
            con.InsertValstring("@password", worker.Passowrd);
            con.InsertValstring("@permission", worker.Permission);
            con.InsertValstring("@address", worker.Address);
            con.InsertValstring("@area", worker.Area);
            con.InsertValstring("@city", worker.City);
            con.InsertValDate("@birthDay", worker.DOB);
            con.InsertValstring("@tell", worker.Tell);

            return con.getVal("@Result");
        }

        public string updateWorker(string id, string kalpiCode, string name, string lastname, string username, string password, string permission, DateTime birthDay, string addres, string area, string city, string tell)
        {
            Voter worker = new Voter(id, kalpiCode, name, lastname, username, password, permission, birthDay, addres, area, city, tell, "0", true, false, true);
            sqlConnection con = sqlConnection.Instance;
            con.sqlCommand("updateWorker");
            con.InsertValstring("@idVoter", worker.Id);
            con.InsertValstring("@kalpiCode", worker.KalpiCode);
            con.InsertValstring("@name", worker.FName);
            con.InsertValstring("@lastname", worker.LName);
            con.InsertValstring("@username", worker.username);
            con.InsertValstring("@password", worker.Passowrd);
            con.InsertValstring("@permission", worker.Permission);
            con.InsertValstring("@address", worker.Address);
            con.InsertValstring("@area", worker.Area);
            con.InsertValstring("@city", worker.City);
            con.InsertValDate("@birthDay", worker.DOB);
            con.InsertValstring("@tell", worker.Tell);
            return con.getVal("@Result");
        }

        public Voter SearchWorker(string id)
        {
            try
            {
                sqlConnection con = sqlConnection.Instance;
                con.sqlCommand("SearchWorker");
                con.InsertValstring("@id", id);
                DataTable worker = con.GetData("SearchWorker");

                return new Voter(worker.Rows[0]);
            }
            catch
            {
                return null;
            }
        }

        public string DeleteWorker(Voter worker)
        {
            try
            {
                sqlConnection con = sqlConnection.Instance;
                con.sqlCommand("RemoveWorker");
                con.InsertValstring("@id", worker.Id);
                string value = con.getVal("@Result");
                return value;
            }
            catch
            {
                return "Data Base id Filed";
            }
        }

        public DataTable getVotesForPrime()
        {
            con.sqlCommand("getPrimeVotes");
            con.InsertValstring("@kalpiCode", this.KalpiCode);
            return con.GetData("getPrimeVotes");
        }

        public int countWhiteNots(KalpiManager kalpiManager)
        {
            try
            {
                int count = 0;
                sqlConnection con = sqlConnection.Instance;
                con.sqlCommand("getNumOfWhiteNotes");
                con.InsertValstring("@kalpiCode", kalpiManager.KalpiCode);
                count = int.Parse(con.getVal("@Result"));
                return count;
            }
            catch
            {
                return 0;
            }
        }

        public void CloseKalpi(String kalpiCode)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("blockKalpi"); //sql Procedure
            p1.InsertValstring("@kalpiCode", kalpiCode); //sending parameters
            p1.InsertValstring("@openKalpi", "False"); //sending parameters
            p1.NonQueryE(); //Updating
        }
    }
}
