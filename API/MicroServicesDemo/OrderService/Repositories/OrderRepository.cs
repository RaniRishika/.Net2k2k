using OrderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDBContext _context;
        public OrderRepository(ShopDBContext context)
        {
            _context = context;
        }
        public void AddOrder(Orders obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteOrder(string id)
        {
            Orders order = _context.Orders.Find(id);
            _context.Remove(order);
            _context.SaveChanges();
        }

        public List<Orders> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Orders GetById(string id)
        {
            return _context.Orders.Find(id);
        }

        public void UpdateOrder(Orders obj)
        {
            _context.Orders.Update(obj);
            _context.SaveChanges();
        }

       
    }
}
