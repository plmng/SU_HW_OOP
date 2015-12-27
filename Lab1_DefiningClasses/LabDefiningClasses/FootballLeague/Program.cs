namespace FootballLeague
{
    using System;

    class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            while (line != "End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidOperationException io)
                {
                    Console.WriteLine(io.Message);
                }
                line = Console.ReadLine();
            }
        }
    }
}
