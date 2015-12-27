namespace FootballLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.AccessControl;

    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateOfFoundation;
        private List<Player> players;
        private const int MinimumAllowedYear = 1850;

        public Team(string name, string nickname, DateTime dateOfFormation)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateOfFounding = dateOfFormation;
            this.players = new List<Player>();
            
        }

   
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name should be at least 5 characters long");
                }
                else
                {
                    this.name = value;
                }
            } 
        }
        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Nickname should be at least 5 characters long");
                }
                else
                {
                    this.nickname = value;
                }
            }
        }
        public DateTime DateOfFounding
        {
            get { return this.dateOfFoundation; }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException("Date of Foundation year cannot be lower than 1850");
                }
                else
                {
                    this.dateOfFoundation = value;
                }
            }
        }
        public IEnumerable<Player> Players {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (this.CheckIfPlayerExists(player))
            {
                throw  new InvalidOperationException("Player already exists in that team");
            }
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }
    }
}
