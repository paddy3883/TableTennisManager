using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTennisManager.Domain
{
    public partial class Player
    {

        public string Name { get { return Forename + " " + Surname; } }
    }
}
