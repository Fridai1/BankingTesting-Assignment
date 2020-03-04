using System.Collections.Generic;

namespace BankingTesting_Assignment
{
    public interface IBank
    {
        Account GetAccount(string number);
        List<Account> GetAccounts(Customer customer);
    }
}