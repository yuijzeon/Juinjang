using System;
using NUnit.Framework;
using ProductPrice.Database;

namespace ProductPrice.UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Insert()
        {
            var toDb = new Product 
            {
                Id   = 1,
                Name = "Yellow Duck",
                Price  = 1000
            };
            using (var db = new JuinjangContext())
            {
                db.Products.Add(toDb);
                var count = db.SaveChanges();
                Assert.AreEqual(1, count);
            }
        }
    }
}