using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foutball_Tournament.Entities
{
    public class Team
    {
        public string Name { get; set; }
        public int Goals { get; set; }
        public int Points { get; set; }

        public Team(string name)
        {
            Name = name;
            Goals = 0;
            Points = 0;
        }
    }
}
