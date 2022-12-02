using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SampleUnitTest;

namespace BankAccountsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
           
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccounts account = new BankAccounts("Ragini Singh", beginningBalance);

            account.Debit(debitAmount);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}