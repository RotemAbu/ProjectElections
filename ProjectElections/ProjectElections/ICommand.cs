using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectElections
{
    //interface that declares execute method for different commands
    interface ICommand
    {
        void execute(Voter voter);
    }
}
