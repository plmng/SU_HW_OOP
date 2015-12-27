namespace pr3_CompanyHierarchy.Classes
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class Developer : Employee, IDeveloper
    {

        public Developer(int id, string firstName, string lastName, decimal salary, List<Project> projects )
            : base(id, firstName, lastName, salary, Department.Production)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}\nProjects:\n", base.ToString());
            foreach (var project in this.Projects)
            {
                sb.AppendFormat("{0}\n", project.ToString());
            }
            return sb.ToString();
        }
    }
}
