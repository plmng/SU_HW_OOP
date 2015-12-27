namespace Problem2.FractionCalculator
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public struct Fraction
    {
        private long _numerator;
        private long _denominator;

        public Fraction(long numerator, long denominator):this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
    
        public long Numerator 
        {
            get { return this._numerator; }
            set { this._numerator = value; }
        }

        public long Denominator
        {
            get { return this._denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Denumerator", "Denominator can not be 0");
                }
                this._denominator = value;
            }
            
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            var denumerator = FindLCM(f1.Denominator, f2.Denominator);

            var numerator = ((denumerator/f1.Denominator)*f1.Numerator) + ((denumerator/f2.Denominator)*f2.Numerator);
            return new Fraction(numerator, denumerator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            var denumerator = FindLCM(f1.Denominator, f2.Denominator);

            var numerator = ((denumerator / f1.Denominator) * f1.Numerator) - ((denumerator / f2.Denominator) * f2.Numerator);
            return new Fraction(numerator, denumerator);
        }



        private static long FindLCM(long a, long b)
        {
           
              var  lcm = (a * b)
                        / (GetLCM(a, b));

              return lcm;
        }

        private static long GetLCM(long a, long b)
        {
            while (b != 0)
            {
                var temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        public override string ToString()
        {
            double result = (double)Numerator/(double)Denominator;
            return result.ToString();
        }
    }
}
