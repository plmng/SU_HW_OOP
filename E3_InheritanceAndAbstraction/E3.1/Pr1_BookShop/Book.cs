namespace pr1_BookShop
{
    using System;
    using System.Diagnostics;
    using System.Runtime.Remoting.Messaging;

    public class Book
    {
        //Book - represents a book that holds title, author and price. Validate that the title and author are not null. The price should never be a negative number. A book should offer information about itself in the format shown in the output below.
        private string _title;
        private string _author;
        private decimal _price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return this._title; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The book title should not be null");
                }
                else this._title = value;
            }
        }

        public string Author
        {
            get { return this._author; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The book author should not be null");
                }
                else this._author = value;
            }
        }

        public virtual decimal Price
        {
            get { return this._price; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "The book title should not be null");
                }
                else this._price = value;
            }
        }

        public override string ToString()
        {
            var result = string.Format("-Type: {3}\n-Title: {0}\n-Author: {1}\n-Price: {2:C2}", this.Title, this.Author,
                this.Price, this.GetType().Name);
            return result;
        }
    }
}
