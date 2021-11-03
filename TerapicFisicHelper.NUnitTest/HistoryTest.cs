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
    class HistoryTest
    {

        [Test]
        public void CustomerIDTest()
        {
            History history = new History();
            history.CustomerId = 11;
            Assert.IsNotNull(history.CustomerId);

        }
        [Test]
        public void SessionIdTest2()
        {
            History history = new();
            history.SessionId = 12;
            Assert.IsNotNull(history.SessionId);
        }

    }
}
