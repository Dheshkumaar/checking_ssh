using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnitEg;
using Assert = NUnit.Framework.Assert;

namespace BankTest
{
    [TestFixture]
    public class UnitTest1
    {
        Banking obj = new Banking();
        double bal;
        [Test]
        public void TestDepositAmtPass()
        {
            obj.DepositAmount(60);
            bal = obj.Balance;
            Assert.AreEqual(60, bal);
        }
        [Test]
        public void TestDeposutAmtNegativeValue()
        {
            Banking obj = new Banking();
            obj.DepositAmount(-90);
            double balance = 0;
            bal = obj.Balance;
            Assert.AreEqual(balance, bal);
        }
        [Test]
        public void TestWithdrawAmtNotEnoughBalance()
        {
            obj.WithdrawAmount(60006);
            Assert.AreEqual("Sorry! Not Enough Balance ", obj.msg);
        }
        [Test]
        public void TestWithdrawAmt()
        {
            //obj.DepositAmount(100);
            obj.WithdrawAmount(60);
            Assert.AreEqual("Success", obj.msg);
        }

    }
}
