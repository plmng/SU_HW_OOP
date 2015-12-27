namespace TheBank.Interfaces
{
    using Customers;

    public interface IAccount
    {
        decimal Balance { get;}
        Customer Customer { get; }
        double InterestRate { get; }
        string Deposit(decimal amounth);
        decimal CallculatInterestForPeriod(int months);
    }
}
