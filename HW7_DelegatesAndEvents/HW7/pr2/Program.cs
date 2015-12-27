﻿namespace pr2
{
    using System;

    public class Program
    {
       
        static void Main()
        {
            var simpleInterest = new InterestCalculator(500m, 5.6m, 10, GetCompoundInterest);
            Console.WriteLine(simpleInterest);

            var compoundInterest = new InterestCalculator(2500m, 7.2m, 15, GetSimpleInterest);
            Console.WriteLine(compoundInterest);
        }

        public static decimal GetSimpleInterest(decimal money, decimal interest, int years)
        {
            return money * (1 + (interest / 100) * years);
        }
        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + (interest / 100) / 12), 12 * years);
        }

    }
}
