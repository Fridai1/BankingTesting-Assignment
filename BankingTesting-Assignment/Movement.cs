using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BankingTesting_Assignment
{
    public class Movement
    {
        private IAccount _source;
        private IAccount _target;
        private DateTime _time;
        private long _amount;

        public Movement(IAccount source, IAccount target, DateTime time, long amount)
        {
            _source = source;
            _target = target;
            _time = time;
            _amount = amount;
        }

        public IAccount Source
        {
            get => _source;
        }
        public IAccount Target
        {
            get => _target;
        }
        public long Amount
        {
            get => _amount;
        }
    }
}