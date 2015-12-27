namespace pr3_CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;
    using Classes;

    public interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}
