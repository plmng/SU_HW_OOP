namespace pr3_CompanyHierarchy.Classes
{
    using System;

    public class Project
    {
        public Project(string name, DateTime startDate, string details)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = ProjectState.Open;
        }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string Details { get; set; }
        public ProjectState State { get; private set; }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            var result = string.Format("ProjectName: {0}, State: {1}, StartDate: {2}\n Details:{2}", 
                this.Name, this.State.ToString(), this.StartDate.ToShortDateString(), this.Details);
            return result;
        }
    }
}
