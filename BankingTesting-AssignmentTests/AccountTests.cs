using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingTesting_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingTesting_Assignment.Tests
{
    [TestClass()]
    public class AccountTests
    {
        private Bank b;
        private List<Customer> c;
        public AccountTests()
        {
            
        }

        public void Setup()
        {
            b = new Bank("Lorte bank", "2w235123");
            c = new List<Customer>
            {
                new Customer("0101011111", "Lars larsen", new List<Account>() {new Account("123",0)}),
                new Customer("0101012222", "Jens larsen", new List<Account>() {new Account("456", 0)}),
                new Customer("0101013333", "Yvonne larsen", new List<Account>() {new Account("789", 0)})
            };
            b.Customers = c;
        }
        public void Teardown()
        {
            b.Customers = c;
        }

        [TestMethod()]
        public void AccountDepositAndWithdraw()
        {
            // Arrange
            Setup();

            // Act
            b.Customers[0].Transfer(1000,b.Customers[0].Accounts[0],b.Customers[1]);


            //assert    
            Assert.AreEqual( -1000, b.Customers[0].Accounts[0].Balance);
            Assert.AreEqual( 1000, b.Customers[1].Accounts[0].Balance);
        }


    }
}