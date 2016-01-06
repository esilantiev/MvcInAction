using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcInAction.Models;

namespace UnitTesting
{
    [TestClass]
    public class ItemTesting
    {
        [TestMethod]
        public void CanAddBid()
        {
            Item target = new Item();
            Member member = new Member();
            Decimal amount = 150M;

            target.AddBid(member, amount);

            Assert.AreEqual(1, target.Bids.Count);
            Assert.AreEqual(amount, target.Bids[0].Amount);
            
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CannotAddLowerBid()
        {
            Item target = new Item();
            Member member = new Member();
            Decimal amount = 150M;

            target.AddBid(member, amount);
            target.AddBid(member, amount-10);

            
        }

        [TestMethod]
        public void CanAddHigherBid()
        {
            Item target = new Item();
            Member firstMember = new Member();
            Member secondMember = new Member();
            Decimal amount = 150M;

            target.AddBid(firstMember, amount);
            target.AddBid(secondMember, amount + 10);

            Assert.AreEqual(2, target.Bids.Count);
            Assert.AreEqual(amount+10, target.Bids[1].Amount);
        }
    }
}
