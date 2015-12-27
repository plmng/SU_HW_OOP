namespace pr3_CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;
    using Classes;

    public interface ISalesEmployee
    {
       List<Sale> Sales { get; set; }
    }
}
