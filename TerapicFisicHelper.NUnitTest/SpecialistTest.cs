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
    public class SpecialistTest
    {
        [Test]
        public void SpecialtyTest(){
            Specialist specialist = new Specialist();
            specialist.Specialty = "especialidad1";
            Assert.IsNotNull(specialist.Specialty);
        }

        [Test]
        public void UserIdTest(){
            Specialist specialist = new Specialist();
            specialist.UserId = 1234;
            Assert.IsNotNull(specialist.UserId);
        }
    }
}
