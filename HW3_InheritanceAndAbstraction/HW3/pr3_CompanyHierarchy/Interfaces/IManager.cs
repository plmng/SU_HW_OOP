namespace pr3_CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;
    using Classes;

    public interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
