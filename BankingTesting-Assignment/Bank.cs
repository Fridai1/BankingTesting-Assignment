using System;
using System.Collections.Generic;
using System.Linq;

namespace BankingTesting_Assignment
{
    public class Bank : IBank
    {
        private string _cvr;
        private string _name;
        private List<ICustomer> _customers;
        private List<IAccount> _accounts;

        public Bank(string name, string cvr)
        {
            _customers = new List<ICustomer>();
            _accounts = new List<IAccount>();
            _name = name;
            _cvr = cvr;
        }


        public IAccount GetAccount(string number)
        {
            
            var c = _accounts.Exists(x => x.Number == number);
            if (number != null && _accounts.Exists(x => x.Number == number))
            {
                return _accounts.Find(x => x.Number == number);
            }

            throw new Exception($"Account not found");

        }

        public List<ICustomer> Customers
        {
            get => _customers;
            set => _customers = value;
        }


        public void AddAccount(IAccount a)
        {
            _accounts.Add(a);
        }

        

        public List<IAccount> GetAccounts(ICustomer customer)
        {
            List<IAccount> customerAccounts = new List<IAccount>();
            for (int i = 0; i < _accounts.Count; i++)
            {
                customerAccounts.Add(_accounts.Find(x => x.Number == customer.Accounts[i].Number));
            } 
            return customerAccounts;
        }
    }
}