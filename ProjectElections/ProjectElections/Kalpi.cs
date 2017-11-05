using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectElections
{
    /// <summary>
    /// this class represents a kalpi - a place where voters vote
    /// </summary>
    public class Kalpi
    {
        private sqlConnection con;

        //the unique id of the kalpi
        private string kalpiCode;
        public string KalpiCode
        {
            set { kalpiCode = value; }
            get { return kalpiCode; }
        }

        //the ID of the manager who runs the kalpi
        private string managerID;
        public string ManagerID
        {
            set { managerID = value; }
            get { return managerID; }
        }

        //name of the kalpi
        private string kalpiName;
        public string KalpiName
        {
            set { kalpiName = value; }
            get { return kalpiName; }
        }

        //street and house number of the kalpi
        private string address;
        public string Address
        {
            set { address = value; }
            get { return address; }
        }

        //city where the kalpi is located
        private string city;
        public string City
        {
            set { city = value; }
            get { return city; }
        }

        //the area in the country where the kalpi is located
        private string area;
        public string Area
        {
            set { area = value; }
            get { return area; }
        }

        //current amount of voters registered in the kalpi
        private int votersAmount;
        public int VotersAmount
        {
            set { votersAmount = value; }
            get { return votersAmount; }
        }

        //the maximum number of voters allowed to be registered in the kalpi
        private int maxVoters;
        public int MaxVoters
        {
            set { maxVoters = value; }
            get { return maxVoters; }
        }

        //indicates if the kalpi has access for handicapped people
        private Boolean invalidAccess;        
        public Boolean InvalidAccess
        {
            set { invalidAccess = value; }
            get { return invalidAccess; }
        }

        //indicates if the kalpi deleted from the system
        private Boolean mode;
        public Boolean Mode
        {
            set { mode = value; }
            get { return mode; }
        }

        /// <summary>
        /// default constuctor
        /// </summary>
        public Kalpi()
        {
            con = sqlConnection.Instance;
        }

        //Consructor that gets full kalpi details and creates a new Kalpi.
        public Kalpi(string kalpi_code, string id_manager, string kalpi_name, string address, string city, string area, int voters_amount, int max_voters, Boolean invalid_access)
        {
            this.kalpiCode = kalpi_code;
            this.managerID = id_manager;
            this.kalpiName = kalpi_name;
            this.address = address;
            this.city = city;
            this.area = area;
            this.votersAmount = voters_amount;
            this.maxVoters = max_voters;
            this.invalidAccess = invalid_access;
            con = sqlConnection.Instance;
        }        
       
        //Constructor that creates a new Kalpi using a datarow from a table in the database
        public Kalpi(DataRow kalpi)
        {
            con = sqlConnection.Instance;
            kalpiCode = kalpi["kalpiCode"].ToString();
            managerID = kalpi["managerID"].ToString();
            kalpiName = kalpi["kalpiName"].ToString();
            address = kalpi["address"].ToString();
            city = kalpi["city"].ToString();
            area = kalpi["area"].ToString();
            votersAmount = int.Parse(kalpi["votersAmount"].ToString());
            maxVoters = int.Parse(kalpi["maxVoters"].ToString());
            invalidAccess = Boolean.Parse(kalpi["invalidAccess"].ToString());           
            mode = Boolean.Parse(kalpi["mode"].ToString());
        }

        
      
    }
}
