using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ProjectElections
{
    public class PartyMember
    {
        private sqlConnection con;
        private int memberCode;
        public int MemberCode
        {
            set { memberCode = value; }
            get { return memberCode; }
        }

        private string partyName;
        public string PartyName
        {
            set { partyName = value; }
            get { return partyName; }
        }

        private int listPlace;
        public int ListPlace
        {
            set { listPlace = value; }
            get { return listPlace; }
        }

        private string fName;
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        private DateTime dob;
        public void SetDob(DateTime time)
        {
            dob = time;
        }
        public DateTime GetDob()
        {
            return dob;
        }
        public String GetDobstring()
        {
            return dob.ToString();
        }

        private string education;
        public string Education
        {
            set { education = value; }
            get { return education; }
        }
        public PartyMember() { con = sqlConnection.Instance; }
        private string experience;
        public string Experience
        {
            set { experience = value; }
            get { return experience; }
        }

        private Boolean mode;
        public Boolean Mode
        {
            set { mode = value; }
            get { return mode; }
        }
        //Conturctor that gets a raw from Parties DB and create an object.
        public PartyMember(DataRow member)
        {
            con = sqlConnection.Instance;
            memberCode = int.Parse(member["memberCode"].ToString());
            partyName = member["partyName"].ToString();
            listPlace = int.Parse(member["listPlace"].ToString());
            fName = member["fName"].ToString();
            lName = member["lName"].ToString();
            dob = DateTime.Parse(member["dob"].ToString());
            education = member["education"].ToString();
            experience = member["experience"].ToString();
            mode = Boolean.Parse(member["mode"].ToString());
        }
        //Consructor that gets full details about some member and create him.
        public PartyMember(int Code, string nameParty, string name, string lastname, DateTime brithDate, int sizeMemberSize, string exp, string education)
        {
            con = sqlConnection.Instance;
            memberCode = Code;
            PartyName = nameParty;
            FName = name;
            LName = lastname;
            SetDob(brithDate);
            ListPlace = sizeMemberSize;
            Education = education;
            Experience = exp;
            Mode = true;
        }
        public DataRow SerachMember(int key)
        {
            con.sqlCommand("SearchPartyMember");
            con.InsertValint("@member_code", key);
            DataTable tab = con.GetData("SearchPartyMember");
            return tab.Rows[0];
        }
        /// <summary>
        /// The function removes the member from the Data Base.
        /// </summary>
        /// <returns></returns> If the reomving succeseed or not
        public string RemoveMember()
        {
            con.sqlCommand("RemovePartyMember");
            con.InsertValint("@member_code", MemberCode);
            con.InsertValstring("@mode", Mode.ToString());
            return con.getVal("@Result").ToString();
        }
        public string AddPartyMember()
        {
            con.sqlCommand("newMemberParty");

            con.InsertValint("@member", MemberCode);
            con.InsertValstring("@partyn", PartyName);
            con.InsertValstring("@name", FName);
            con.InsertValstring("@lastn", LName);
            con.InsertValDate("@dateT", GetDob());
            con.InsertValint("@list", ListPlace);
            con.InsertValstring("@ediction", Education);
            con.InsertValstring("@exp", Experience);
            return con.getVal("@Result").ToString();
        }
   
        public string UpdateMemberParty()
        {
            con.sqlCommand("UpdateMemberParty");
            con.InsertValint("@member_code", MemberCode);
            con.InsertValstring("@party_name", PartyName.Trim());
            con.InsertValstring("@f_name", FName.Trim());
            con.InsertValstring("@l_name", LName.Trim());
            con.InsertValstring("@birth_date", GetDob().ToString());
            con.InsertValint("@list_place", ListPlace);
            con.InsertValstring("@education", Education.Trim());
            con.InsertValstring("@experience", Experience.Trim());
            return con.getVal("@Result").ToString();
        }
    }
}
