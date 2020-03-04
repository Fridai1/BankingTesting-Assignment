using System;
using System.Collections.Generic;

namespace BankingTesting_Assignment
{
    public class Movement
    {
        private Account _source;
        private Account _target;
        private DateTime _time;
        private long _amount;

        public Movement(Account source, Account target, DateTime time, long amount)
        {
            _source = source;
            _target = target;
            _time = time;
            _amount = amount;
        }
    }
}