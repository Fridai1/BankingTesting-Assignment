using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingTesting_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace BankingTesting_Assignment.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        private List<ICustomer> customers;
        private IBank bank;
        public void Setup()
        {
            var bankMock = new Mock<IBank>();

            customers = new List<ICustomer>
            {
                new Customer("0101011111", "Lars larsen", new List<IAccount>() {new Account("123",0)}),
                new Customer("0101012222", "Jens larsen", new List<IAccount>() {new Account("456", 0)}),
            };
            bankMock.Setup(x => x.Customers).Returns(customers);

            bank = bankMock.Object;


        }
        [TestMethod()]
        public void MovementFromOneAccountToAnother()
        {
            // Arrange
            Setup();
            IAccount sourceAccount = bank.Customers[0].Accounts[0];
            IAccount targetAccount = bank.Customers[1].Accounts[0];
            ICustomer sourceCustomer = bank.Customers[0];
            ICustomer targetCustomer = bank.Customers[1];


            // Act
            sourceCustomer.Transfer(1000, sourceAccount, targetCustomer);


            //assert    
            Assert.AreEqual(1000, targetAccount.Balance);
            Assert.AreEqual(-1000, sourceAccount.Balance);
            
        }
    }
}