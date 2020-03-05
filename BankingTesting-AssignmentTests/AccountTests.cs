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
    public class AccountTests
    {
        private IBank bank;
        private ICustomer customer;
        private List<ICustomer> customers;

        public void Setup()
        {
            var bankMock = new Mock<IBank>();

            customers = new List<ICustomer>
            {
                new Customer("0101011111", "Lars larsen", new List<IAccount>() {new Account("123",0)}),
                new Customer("0101012222", "Jens larsen", new List<IAccount>() {new Account("456", 0)}),
                new Customer("0101013333", "Yvonne larsen", new List<IAccount>() {new Account("789", 0)})
            };
            bankMock.Setup(x => x.Customers).Returns(customers);

            bank = bankMock.Object;


        }
        public void Teardown()
        {
            bank.Customers = customers;
        }

        [TestMethod()]
        public void IsMoneyDepositedInAccount()
        {
            // Arrange
            Setup();
            
            // Act
            bank.Customers[0].Transfer(1000, bank.Customers[0].Accounts[0], bank.Customers[1]);


            //assert    
            Assert.AreEqual( 1000, bank.Customers[1].Accounts[0].Balance);
            Teardown();
        }

        [TestMethod()]
        public void IsMoneyWithdrawnFromAccount()
        {
            // Arrange
            Setup();

            // Act
            bank.Customers[0].Transfer(1000, bank.Customers[0].Accounts[0], bank.Customers[1]);


            //assert    
            Assert.AreEqual(-1000, bank.Customers[0].Accounts[0].Balance);
            Teardown();
        }

        [TestMethod()]
        public void MovementFromOneAccountToAnother()
        {
            // Arrange
            Setup();
            IAccount source = bank.Customers[0].Accounts[0];
            IAccount target = bank.Customers[1].Accounts[0];

            // Act
            bank.Customers[0].Transfer(1000, source, bank.Customers[1]);
            

            //assert    
            Assert.AreEqual(1,bank.Customers[0].Accounts[0].WithdrawalsLog.Count);
            Assert.AreEqual(source.WithdrawalsLog[0].Target, target.DepositsLog[0].Source);
            
            //Assert.AreEqual(1,bank.Customers[0].Accounts[0].WithdrawalsLog.Count);
            //Assert.AreEqual(1,bank.Customers[0].Accounts[0].WithdrawalsLog.Count);
            Teardown();
        }


    }
}