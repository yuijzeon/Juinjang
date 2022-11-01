using System.Linq;
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
            var toDb = new ProductEntity
            {
                Id = 3,
                Name = "Black Duck",
                Price = 1000
            };

            using (var db = new JuinjangContext())
            {
                db.Products.Add(toDb);
                var count = db.SaveChanges();
                Assert.AreEqual(1, count);
            }
        }

        [Test]
        public void Select()
        {
            using (var db = new JuinjangContext())
            {
                var productEntities = db.Products.AsEnumerable();
            }
        }
    }
}