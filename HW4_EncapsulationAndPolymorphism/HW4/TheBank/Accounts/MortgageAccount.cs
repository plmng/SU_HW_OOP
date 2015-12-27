namespace TheBank.Accounts
{
    using Customers;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, double interestRate) 
            : base(customer, interestRate)
        {
        }

        public override decimal CallculatInterestForPeriod(int months)
        {
           
            if (this.Customer is Individual)
            {
                return months <=6 ? 0 : this.CalculateInterestBaseFormula(this.Balance, months-6, this.InterestRate);
            }
            else
            {
                if (months > 12)
                {
                    var rate = (this.CalculateInterestBaseFormula(this.Balance, 12, this.InterestRate))/2 +
                               (this.CalculateInterestBaseFormula(this.Balance, months - 12, this.InterestRate));
                    return rate;
                }
                else
                {
                    return (this.CalculateInterestBaseFormula(this.Balance, months, this.InterestRate))/2;
                }
            }

        }
    }
}
