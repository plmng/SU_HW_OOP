namespace pr2
{
    using System;
    public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);

    public class InterestCalculator
    {
        private decimal _money;
        private decimal _interest;
        private int _years;
        private CalculateInterest _type;

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest type)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Type = type;
        }

        public decimal Money
        {
            get
            {
                return this._money;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Invalid amount of money");
                }
                this._money = value;
            }
        }
        public decimal Interest
        {
            get
            {
                return this._interest;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Invalid data");
                }
                this._interest = value;
            }
        }
        public int Years
        {
            get
            {
                return this._years;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Invalid data");
                }
                this._years = value;
            }
        }
        public CalculateInterest Type
        {
            get
            {
                return this._type;
            }
            set
            {

                this._type = value;
            }
        }

        public override string ToString()
        {

            return string.Format("{0:F4}", this.Type(this.Money, this.Interest, this.Years));
        }
    }
    
}
