using System.Collections.Generic;
using System.Linq;

namespace BankingTesting_Assignment
{
    public class Bank : IBank
    {
        private string _cvr;
        private string _name;
        private List<Customer> _customers;
        private List<Account> _accounts;

        public Bank(string name, string cvr)
        {
            _customers = new List<Customer>();
            _accounts = new List<Account>();
            _name = name;
            _cvr = cvr;
        }



        public Account GetAccount(string number)
        {
           return _accounts.Find(x => x.Number == number);
        }

        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }

        public List<Account> GetAccounts(Customer customer)
        {
            List<Account> customerAccounts = new List<Account>();
            for (int i = 0; i < _accounts.Count; i++)
            {
                customerAccounts.Add(_accounts.Find(x => x.Number == customer.Accounts[i].Number));
            } 
            return customerAccounts;
        }
    }
}