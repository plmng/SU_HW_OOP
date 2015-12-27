namespace pr3_CompanyHierarchy.Classes
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class SalesEmployee: Employee, ISalesEmployee
    {
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, List<Sale> sales) 
           : base(id, firstName, lastName, salary, Department.Sales)
        {
           this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {

            var sb = new StringBuilder();
            sb.AppendFormat("{0}\nSales:\n", base.ToString());
            foreach (var sale in this.Sales)
            {
                sb.AppendFormat("{0}\n", sale.ToString());
            }
            return sb.ToString();
        }
    }
}
