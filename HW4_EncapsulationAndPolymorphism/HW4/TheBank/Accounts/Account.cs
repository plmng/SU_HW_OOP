namespace TheBank.Accounts
{
    using System;
    using Customers;
    using Interfaces;

    public abstract class Account: IAccount
    {
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance { get; protected set; }
        public Customer Customer { get; private set; }
        public double InterestRate { get; private set; }

        public abstract decimal CallculatInterestForPeriod(int months);

        protected decimal CalculateInterestBaseFormula(decimal money, int months, double interestRate)
        {
            var interest = money*(1 +(decimal)(interestRate*months));
            return interest;
        }

        public string Deposit(decimal amounth)
        {
            this.Balance += amounth;
            return String.Format("Deposit: {0}, Balance: {1}", amounth, this.Balance);
        }

        public override string ToString()
        {
            return string.Format("Acc type: {0}\nCustomer type: {1}\nBalance: {2}, InterestRate: {3}",
                this.GetType().Name, this.Customer.GetType().Name, this.Balance, this.InterestRate);
        }
    }
}
