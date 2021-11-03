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
    public class SubscriptionPlanTest
    {
        [Test]
        public void NameTest()
        {
            SubscriptionPlan subscriptionPlan = new SubscriptionPlan();
            subscriptionPlan.Name = "plan1";
            Assert.IsNotNull(subscriptionPlan.Name);
        }

        [Test]
        public void DescriptionTest()
        {
            SubscriptionPlan subscriptionPlan = new SubscriptionPlan();
            subscriptionPlan.Description = "description1";
            Assert.IsNotNull(subscriptionPlan.Description);
        }
    }
}
