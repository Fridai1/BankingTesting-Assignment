using System.Collections.Generic;

namespace BankingTesting_Assignment
{
    public interface IBank
    {
        IAccount GetAccount(string number);
        List<IAccount> GetAccounts(ICustomer customer);
        void AddAccount(IAccount account);

        List<ICustomer> Customers { get; set; }
    }
}