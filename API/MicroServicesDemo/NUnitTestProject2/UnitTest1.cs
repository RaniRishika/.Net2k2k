using NUnit.Framework;
using ItemService.Models;
using ItemService.Repositories;
namespace NUnitTestProject2
{
    public class Tests
    {
        ItemRepository repo = null;
        [SetUp]
        public void Setup()
        {
           repo = new ItemRepository(new ShopDBContext());
        }

        [Test]
        public void Test1()
        {
            
            var result = repo.GetAllItems();
            Assert.GreaterOrEqual(result.Count, 4);
           
        }
        [Test]
        public void Test2()
        {
            var result = repo.GetById("10001");
            Assert.NotNull(result);
        }
        [Test]
        public void Test3()
        {
            repo.DeleteItem("10001");
            var result = repo.GetById("10001");
            Assert.Null(result);
        }
        [Test]
        public void Test4()
        {
            repo.AddItem(new Items() { Itemid = "10001", Name = "ABC", Price = 12, Stock = 20 });
            var result = repo.GetById("10001");
            Assert.NotNull(result);
        }
    }
}