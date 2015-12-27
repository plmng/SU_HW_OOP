namespace pr3_CompanyHierarchy.Classes
{
    using System;

    public class Sale
    {
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format("Date: {0}, Product: {1}, Price:{2}", 
                this.Date.ToShortDateString(), this.ProductName, this.Price);
        }
    }
}
