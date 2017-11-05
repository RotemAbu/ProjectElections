using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ProjectElections
{
    // This class represents Area Manager, that extends a Kalpi Manager
    public class AreaManager : KalpiManager
    {
        private sqlConnection con;

        // default constructor
        public AreaManager()
            : base()
        {
            con = sqlConnection.Instance;
        }

        // constructor that creates a Area manager with a given datarow
        public AreaManager(DataRow kalpimanager)
            : base(kalpimanager)
        {
            con = sqlConnection.Instance;
        }

        // copy constructor
        public AreaManager(KalpiManager ka)
            : base(ka)
        {
            con = sqlConnection.Instance;
        }

        public int addNewKalpi(Kalpi kalpi)
        {
            con.sqlCommand("addNewKalpi");
            con.InsertValstring("@kalpiCode", kalpi.KalpiCode);
            con.InsertValstring("@kalpiName", kalpi.KalpiName);
            con.InsertValstring("@address", kalpi.Address);
            con.InsertValstring("@city", kalpi.City);
            con.InsertValstring("@area", this.Area);
            con.InsertValint("@maxVoters", kalpi.MaxVoters);
            return int.Parse(con.getVal("Result").ToString());
        }

        public void removeKalpi(string kalpiCode)
        {
            con.sqlCommand("RemoveKalpi");
            con.InsertValstring("@kalpiCode", kalpiCode);
            con.NonQueryE();
        }

        public void BlockCalpi(String kalpiCode)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("blockKalpi"); //sql Procedure
            p1.InsertValstring("@kalpiCode", kalpiCode); //sending parameters
            p1.InsertValstring("@openKalpi", "False"); //sending parameters
            p1.NonQueryE(); //Updating
        }

        public void unblockCalpi(String kalpiCode)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("unblockKalpi"); //sql Procedure
            p1.InsertValstring("@kalpiCode", kalpiCode); //sending parameters
            p1.InsertValstring("@openKalpi", "True"); //sending parameters
            p1.NonQueryE(); //Updating
        }

        public string UpdateKalpi(string KalpiCode, string adress, string area, string city, string kalpiName)
        {
            con.sqlCommand("UpdateKalpiDetails");
            con.InsertValstring("@KalpiCode", KalpiCode);
            con.InsertValstring("@area", area);
            con.InsertValstring("@address", adress);
            con.InsertValstring("@city", city);
            con.InsertValstring("@kalpiName", kalpiName);
            return con.getVal("@Result");
        }

        public DataRow SearchKalpi(string c)
        {
            con.sqlCommand("SearchKalpi");
            con.InsertValstring("@KalpiCode", c.Trim());
            DataTable tab = con.GetData("searchKalpi");
            return tab.Rows[0];
        }

        public DataRow SearchKalpiManagerByKalpiCode(string c, string A)
        {
            con.sqlCommand("SearchKalpiManagerByKalpiCode");
            con.InsertValstring("@KalpiCode", c.Trim());
            con.InsertValstring("@area", A.Trim());
            DataTable tab = con.GetData("SearchKalpiManagerByKalpiCode");
            return tab.Rows[0];
        }

        public string UpdateKalpiManager(string KalpiCode, string fname, string lname, string id, string address, string city, string area, string tell)
        {
            con.sqlCommand("UpdateKalpiManagerDetails");
            con.InsertValstring("@KalpiCode", KalpiCode);
            con.InsertValstring("@fname", fname);
            con.InsertValstring("@lname", lname);
            con.InsertValstring("@address", address);
            con.InsertValstring("@city", city);
            con.InsertValstring("@area", area);
            con.InsertValstring("@tell", tell);
            return con.getVal("@Result");
        }

        public int SearchKalpiesByArea(string area)
        {
            con.sqlCommand("SearchKalpiesByArea");
            con.InsertValstring("@area", this.Area);

            return int.Parse(con.getVal("Result").ToString());
        }

        //Returns Result as int (1/0) if the action succeeded or not.
        public int AddNewKalpiManagerToArea(string id, string fname, string lname, string username, string password, DateTime birthDay, string address, string city, string tell, string area, string kalpiCode)
        {
            con.sqlCommand("AddNewKalpiManagerToArea"); //set new kalpi manager to area SQL query.

            con.InsertValstring("@id", id.ToString());
            con.InsertValstring("@fname", fname);
            con.InsertValstring("@lname", lname);
            con.InsertValstring("@username", username);
            con.InsertValstring("@password", password);
            con.InsertValstring("@permission", "2");
            con.InsertValDate("@birthDay", birthDay);
            con.InsertValstring("@city", city);
            con.InsertValstring("@address", address);
            con.InsertValstring("@area", area);
            con.InsertValstring("@kalpiCode", kalpiCode);
            con.InsertValstring("@tell", tell);

            return int.Parse(con.getVal("Result").ToString());

        }

        /// <summary>
        /// search for kalpi manager by his id, and return an object with his details if was found.
        /// </summary>
        /// <param name="id">the id of the kalpi manager</param>
        /// <param name="area">the area to which the kalpi manager belongs</param>
        /// <returns>Voter which holds a kalpi manager, if he was found in the database, null-otherwise</returns>
        public Voter SearchKalpiManager(string id, string area)
        {
            try
            {
                con.sqlCommand("SearchKalpiManager");
                con.InsertValstring("@id", id);
                con.InsertValstring("@area", area);
                con.InsertValstring("@permission", "2");
                DataTable mngr = con.GetData("SearchKalpiManager");
                var factory = new FactroryVoter() as ICreateVoters;
                return factory.createVoter(mngr.Rows[0]);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Searches for Kalpi by id manager of the kalpi. if kalpi exists returns an object with its details.
        /// </summary>
        /// <param name="id">id of the kalpi's kalpi manager</param>
        /// <returns>Kalpi object if kalpi was found in database, null-otherwise</returns>
        public Kalpi SearchKalpiByManager(string id)
        {
            try
            {

                con.sqlCommand("SearchKalpiByManager");
                con.InsertValstring("@id", id);
                DataTable kalpi = con.GetData("SearchKalpiByManager");
                return new Kalpi(kalpi.Rows[0]);
            }
            catch
            {
                return null;
            }
        }


        /// <summary>
        /// Remove kalpi manager, by turning him to a simple voter, and deleting his id from the managerID field in his kalpi
        /// </summary>
        /// <param name="id">id of Kalpi Manager that needs to be removed</param>
        /// <returns>result of the sql procedure</returns>
        public string RemoveKalpiManager(string id)
        {
            try
            {
                con.sqlCommand("RemoveKalpiManager");
                con.InsertValstring("@id", id);
                return con.getVal("@Result");
            }
            catch
            {
                return "-1";
            }
        }

        public string addKalpiToVoter(String id, String kalpiCode)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("addKalpiToVoter"); //sql Procedure
            p1.InsertValstring("@id", id); //sending parameters
            p1.InsertValstring("@kalpiCode", kalpiCode); //sending parameters
            return p1.getVal("@Result"); //Updating
        }

        // Area Manager close all the kalpies in his area
        public string CloseKalpiByManagerArea(string area)
        {
            try
            {
                con.sqlCommand("CloseKalpiByManagerArea");
                con.InsertValstring("@area", area);
                return con.getVal("@Result");
            }
            catch
            {
                return "-1";
            }
        }

        public DataRow SearchKalpiByArea(string code, string area)
        {
            con.sqlCommand("SearchKalpiByArea");
            con.InsertValstring("@KalpiCode", code.Trim());
            con.InsertValstring("@area", area.Trim());

            DataTable tab = con.GetData("SearchKalpiByArea");
            return tab.Rows[0];
        }
    }

}
