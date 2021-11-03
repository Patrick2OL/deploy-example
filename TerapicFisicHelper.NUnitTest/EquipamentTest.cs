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
    public class EquipamentTest
    {
        [Test]
        public void NameTest()
        {
            Equipament equipament = new Equipament();
            equipament.Name = "Magneto";
            Assert.IsNotNull(equipament.Name);

        }
        [Test]
        public void IDtest()
        {
            Equipament equipament = new();
            equipament.Id = 4;
            Assert.IsNotNull(equipament.Id);
        }

        [Test]
        public void DescriptionTest2()
        {
            Equipament equipament = new();
            equipament.Description = "sss";
            Assert.IsNotNull(equipament.Description);
        }
    }
}
