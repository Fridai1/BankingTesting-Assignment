using System.Collections.Generic;

namespace BankingTesting_Assignment
{
    public interface IAccount
    {
        long Balance { get; set; }
        List<Movement> DepositsLog { get; }
        List<Movement> WithdrawalsLog { get; }
        string Number { get; }
        void Deposit(IAccount source, IAccount target, long amount);
        void Withdrawal(long amount, IAccount target);
    }
}