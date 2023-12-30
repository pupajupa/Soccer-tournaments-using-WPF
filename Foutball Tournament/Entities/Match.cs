using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foutball_Tournament.Entities
{
    public class Match
    {
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        public int ScoreTeamA { get; set; }
        public int ScoreTeamB { get; set; }

        public Match(Team teamA, Team teamB, int scoreTeamA, int scoreTeamB)
        {
            TeamA = teamA;
            TeamB = teamB;
            ScoreTeamA = scoreTeamA;
            ScoreTeamB = scoreTeamB;
        }
    }
}
