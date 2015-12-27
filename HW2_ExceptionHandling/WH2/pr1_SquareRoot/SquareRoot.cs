namespace pr1_SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            try
            {
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentNullException anx)
            {
                Console.WriteLine("Invalid Number" + anx);
                throw;
            }
            catch (FormatException fx)
            {
                Console.WriteLine("Invalid Number");
                throw;
            }
            catch (OverflowException ox)
            {
                Console.WriteLine("Invalid Number");
                throw;
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            

        }
    }
}
