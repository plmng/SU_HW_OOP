namespace Pr2
{
    public class Payment
    {
        private string _product;
        private decimal _price;

        public string Product { get; set; }
        public decimal Price { get; set; }

        public Payment(string product, decimal price)
        {
            this.Product = product;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} -- {1}", this.Product, this.Price);
        }
    }
}
