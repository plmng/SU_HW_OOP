namespace TheBank.Customers
{
    public abstract class Customer
    {
        protected Customer(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
