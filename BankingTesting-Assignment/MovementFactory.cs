using System;

namespace BankingTesting_Assignment
{
    public static class MovementFactory
    {
        public static Movement CreateMovement(Account source, Account target, DateTime time, long amount)
        {
            return new Movement(source,target,time,amount);
        }
    }
}