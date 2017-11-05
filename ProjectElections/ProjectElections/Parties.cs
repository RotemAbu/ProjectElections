using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectElections
{
    public class Parties
    {
        private sqlConnection con;

        private string partyName;
        public string PartyName
        {
            set { partyName = value; }
            get { return partyName; }
        }
        private int membersSize;
        public int MembersSize
        {
            set { membersSize = value; }
            get { return membersSize; }
        }
        private string platform;
        public string Platform
        {
            set { platform = value; }
            get { return platform; }
        }
        private Boolean mode;
        public Boolean Mode
        {
            set { mode = value; }
            get { return mode; }
        }
        public Parties()
        {
            con = sqlConnection.Instance;
        }
        //Consructor that gets full details about some party and create it.
        public Parties(string PartyName, int membersSize, string platform)
        {
            this.partyName = PartyName;
            this.MembersSize = membersSize;
            this.Platform = platform;
            con = sqlConnection.Instance;
        }
        
        public Parties(string pName, bool mode)
        {
            con = sqlConnection.Instance;
            this.partyName = pName;
            this.Mode = mode;
        }
        //Conturctor that gets a raw from Parties DB and create an object.
        public Parties(DataRow party)
        {
            con = sqlConnection.Instance;
            partyName = party["partyName"].ToString();
            membersSize = int.Parse(party["memberSize"].ToString());
            platform = party["platform"].ToString();
            mode = Boolean.Parse(party["mode"].ToString());
        }
        /// <summary>
        /// The function updates the party details.
        /// </summary>
        /// <returns></returns> Returns if the update succseed or not
        public string UpdateParty()
        {
            con.sqlCommand("UpdatePartyDetails");
            con.InsertValstring("@partyName", PartyName.Trim());
            con.InsertValint("@member_size", membersSize);
            con.InsertValstring("@platform", platform.Trim());
            return con.getVal("@Result");
        }

        /// <summary>
        /// This function allows Elections Manager to create a new party to Parties DB.
        /// </summary>
        /// <returns></returns> Returns Result as int (1/0) if the action succeeded or not.
        public int newParty()
        {
            con.sqlCommand("newParty"); //newParty SQL query.
            con.InsertValstring("@partyName", partyName); //insert party name.
            con.InsertValint("@memberSize", MembersSize); //insert memebers size.
            con.InsertValstring("@platform", platform); //insert party platform.
            return int.Parse(con.getVal("Result").ToString()); 
        }

        /// <summary>
        /// This function allows Elections Manager to remove a new party from Parties DB (change 'Mode' to "flase").
        /// </summary>
        /// <returns></returns> Returns Result as int (1/0) if the action succeeded or not.
        public int removeParty()
        {
            con.sqlCommand("DeleteParty"); //DeleteParty SQL query
            con.InsertValstring("@partyName", PartyName); //insert party name.
            con.InsertValBool("@mode", Mode); //change Mode to "false".
            return int.Parse(con.getVal("Result").ToString());
        }
    }
}
