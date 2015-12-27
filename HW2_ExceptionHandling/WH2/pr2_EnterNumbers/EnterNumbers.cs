namespace pr2_EnterNumbers
{
    using System;

    class EnterNumbers
    {
       
        static void Main()
        {
            Console.WriteLine("Enter START and END numbers");
            Console.Write("START number: ");
            var startNumber = int.Parse(Console.ReadLine());
            Console.Write("END number: ");
            var endNumber = int.Parse(Console.ReadLine());
            var numbers = new int[10];
            for (var i = 0; i < numbers.Length; i++)
            {
                try
                {
                    var currentNumber = ReadNumber(startNumber, endNumber);
                    if (currentNumber > startNumber)
                    {
                        startNumber = currentNumber;
                        numbers[i] = startNumber;
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
                catch (ArgumentNullException ne)
                {
                    Console.WriteLine("Invalid number");

                }
                catch (OverflowException oe)
                {
                    Console.WriteLine("Invalid number");

                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid number");
                    i--;
                }
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        public static int ReadNumber(int start, int end)
        {

            Console.WriteLine("Enter your number in the given range [{0}...{1}]", start, end);
            var number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new ArgumentException("Invalid number");
            }

            return number;
        }
    }
}
