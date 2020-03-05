using System;
using System.Collections.Generic;

namespace BankingTesting_Assignment
{
    public class Customer : ICustomer
    {
        private string _cpr;
        private string _name;
        private List<IAccount> _accounts;

        public Customer(string cpr, string name, List<IAccount> accounts)
        {
            _cpr = cpr;
            _name = name;
            _accounts = accounts;
        }

        public string CPR
        {
            get => _cpr;
        }

        
        public List<IAccount> Accounts
        {
            get => _accounts;
        }

        public void Transfer(long amount, IAccount account, ICustomer target)
        {
            account.Withdrawal(amount,target.Accounts[0]);
            target.Accounts[0].Deposit(account, target.Accounts[0], amount);
            target.Accounts[0].DepositsLog.Add(MovementFactory.CreateMovement(account, target.Accounts[0], DateTime.Now, amount));
        }
    }
}