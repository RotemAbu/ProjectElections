using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectElections
{
    public class Voter
    {
        public Voter() { con = sqlConnection.Instance; }
        private sqlConnection con;

        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string kalpiCode;
        public string KalpiCode
        {
            get { return kalpiCode; }
            set { kalpiCode = value; }
        }

        private string fname;
        public string FName
        {
            set { fname = value; }
            get { return fname; }
        }

        private string lName;
        public string LName
        {
            set { lName = value; }
            get { return lName; }
        }

        private string userName;
        public string username
        {
            set { userName = value; }
            get { return userName; }
        }

        private string password;
        public string Passowrd
        {
            set { password = value; }
            get { return password; }
        }

        private DateTime dob;
        public DateTime DOB
        {
            set { dob = value; }
            get { return dob; }
        }
        public DateTime GetDob()
        {
            return dob;
        }

        private string addres;
        public string Address
        {
            get { return addres; }
            set { addres = value; }
        }

        private string area;
        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string tell;
        public string Tell
        {
            get { return tell; }
            set { tell = value; }
        }

        private string accomId;
        public string AccomId
        {
            get { return accomId; }
            set { accomId = value; }
        }

        private bool isBlocked;
        public bool IsBlocked
        {
            set { isBlocked = value; }
            get { return isBlocked; }
        }

        private bool isVoted;
        public bool IsVoted
        {
            set { isVoted = value; }
            get { return isVoted; }
        }

        private string permission;
        public string Permission
        {
            set { permission = value; }
            get { return permission; }
        }

        private Boolean mode;
        public Boolean Mode
        {
            set { mode = value; }
            get { return mode; }
        }

        private DateTime lastConnection;
        public DateTime LastConnection
        {
            set { lastConnection = value; }
            get { return lastConnection; }

        }

        /// <summary>
        /// Constructor 1:
        /// builds voter from datarow
        /// </summary>
        /// <param name="voter">Datarow of Voter</param>
        public Voter(DataRow voter)
        {
            Id = voter["id"].ToString();
            KalpiCode = voter["kalpiCode"].ToString();
            FName = voter["fname"].ToString();
            LName = voter["lname"].ToString();
            username = voter["username"].ToString();
            Passowrd = voter["password"].ToString();
            Permission = voter["permission"].ToString();
            DOB = DateTime.Parse(voter["birthDay"].ToString());
            Address = voter["address"].ToString();
            Area = voter["area"].ToString();
            City = voter["city"].ToString();
            Tell = voter["tell"].ToString();
            AccomId = voter["accomId"].ToString();
            IsBlocked = Boolean.Parse(voter["isBlocked"].ToString());
            IsVoted = Boolean.Parse(voter["isVoted"].ToString());
            mode = Boolean.Parse(voter["mode"].ToString());
            LastConnection = DateTime.Parse(voter["lastConnection"].ToString());
        }

        /// <summary>
        /// Copy Constructor:
        /// builds voter from another given voter
        /// </summary>
        /// <param name="v">Voter to copy</param>
        public Voter(Voter v)
        {
            this.id = v.id;
            this.KalpiCode = v.KalpiCode;
            this.FName = v.fname;
            this.LName = v.LName;
            this.userName = v.username;
            this.Passowrd = v.password;
            this.Permission = v.permission;
            this.DOB = v.DOB;
            this.Address = v.addres;
            this.Area = v.area;
            this.City = v.city;
            this.Tell = v.tell;
            this.AccomId = v.AccomId;
            this.IsBlocked = v.IsBlocked;
            this.IsVoted = v.IsVoted;
            this.mode = v.mode;
            this.LastConnection = v.LastConnection;
        }

        /// <summary>
        /// Constructor 2:
        /// builds from given parameters.
        /// </summary>
        public Voter(string id, string kalpicode, string fname, string lname, string username, string password, string permission, DateTime birthdate, string address, string area, string city, string tell, string accomid, bool isblocked, bool isvoted, bool mode)
        {
            this.id = id;
            this.KalpiCode = kalpicode;
            this.FName = fname;
            this.LName = lname;
            this.userName = username;
            this.Passowrd = password;
            this.Permission = permission;
            this.DOB = birthdate;
            this.Address = address;
            this.Area = area;
            this.City = city;
            this.Tell = tell;
            this.AccomId = accomid;
            this.IsBlocked = isblocked;
            this.IsVoted = isvoted;
            this.mode = mode;
        }

        /// <summary>
        /// Constructor 3:
        /// builds from given parameters.
        /// </summary>
        public Voter(string id, string kalpicode)
        {
            con = sqlConnection.Instance;
            this.id = id;
            this.kalpiCode = kalpicode;
        }

        /// <summary>
        /// Constructor 4:
        /// builds from given parameters.
        /// </summary>
        public Voter(string id)
        {
            con = sqlConnection.Instance;
            this.id = id;
        }

        /// <summary>
        /// primeMinisterVote (Procces)
        /// </summary>
        /// <param name="prime">the prime id</param>
        public void primeMinisterVote(int prime)
        {
            Vote tmp = new Vote(0, this.kalpiCode, "-1", prime, false);
            this.isVoted = true;
            tmp.addVote(this.id);
        }

        /// <summary>
        /// PartyVote(Procces)
        /// </summary>
        /// <param name="party"></param>
        public void PartyVote(string party)
        {
            Vote tmp = new Vote(0, this.kalpiCode, party, -1, false);
            this.isVoted = true;
            tmp.addVote(this.id);
        }

        /// <summary>
        /// whiteNote (Procces)
        /// </summary>
        public void whiteNote()
        {
            Vote tmp = new Vote(0, this.kalpiCode, "-1", -1, true);
            this.isVoted = true;
            tmp.addVote(this.id);
        }

        /// <summary>
        /// partyAndPrime- the option to vote both-
        /// prime minister and party together
        /// </summary>
        /// <param name="party"></param>
        /// <param name="prime"></param>
        public void partyAndPrime(string party, int prime)
        {
            Vote tmp = new Vote(0, this.kalpiCode, party, prime, false);
            this.isVoted = true;
            tmp.addVote(this.id);
        }

        public void showDetails() { }

        /// <summary>
        /// Update new Accompanier Id in database
        /// </summary>
        /// <param name="accomId"></param>
        /// <param name="id"></param>
        public void addAccompanierId(string accomId, string id)
        {
            sqlConnection p1 = sqlConnection.Instance; //sql conection
            p1.sqlCommand("addAccompanierId"); //sql Procedure
            p1.InsertValstring("@id", id); //sending parameters
            p1.InsertValstring("@accomId", accomId); //sending parameters
            p1.NonQueryE(); //Updating
        }

        /// <summary>
        /// Update new password in database
        /// </summary>
        /// <param name="password"></param>
        /// <param name="id"></param>
        public void changePass(string password, string id)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("changePassword"); //sql Procedure
            p1.InsertValstring("@id", id); //sending parameters
            p1.InsertValstring("@password", password); //sending parameters
            p1.NonQueryE(); //Updating
        }
        public void RemoveAcompanier(string Id)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("RemoveAcompanier"); //sql Procedure
            p1.InsertValstring("@Id", Id); //sending parameters
            p1.NonQueryE(); //Updating
        }

        public string UpdateVoterDetails(string Id, string fname, string lName,string addres, string area, string city, string tell)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("UpdateVoterDetails"); //sql Procedure
            p1.InsertValstring("@Id", Id); //sending parameters
            p1.InsertValstring("@fname", fname.Trim()); //sending parameters
            p1.InsertValstring("@lname", lName.Trim()); //sending parameters
            p1.InsertValstring("@address", addres.Trim()); //sending parameters
            p1.InsertValstring("@area", area.Trim()); //sending parameters
            p1.InsertValstring("@city", city.Trim()); //sending parameters
            p1.InsertValstring("@tell", tell.Trim()); //sending parameters
            return p1.getVal("@Result").ToString();
            //   p1.NonQueryE(); //Updating
        }
        public DataRow SearchVoter(string id)
        {
            sqlConnection p1 = sqlConnection.Instance;//sql conection
            p1.sqlCommand("SearchVoter");
            p1.InsertValstring("@id", id); //sending parameters
            DataTable tab = p1.GetData("SearchVoter");
            return tab.Rows[0];
        }

        //Cheack name of Party Member if  exsist in system
        public string CheckNameOFPartyMember(string name)
        {
            sqlConnection sql = sqlConnection.Instance; //sql conection
            sql.sqlCommand("CheckNameOFPartyMember"); //sql Procedure
            sql.InsertValstring("@partyName", name); //sending parameters
            return sql.getVal("@Result");
        }
        /// <summary>
        /// Search Party member in database
        /// </summary>
        /// <param name="name"></param>
        /// 

        public List<PartyMember> searchPartyNameBy(string name)
        {
            List<PartyMember> party = new List<PartyMember>();
            if ("1".Equals(this.CheckNameOFPartyMember(name)))
            {
                sqlConnection sql = sqlConnection.Instance;
                sql.sqlCommand("SearchPartyMemberByName");//sql conection
                sql.InsertValstring("@partyName", name); //sending parameters
                DataTable temp = sql.GetData("SearchPartyMemberByName");
                foreach (DataRow i in temp.Rows)
                {
                    party.Add(new PartyMember(i));
                }
            }
            return party;
        }

        //Cheacking name of parties

        public string CheakParty(string name)
        {
            sqlConnection sql = sqlConnection.Instance; //sql conection
            sql.sqlCommand("CheakParty"); //sql Procedure
            sql.InsertValstring("@partyName", name); //sending parameters
            return sql.getVal("@Result");
        }
        /// <summary>
        /// Search Party  in database
        /// </summary>
        /// <param name="name"></param>
        /// 
        public Parties searchPartyName(string name)
        {
            Parties party = null;
            if ("1".Equals(this.CheakParty(name.Trim())))
            {
                sqlConnection sql = sqlConnection.Instance;
                sql.sqlCommand("SearchParty");//sql conection
                sql.InsertValstring("@partyName", name); //sending parameters
                party = new Parties(sql.GetData("SearchParty").Rows[0]);

            }
            return party;
        }
        public int changeKalpiVote(string kalpiC)
        {
            sqlConnection con = sqlConnection.Instance;

            con.sqlCommand("updateVoterKalpi");
            con.InsertValstring("@prev_kalpi", kalpiCode);
            con.InsertValstring("@kalpiCode", kalpiC);
            con.InsertValstring("@id", id);
            return int.Parse(con.getVal("res").ToString());
        }

        public DataRow SearchVoterToAdd(String ID)
        {
            con.sqlCommand("SearchVoterToAdd");
            con.InsertValstring("@id", ID);
            DataTable tab = con.GetData("SearchVoterToAdd");
            return tab.Rows[0];
        }

        public DataRow SearchVoterToRemove(String ID)
        {
            con.sqlCommand("SearchVoterToRemove");
            con.InsertValstring("@id", ID);
            DataTable tab = con.GetData("SearchVoterToRemove");
            return tab.Rows[0];
        }

        public int addNewVoterToKalpi(string kalpiCode)
        {
            con.sqlCommand("addVoterToKalpi"); //updateVoterKalpi SQL query for add exist voter to the kalpi.
            con.InsertValstring("@ID", Id); //ID for query check.
            con.InsertValstring("@kalpiCode", KalpiCode); //Change kalpiCode to kalpi manager code.
            return int.Parse(con.getVal("Result").ToString());
        }

        public int addNewVoterToKalpi(string id, string kalpiCode, string firstName, string lastName, string userName, string password, string permission, DateTime dob, string address, string area, string city, string tell, string accomid)
        {
            con.sqlCommand("AddNewVoterToKalpi");
            con.InsertValstring("@ID", Id); //ID for query check.
            con.InsertValstring("@kalpiCode", KalpiCode); //Change kalpiCode to kalpi manager code.
            con.InsertValstring("@firstName", FName); //first name
            con.InsertValstring("@lastName", LName); //last name
            con.InsertValstring("@userName", username); //user name
            con.InsertValstring("@pass", Passowrd); //password
            con.InsertValstring("@Permission", Permission); //permission
            con.InsertValDOB("@dob", DOB); //date of birth
            con.InsertValstring("@Address", Address); //address
            con.InsertValstring("@Area", Area); //area
            con.InsertValstring("@City", City); //city
            con.InsertValstring("@Tell", Tell); //tellephone
            con.InsertValstring("@Accomid", AccomId); //accomulate id
            return int.Parse(con.getVal("Result").ToString()); //result
        }

        public int removeVoterFromKalpi()
        {
            con.sqlCommand("removeVoterFromKalpi"); //updateVoterKalpi SQL query for add exist voter to the kalpi.
            con.InsertValstring("@ID", Id); //ID for query check.
            con.InsertValstring("@kalpiCode", KalpiCode); //Change kalpiCode to kalpi manager code.
            return int.Parse(con.getVal("Result").ToString());
        }

        public int addNewAreaManager(string id, string firstName, string lastName, string userName, string password, string permission, DateTime dob, string address, string area, string city, string tell, string accomid)
        {
            con.sqlCommand("AddNewAreaManager");
            con.InsertValstring("@ID", Id); //ID for query check.
            con.InsertValstring("@firstName", FName); //first name
            con.InsertValstring("@lastName", LName); //last name
            con.InsertValstring("@userName", username); //user name
            con.InsertValstring("@pass", Passowrd); //password
            con.InsertValstring("@Permission", Permission); //permission
            con.InsertValDOB("@dob", DOB); //date of birth
            con.InsertValstring("@Address", Address); //address
            con.InsertValstring("@Area", Area); //area
            con.InsertValstring("@City", City); //city
            con.InsertValstring("@Tell", Tell); //tellephone
            con.InsertValstring("@Accomid", AccomId); //accomulate id
            return int.Parse(con.getVal("Result").ToString()); //result
        }

        public int removeAreaManager()
        {
            con.sqlCommand("RemoveAreaManager"); //updateVoterKalpi SQL query for remove area manager.
            con.InsertValstring("@ID", Id); //ID for query check.
            return int.Parse(con.getVal("Result").ToString());
        }

        public DataRow SearchVoterToUpdate(string id)
        {
            sqlConnection p1 = sqlConnection.Instance;
            p1.sqlCommand("SearchVoterToUpdate");
            p1.InsertValstring("@id", id);
            DataTable tab = p1.GetData("SearchVoterToUpdate");
            return tab.Rows[0];
        }
    }
}
