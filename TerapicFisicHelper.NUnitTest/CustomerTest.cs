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
    public class CustomerTest
    {
        //probamos los metodos de la entidad customer

        [Test]
        public void DescriptionTest()
        {
            Customer customer = new Customer();
            customer.Description = "sss";

            Assert.IsNotNull(customer.Description);

        }
        [Test]
        public void IDtest()
        {
            Customer customer = new();
            customer.Id = 4;
            Assert.IsNotNull(customer.Id);
        }

        [Test]
        public void UserIDtest()
        {
            Customer customer = new();
            customer.UserId = 8;
            Assert.IsNotNull(customer.UserId);
        }
    }
}
