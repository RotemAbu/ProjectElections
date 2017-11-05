using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectElections;

namespace ProjectElections
{
    public class ElectionsManager : Voter
    {
        private sqlConnection con;

        //Constructor
        public ElectionsManager()
            : base()
        {
            con = sqlConnection.Instance;
        }

        public ElectionsManager(DataRow voter)
            : base(voter)
        {
            con = sqlConnection.Instance;
        }

        public ElectionsManager(Voter v)
            : base(v)
        {
            con = sqlConnection.Instance;
        }

        /// <summary>
        /// This function allows Elections Manager to create a new party to Parties DB.
        /// </summary>
        /// <returns></returns> Returns Result as int (1/0) if the action succeeded or not.
        public int newParty(string partyName, int memberSize, string platform)
        {
            Parties par = new Parties(partyName, memberSize, platform);
            return par.newParty();
        }
        /// <summary>
        /// This function allows Elections Manager to remove a new party from Parties DB (change 'Mode' to "flase").
        /// </summary>
        /// <returns></returns> Returns Result as int (1/0) if the action succeeded or not.
        public int removeParty(string partyName, Boolean mode)
        {
            Parties par = new Parties(partyName, mode);
            return par.removeParty();
        }
        /// <summary>
        /// The Elections Menager updates the party details
        /// </summary>
        /// <param name="PartyName"></param> Party name
        /// <param name="membersSize"></param> size of the party 
        /// <param name="platform"></param> Platform
        /// <returns></returns> The updated party
        public string UpdatePartyDetails(string PartyName, int membersSize, string platform)
        {
            Parties party1 = new Parties(PartyName, membersSize, platform);// Creating a new party object, with the current details
            return party1.UpdateParty();// Calling the function  UpdateParty in class Parties
        }

        //Searching party in DB.
        public DataRow SerachParty(string key)
        {
            con.sqlCommand("SearchParty");
            con.InsertValstring("@partyName", key.Trim());
            DataTable tab = con.GetData("SearchParty");
            return tab.Rows[0];
        }

        /// <summary>
        /// The Elections Manager add new party member.
        /// </summary>
        /// <returns></returns> The new party.
        public string newPartyMember(int code, string nameParty, string name, string lastName, DateTime brithDate, int listPlac, string expirence, string educasion)
        {
            PartyMember party = new PartyMember(code, nameParty, name, lastName, brithDate, listPlac, expirence, educasion);
            return party.AddPartyMember();
        }

        /// <summary>
        /// The Elections Manager removes the party member
        /// </summary>
        /// <param name="partyName"></param>
        /// <param name="mode"></param>
        /// <returns></returns> The removed party member
        public void removePartyMember(int code, string nameParty, string name, string lastname, DateTime brithDate, int sizeMemberSize, string exp, string education)
        {
            PartyMember p = new PartyMember(code, nameParty, name, lastname, brithDate, sizeMemberSize, exp, education);//Creating Party Member object
            p.RemoveMember(); //Using the RemoveMember function in PartyMember class
        }

        /// <summary>
        /// The Elections Manager updates memeber party details
        /// </summary>
        /// <returns></returns> The updated party member
        public string UpdateMemberParty(int code, string exp, string edu, int numOfList, string namePartyMember, DateTime BD, string name, string laseName)
        {
            PartyMember partyMem = new PartyMember(code, namePartyMember, name, laseName, BD, numOfList, exp, edu);
            return partyMem.UpdateMemberParty();
        }

        /// <summary>
        /// The Elections Manager adds new area manager
        /// </summary>
        /// <returns></returns> The result succeed/failed
        public int addnewAreaManager(string id, string firstName, string lastName, string userName, string password, string permission, DateTime dob, string address, string area, string city, string tell, string accomid)
        {
            var factory = new FactroryVoter() as ICreateVoters;
            Voter v = factory.createVoter();
            v.Id = id;
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

            return v.addNewAreaManager(id, firstName, lastName, userName, password, permission, dob, address, area, city, tell, accomid);
        }

        /// <summary>
        /// The Elections Manager removes an area manager
        /// </summary>
        /// <returns></returns> The result succeed/failed
        public int removeAreaManager(string id)
        {
            var factory = new FactroryVoter() as ICreateVoters;
            Voter v = factory.createVoter();
            v.Id = id;
            return v.removeAreaManager();
        }


        public string updateAreaManager(string id, string name, string lastname, string username, string password,  DateTime birthDay, string addres, string area, string city, string tell)
        {
            
            sqlConnection con = sqlConnection.Instance;
            con.sqlCommand("updateAreaManager");
            con.InsertValstring("@idVoter", id);
            con.InsertValstring("@name", name);
            con.InsertValstring("@lastname", lastname);
            con.InsertValstring("@username", username);
            con.InsertValstring("@password", password);
            con.InsertValDate("@birthDay", birthDay);
            con.InsertValstring("@address", addres);
            con.InsertValstring("@area", area);
            con.InsertValstring("@city", city);
            con.InsertValstring("@tell", tell);
            return con.getVal("@Result");
        }



        //Update worker to Commissioner
        public string updateWorker(string id, string kalpiCode, string name, string lastname, string username, string password, string permission, DateTime birthDay, string addres, string area, string city, string tell)
        {
            Voter worker = new Voter(id, kalpiCode, name, lastname, username, password, permission, birthDay, addres, area, city, tell, "Commissioner", true, false, true);
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
        //Serach Worker by Id
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
        //Update worker to Commissioner
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
        //Open to Kalpi change to True
        public void OpenKalpi()
        {
            con.sqlCommand("OpenKalpi");
            con.NonQueryE();
        }

        /// <summary>
        /// Close all kalpi in the country, so that no one be able to vote before or after elections day
        /// </summary>
        public void CloseAllKalpi()
        {
            con.sqlCommand("CloseAllKalpi");
            con.NonQueryE();
        }
        
    
    
    }
}
