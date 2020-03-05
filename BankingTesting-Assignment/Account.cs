using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BankingTesting_Assignment
{

    public class Account : IAccount
    {
        
        private string _number;
        private long _balance;
        private List<Movement> _deposits;
        private List<Movement> _withrawal;

        public Account(string number, long balance)
        {
            
            _number = number;
            _balance = balance;
            _deposits = new List<Movement>();
            _withrawal = new List<Movement>();
        }

        public long Balance
        {
            get => _balance;
            set => _balance += value; 
        }

        public List<Movement> DepositsLog
        {
            get => _deposits;
        }
        public List<Movement> WithdrawalsLog
        {
            get => _withrawal;
        }

        public string Number
        {
            get => _number;
        }

        public void Deposit(IAccount source, IAccount target, long amount)
        {
            Balance = amount;
            _deposits.Add(MovementFactory.CreateMovement(source,target,DateTime.Now,amount));
        }


        public void Withdrawal(long amount, IAccount source)
        {
            Balance = -amount;
            _withrawal.Add(MovementFactory.CreateMovement(this,source,DateTime.Now, amount));
        }


        
    }
}