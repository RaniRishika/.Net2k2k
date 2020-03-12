using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Repositories;
namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repo;
        public OrderController(IOrderRepository repo)
        {
            _repo = repo;
        }
        //Get All Items
        [HttpGet]
        [Route("GetOrders")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetAllOrders());
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                return Ok(_repo.GetById(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }
        }
        [HttpPost]
        [Route("AddItem")]
        public IActionResult POST(Orders item)
        {
            try
            {
                _repo.AddOrder(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message + "\n" + ex.InnerException.Message);

            }
        }
        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult PUT(Orders order)
        {
            try
            {
                _repo.UpdateOrder(order);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);

            }
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(string id)
        {
            try
            {
                _repo.DeleteOrder(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return NotFound(ex.InnerException.Message);

            }
        }
    }
}