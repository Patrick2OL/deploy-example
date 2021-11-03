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
    public class UserTest
    {
        [Test]
        public void NameTest()
        {
            User user = new User();
            user.Name = "user1";
            Assert.IsNotNull(user.Name);

        }

        [Test]
        public void LastNameTest()
        {
            User user = new User();
            user.LastName = "lastname";
            Assert.IsNotNull(user.LastName);

        }

        [Test]
        public void DescriptionTest()
        {
            User user = new User();
            user.Description = "description1";
            Assert.IsNotNull(user.Description);
        }

        [Test]
        public void AddressTest()
        {
            User user = new User();
            user.Address = "address";
            Assert.IsNotNull(user.Address);
        }

        [Test]
        public void EmailTest()
        {
            User user = new User();
            user.Email = "user@gmail.com";
            Assert.IsNotNull(user.Email);
        }

        [Test]
        public void CountryTest()
        {
            User user = new User();
            user.Country = "country";
            Assert.IsNotNull(user.Country);
        }

        [Test]
        public void GenderTest()
        {
            User user = new User();
            user.Gender = "masculino";
            Assert.IsNotNull(user.Gender);
        }

        [Test]
        public void PasswordTest()
        {
            User user = new User();
            user.Password = "password";
            Assert.IsNotNull(user.Password);
        }
    }
}
