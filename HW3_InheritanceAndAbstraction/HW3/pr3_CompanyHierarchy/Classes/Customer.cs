namespace pr3_CompanyHierarchy.Classes
{
    using System;
    using Interfaces;

    public class Customer : Person, ICustomer
    {
        private decimal _amount;
        public Customer(int id, string firstName, string lastName, decimal amount) : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = amount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this._amount; }
            set {
                if (value >0)
                {
                    this._amount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Amoun"+"have to be positive number");
                }
            }
        }

        public override string ToString()
        {
            var result = string.Format("{0}, NetPurchaseAmount:{1}", base.ToString(),this.NetPurchaseAmount);
            return string.Format(result);
        }
    }
}
