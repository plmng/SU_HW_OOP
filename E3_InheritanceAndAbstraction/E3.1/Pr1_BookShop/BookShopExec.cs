namespace pr1_BookShop
{
    using System;

    public class BookShopExec
    {
        static void Main()
        {
            Book book = new Book("A Midsummer Night's Dream", "Shakespeare", 24.5m);
            Console.WriteLine(book);

            GoldenEditionBook goldBook = new GoldenEditionBook("The antichrist", "Emilian Stanev", 22.90m);
            Console.WriteLine(goldBook);
        }
    }
}
