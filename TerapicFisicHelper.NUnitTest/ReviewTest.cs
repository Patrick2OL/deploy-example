using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TerapicFisicHelper.Entities;

namespace TerapicFisicHelper.NUnitTest
{
    [TestFixture]
    public class ReviewTest
    {

        [Test]
        public void DescriptionTest3()
        {
            Review review = new Review();
            review.Description = "ssssg";

            Assert.IsNotNull(review.Description);

        }
        [Test]
        public void RankTest()
        {
            Review review = new();
            review.Rank = 20;
            Assert.IsNotNull(review.Rank);
        }

        [Test]
        public void CustomerIdTest2()
        {
            Review review = new();
            review.CustomerId = 34;
            Assert.IsNotNull(review.CustomerId);
        }
        [Test]
        public void SpecialistIdTest()
        {
            Review review = new();
            review.SpecialistId = 56;
            Assert.IsNotNull(review.SpecialistId);
        }


    }
}
