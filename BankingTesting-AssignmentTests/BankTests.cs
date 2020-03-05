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
    public class BankTests
    {
        private Bank b;
        private IAccount a;
        private string aNo;

        public void setUp()
        {
            b = new Bank("DummyBank", "123");
            aNo = "123";
            var aMock = new Mock<IAccount>();
            aMock.Setup(ac => ac.Number).Returns(aNo);
            a = aMock.Object;
            b.AddAccount(a);


        }
        [TestMethod()]

        public void GetAccountByNumber()
        {
            //Arrange
            //Get dummy objects
            setUp();



            //Act
            var ac = b.GetAccount(aNo);


            //Assert
            Assert.AreEqual(a,ac);
        }
        [TestMethod()]
        [ExpectedException(typeof(Exception),"Account not found")]
        public void GetAccountByNumberWrongInput()
        {
            //Arrange
            setUp();

            //Act
            b.GetAccount("321");


            //Assert

            // Asserting exception thrown
        }

       

    }
}