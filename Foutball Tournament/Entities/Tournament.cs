using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foutball_Tournament.Entities
{
    public class Tournament
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Location { get; set; }
        public List<Match> Matches { get; set; }
        public List<Team> Teams { get; set; }
        public Tournament(string name, int year, string location)
        {
            Name = name;
            Year = year;
            Location = location;
            Matches = new List<Match>();
        }
    }

}
