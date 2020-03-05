using System;

namespace BankingTesting_Assignment
{
    public static class MovementFactory
    {
        public static Movement CreateMovement(IAccount source, IAccount target, DateTime time, long amount)
        {
            return new Movement(source, target, time, amount);
        }
    }
}