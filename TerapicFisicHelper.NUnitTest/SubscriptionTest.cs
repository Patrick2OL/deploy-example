using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TerapicFisicHelper.Entities;

namespace TerapicFisicHelper.UnitTest
{
    [TestFixture]
    public class SubscriptionTest
    {
        [Test]
        public void CustomerIdTest(){
            Subscription subscription = new Subscription();
            subscription.CustomerId = 123;
            Assert.IsNotNull(subscription.CustomerId);
        }

        [Test]
        public void SubscriptionPlanIdTest() {
            Subscription subscription = new Subscription();
            subscription.SubscriptionPlanId = 1;
            Assert.IsNotNull(subscription.SubscriptionPlanId);
        }
    }
}
