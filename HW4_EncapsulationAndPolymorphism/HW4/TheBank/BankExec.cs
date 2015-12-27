namespace TheBank
{
    using System;
    using Accounts;
    using Customers;
    using Interfaces;

    public class BankExec
    {
        static void Main(string[] args)
        {
            var customerIndividual = new Individual("Ivan Ivanov");
            var customerCompany = new Company("Ivanov OOD");
           
            var accounts = new IAccount[]
            {
                new LoanAccount(customerIndividual, 10),
                new LoanAccount(customerCompany, 10),
                new MortgageAccount(customerIndividual, 10),
                new MortgageAccount(customerCompany, 10)
            };
            var depositAccount = new DepositAccount[]
            {
                new DepositAccount(customerIndividual, 10),
                new DepositAccount(customerCompany, 10),
            };

            foreach (var daccount in depositAccount)
            {
                Console.WriteLine("Test account");
                Console.WriteLine("-------------");
                Console.WriteLine(daccount);
                Console.WriteLine("Calling Deposit method. Result: {0}", daccount.Deposit(1000));
                Console.WriteLine("Calling Calculate Interest for Period 3 months. Result: {0}",
                    daccount.CallculatInterestForPeriod(3));
                Console.WriteLine("Calling Withdraw method. Result: {0}", daccount.Withdraw(200));
                Console.WriteLine("Calling Calculate Interest for Period 3 months. Result: {0}",
                   daccount.CallculatInterestForPeriod(3));
                Console.WriteLine("Calling Withdraw method. Result: {0}", daccount.Withdraw(801));
                Console.WriteLine();
            }
            foreach (var account in accounts)
            {
                Console.WriteLine("Test account");
                Console.WriteLine("-------------");
                Console.WriteLine(account);
                Console.WriteLine("Calling Deposit method. Result: {0}", account.Deposit(1000));
                Console.WriteLine("Calling Calculate Interest for Period 3 months. Result: {0}\n",
                    account.CallculatInterestForPeriod(3));
            }
        }
    }
}
