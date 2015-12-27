namespace pr3_CompanyHierarchy.Interfaces
{
    using Classes;

    public interface IEmployee
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}
