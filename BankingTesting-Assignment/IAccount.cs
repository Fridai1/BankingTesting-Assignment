using System.Collections.Generic;

namespace BankingTesting_Assignment
{
    public interface IAccount
    {
        long Balance { get; set; }
        List<Movement> DepositLog { get; }
        string Number { get; }
        void Deposit(Account source, Account target, long amount);
        void Withdrawal(long amount, Account target);
    }
}