using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectElections
{
    class Vote
    {
        private int vote_code;
        public int VoteCode
        {
            get { return vote_code; }
            set { vote_code = value; }
        }

        private string kalpiCode;
        public string KalpiCode
        {
            get { return kalpiCode; }
            set { kalpiCode = value; }
        }

        private string partyName;
        public string PartyName
        {
            get { return partyName; }
            set { partyName = value; }
        }

        private int prime_code;
        public int primeMinisterCode
        {
            get { return prime_code; ; }
            set { prime_code = value; }
        }

        private Boolean white_note;
        public Boolean whiteNote
        {
            get { return white_note; }
            set { white_note = value; }
        }
        /// <summary>
        /// Constructor 1
        /// build Vote object from datarow
        /// </summary>
        /// <param name="vote"></param>
        public Vote(DataRow vote)
        {
            vote_code = int.Parse(vote["vote_code"].ToString()); 
            kalpiCode = vote["kalpiCode"].ToString();
            partyName = vote["partyName"].ToString();
            prime_code = int.Parse(vote["prime_code"].ToString());
            white_note = Boolean.Parse(vote["white_note"].ToString());
        }

        /// <summary>
        /// Constructor 2
        /// </summary>
        /// <param name="code">vote code</param>
        /// <param name="kalpi">kalpi code</param>
        /// <param name="party">party name</param>
        /// <param name="prime">prime minister code</param>
        /// <param name="white">white note boolean</param>
        public Vote(int code, string kalpi, string party, int prime, Boolean white)
        {
            this.vote_code = code;
            this.kalpiCode = kalpi;
            this.partyName = party;
            this.prime_code = prime;
            this.white_note = white;
        }

        /// <summary>
        /// adding vote to databse using SQL_Integrator
        /// </summary>
        /// <param name="voter_id">the id of the current voter</param>
        public void addVote(string voter_id)
        {
            SqlParameter [] arr = new SqlParameter[5];
            arr[0] = new SqlParameter("@prime_code", prime_code);
            arr[1] = new SqlParameter("@voter_id", voter_id);
            arr[2] = new SqlParameter("@party_name", partyName);
            arr[3] = new SqlParameter("@kalpi_code", kalpiCode);
            int vote  = white_note ? 1:0;
            arr[4] = new SqlParameter("@white_note", vote);
            sqlConnection.getTableBycommand("VoteProc", arr);
        }
    }
}
