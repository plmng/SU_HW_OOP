namespace pr3_CompanyHierarchy.Classes
{
    using System;
    using System.Text;
    using Interfaces;

    public abstract class Employee : Person, IEmployee
    {
        private decimal _salary;
       
        protected Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

     
        public decimal Salary {
            get { return this._salary; }
            set
            {
                if (value > 0)
                {
                    this._salary = value;    
                }
                else throw new ArgumentOutOfRangeException("Salary " + "have to be positive number");
            }
        }
       
        public Department Department { get; set;}

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat(", Salary: {0}, Department: {1}", this.Salary, this.Department.ToString());
            return sb.ToString();
        }
    }
}
