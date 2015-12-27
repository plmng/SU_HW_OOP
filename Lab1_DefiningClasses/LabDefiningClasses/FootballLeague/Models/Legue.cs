namespace FootballLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Legue
    {
        private static List<Match> matches = new List<Match>();
        private static List<Team> teams = new List<Team>();

        public static IEnumerable<Match> Matches {
            get { return matches; }
        }
        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static void AddMatch(Match match)
        {
            if (CheckIfMatchExists(match))
            {
                throw new InvalidOperationException("Match already exists in that league");
            }
        }

        public static void AddTeam(Team team)
        {
            if (CheckIfTeamExists(team))
            {
                throw new InvalidOperationException("Team already exists in that league");
            }
        }

        private static bool CheckIfMatchExists(Match match)
        {
            return matches.Any(m => m.Id == match.Id);
        }

        private static bool CheckIfTeamExists(Team team)
        {
            return teams.Any(t => t.Name == team.Name);
        }




    }
}
