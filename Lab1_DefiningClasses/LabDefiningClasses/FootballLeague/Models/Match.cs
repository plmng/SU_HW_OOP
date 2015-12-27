namespace FootballLeague.Models
{
    using System;
    
    public class Match
    {
        
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;
        private readonly bool checkTeams;

        public Match(Team homeTeam, Team awayTeam, Score score)
        {
            this.checkTeams = this.CheckTeams(homeTeam, awayTeam);
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
        }

        public int Id 
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public Score Score 
        {
            get { return this.score; }
            set { this.score = value; }
        }
        public Team HomeTeam {
            get { return this.homeTeam; }
            set
            {
                if (!this.checkTeams)
                {
                    throw new ArgumentException("The two teams should be different");
                }
                else
                {
                    this.homeTeam = value;
                }
            }
        }
        public Team AwayTeam
        {
            get { return this.awayTeam; }
            set
            {
                if (!this.checkTeams)
                {
                    throw new ArgumentException("The two teams should be different");
                }
                else
                {
                    this.awayTeam = value;
                }
            }
        }

        private bool CheckTeams(Team homeTeam, Team awayTeam)
        {
            return homeTeam.Name == awayTeam.Name;
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }
            else
            {
               return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                    ? this.HomeTeam
                    : this.AwayTeam;
            }
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }
    }
}
