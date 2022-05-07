using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderAPI.Models;
using OrderTest;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext Ordercontext;

        public OrdersController(OrderContext context)
        {
            Ordercontext = context;
        }

        // GET: api/Orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return Ordercontext.Orders
                                .Include(o => o.OrderDetails)
                                .ThenInclude(d=>d.Goods)
                                .ToList();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order =  Ordercontext.Orders
                                          .Include(o => o.OrderDetails)
                                          .ThenInclude(d => d.Goods)
                                          .FirstOrDefault(o=>o.OrderId==id);
            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }

            Ordercontext.Entry(order).State = EntityState.Modified;

            try
            {
                await Ordercontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            Ordercontext.Orders.Add(order);
            try
            {
                await Ordercontext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrderExists(order.OrderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(int id)
        {
            var order =  Ordercontext.Orders
                            .Include(o => o.OrderDetails)
                            .ThenInclude(d => d.Goods)
                            .FirstOrDefault(o=>o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            Ordercontext.Orders.Remove(order);
            Ordercontext.SaveChanges();

            return order;
        }

        private bool OrderExists(int id)
        {
            return Ordercontext.Orders.Any(e => e.OrderId == id);
        }
    }
}
