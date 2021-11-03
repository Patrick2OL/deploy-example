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
    public class TagSessionTest
    {
        [Test]
        public void TagIdTest()
        {
            TagSession tagsession = new TagSession();
            tagsession.TagId = 1234;
            Assert.IsNotNull(tagsession.TagId);
        }

        [Test]
        public void SessionIdTest()
        {
            TagSession tagsession = new TagSession();
            tagsession.SessionId = 1;
            Assert.IsNotNull(tagsession.SessionId);
        }
    }
}
