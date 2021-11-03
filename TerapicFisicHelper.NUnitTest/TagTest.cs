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
    public class TagTest
    {
        [Test]
        public void NameTest()
        {
            Tag tag = new Tag();
            tag.Name = "tag1";
            Assert.IsNotNull(tag.Name);
        }

        [Test]
        public void DescriptionTest()
        {
            Tag tag = new Tag();
            tag.Description = "description1";
            Assert.IsNotNull(tag.Description);
        }
    }
}
