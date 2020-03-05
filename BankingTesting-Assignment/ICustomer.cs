using System.Collections.Generic;

namespace BankingTesting_Assignment
{
    public interface ICustomer
    {
        void Transfer(long amount, IAccount account, ICustomer target);
        List<IAccount> Accounts { get; }
    }
}