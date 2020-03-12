using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ItemService.Models;
using ItemService.Repositories;
namespace TestProject1
{
    [TestFixture]
    public class TestItemService
    {
        ItemRepository _repo;
        [SetUp]
        public void SetUp()
        {
            _repo = new ItemRepository(new ShopDBContext());
        }
        [Test]
        public void TestGetAllItems()
        {
            var result = _repo.GetAllItems();
            Assert.IsNotNull(result);
            Assert.Greater(result.Count, 4);
        }
        [Test]
        public void TestGetById()
        {
            var result = _repo.GetById("10010");
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestAddItem()
        {
            _repo.AddItem(new Items()
            {
                Itemid = "10006",
                Name="ABC",
                Price=10,
                Stock=100
            });
            var result = _repo.GetById("10006");
            Assert.NotNull(result);
        }
        [Test]
        [Description("Test DeleteItem()")]
        public void TestDeleteItem()
        {
            _repo.DeleteItem("10006");
            var result = _repo.GetById("10006");
            Assert.Null(result);


        }
        [Test]
        public void TestUpdate()
        {
            //Arrage
            Items item = _repo.GetById("10001");
            item.Price = 200;
            _repo.UpdateItem(item);
            Items item1 = _repo.GetById("10001");
            Assert.AreSame(item, item1);

        }
    }
}
