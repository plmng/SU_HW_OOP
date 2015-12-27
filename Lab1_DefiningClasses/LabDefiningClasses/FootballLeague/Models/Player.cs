namespace FootballLeague.Models
{
    using System;

    public class Player
    {
        
        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private const int MinimumAllowedYear = 1980;


        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || (value.Length < 3))
                {
                    throw new ArgumentException("Firstname must be at least 3 characters long");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("LastName must be at least 3 characters long");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }
                else
                {
                    this.salary = value;
                }
            }
        }
       
        public DateTime DateOfBirth {
            get { return this.dateOfBirth; }
            set {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException("Date of Birth’s year cannot be lower than 1980");
                }
                else
                {
                    this.dateOfBirth = value;
                }
            }
        }
        public Team Team { get; set; }

    }
}
