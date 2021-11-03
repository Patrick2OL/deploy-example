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
    class EquipamentSessionTest
    {

        [Test]
        public void EquipmentIdTest()
        {
            EquipamentSession equipamentSession = new EquipamentSession();
            equipamentSession.EquipamentId = 10;
            Assert.IsNotNull(equipamentSession.EquipamentId);

        }
        [Test]
        public void SessionIdTest()
        {
            EquipamentSession equipamentSession = new();
            equipamentSession.SessionId = 8;
            Assert.IsNotNull(equipamentSession.SessionId);
        }

      
        }
    }

