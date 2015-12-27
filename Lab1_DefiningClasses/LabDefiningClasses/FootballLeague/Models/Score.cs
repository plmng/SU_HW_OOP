namespace FootballLeague.Models
{
    using System;

    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int homeTealmGoals, int awayTeamGoals)
        {
            this.HomeTeamGoals = homeTealmGoals;
            this.AwayTeamGoals = awayTeamGoals;

        }
        public int HomeTeamGoals {
            get { return this.homeTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals cannot be negative");
                }
                else
                {
                    this.homeTeamGoals = value;
                }
            }
        }
        public int AwayTeamGoals
        {
            get { return this.awayTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals cannot be negative");
                }
                else
                {
                    this.awayTeamGoals = value;
                }
            }
        }
        
    }
}
