using System;
using Xunit;
using ItemService.Models;
using ItemService.Repositories;
using ItemService.Controllers;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly Mock<IItemRepository> _repo;
        private readonly Mock<ShopDBContext> _context;
        private readonly ItemRepository obj;
        public UnitTest1()
        {
            _repo = new Mock<IItemRepository>();
            _context = new Mock<ShopDBContext>();
            obj = new ItemRepository(_context.Object);
        }
        [Fact]
        public void GetItems()
        {
            _repo.Setup(m => m.GetAllItems()).Returns(GetItemsData());
            
            var result = obj.GetAllItems() as List<Items>;
            Assert.NotNull(result);
        }

        private List<Items> GetItemsData()
        {
            return new List<Items>(){
                new Items() { Itemid = "100" }
            };
        }
    }
}
