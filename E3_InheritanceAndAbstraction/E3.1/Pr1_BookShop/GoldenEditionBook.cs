namespace pr1_BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
        {
        }

        public override decimal Price 
        {
            get
            {
                var newPrice = base.Price + base.Price/100*30;
                return newPrice;
            } 
        }
    }
}
