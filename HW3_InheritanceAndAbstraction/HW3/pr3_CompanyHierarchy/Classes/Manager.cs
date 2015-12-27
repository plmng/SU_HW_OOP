namespace pr3_CompanyHierarchy.Classes
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class Manager: Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees  ) 
           : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            
            var sb = new StringBuilder();
            if (this.Employees == null) return sb.ToString();
            sb.AppendFormat("{0}\nEmployee subject:\n", base.ToString());
            foreach (var employee in this.Employees)
            {
                sb.AppendFormat("{0}\n", employee.ToString());
            }

            return sb.ToString();
        }
    }
}
