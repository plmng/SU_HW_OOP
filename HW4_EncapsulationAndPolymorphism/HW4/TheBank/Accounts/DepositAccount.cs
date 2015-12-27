namespace TheBank.Accounts
{
    using System;
    using Customers;
    using Interfaces;

    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, double interestRate) 
            : base(customer, interestRate)
        {
        }

        public override decimal CallculatInterestForPeriod(int months)
        {
            return this.Balance >=1000 ? this.CalculateInterestBaseFormula(this.Balance, months, this.InterestRate) : 0;
        }

        public string Withdraw(decimal amounth)
        {
            if (this.Balance >= amounth)
            {
                this.Balance -= amounth;
                return String.Format("Withdraw: {0}, Balance: {1}", amounth, this.Balance);
            }
            else
            {
                return "The balance is below the amount requested. Can not withdraw";
               // throw new ArgumentOutOfRangeException("Balance", "The balance is below the amount requested");
            }
        }
    }
}
