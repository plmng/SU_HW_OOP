namespace pr3
{
    using System;

    public class Program
    {
        static void Main()
        {
            Action<int> test1 = (num) => Console.WriteLine("First test.Timer:{0}", num);
            Action<int> test2 = (num) => Console.WriteLine("Second test.Timer:{0}", num);
            var timer1 = new AsynchronousTimer(test1, 20, 1000);
            var timer2 = new AsynchronousTimer(test2, 10, 2000);
            timer1.Run();
            timer2.Run();
        }
    }
}
