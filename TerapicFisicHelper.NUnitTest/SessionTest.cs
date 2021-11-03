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
    public class SessionTest
    {
        [Test]
        public void IdTest()
        {
            Session session = new();
            session.Id = 43;
            Assert.IsNotNull(session.Id);

        }
        [Test]
        public void SpecialistIdTest2()
        {
            Session session = new();
            session.SpecialistId = 57;
            Assert.IsNotNull(session.SpecialistId);
        }
        [Test]
        public void TitleTest()
        {
            Session session = new();
            session.Title = "hge";
            Assert.IsNotNull(session.Title);

        }
        [Test]
        public void DescriptionTest4()
        {
            Session session = new();
            session.Description = "ssssyt";

            Assert.IsNotNull(session.Description);

        }
        [Test]
        public void StartHourTest()
        {
            Session session = new();
            session.StartHour = "5:15pm";

            Assert.IsNotNull(session.StartHour);

        }
        [Test]
        public void EndHourTest()
        {
            Session session = new();
            session.EndHour = "7:05pm";

            Assert.IsNotNull(session.EndHour);

        }
    }
}
