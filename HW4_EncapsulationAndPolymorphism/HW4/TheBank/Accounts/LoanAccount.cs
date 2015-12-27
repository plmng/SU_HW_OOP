namespace TheBank.Accounts
{
    using Customers;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, double interestRate) 
            : base(customer, interestRate)
        {
        }

        public override decimal CallculatInterestForPeriod(int months)
        {
            if (this.Customer is  Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                
                months -= 3;
                
            }
            else
            {
                if (months <= 2)
                {
                    return 0;
                }
                months -= 2;    
            }

            return this.CalculateInterestBaseFormula(this.Balance, months, this.InterestRate);
        }
    }
}
