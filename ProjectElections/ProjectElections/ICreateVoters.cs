using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjectElections
{
    /// <summary>
    /// interface that declares different methods for creating voters
    /// </summary>
    interface ICreateVoters
    {
        Voter createVoter(Voter v); //creates voter with a given voter.
        Voter createVoter(); //creates a default voter.
        Voter createVoter(DataRow row); //creates voter with a given datarow from a table in a database.
    }
}
