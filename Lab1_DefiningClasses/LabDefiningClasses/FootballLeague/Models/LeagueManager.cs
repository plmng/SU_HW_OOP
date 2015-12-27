namespace FootballLeague.Models
{
    using System;

    public class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArg = input.Split();
            switch (inputArg[0])
            {
                case "AddTeam":
                    AddTeam(inputArg[1], inputArg[2], DateTime.Parse(inputArg[3]));
                    break;
                case "AddMatch":
                    break;
                case "AddPlayerToTeam":
                    break;
                case "ListMatches":
                    break;
            }
        }
    }
}
