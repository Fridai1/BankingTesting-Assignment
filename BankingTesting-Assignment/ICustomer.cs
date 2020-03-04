namespace BankingTesting_Assignment
{
    public interface ICustomer
    {
        void Transfer(long amount, Account account,Customer target);
    }
}