﻿namespace BookStore
{
    using Engine;
    using UI;

    public class BookStoreMain
    {
        public static void Main()
        {
            BookStoreEngine engine = new BookStoreEngine(new ConsoleRenderer(), new ConsoleInputHandler());

            engine.Run();
        }
    }
}
