using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly OrderContext _context;

        public OrdersController(OrderContext context)
        {
            _context = context;
            if (_context.Orders.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.Orders.Add(new Order { ID = 1,Customer="Allen",GoodsName="Apple",Price=15 });
                _context.Orders.Add(new Order { ID = 2, Customer = "Max", GoodsName = "Hem", Price = 35 });
                _context.Orders.Add(new Order { ID = 3, Customer = "Zoe", GoodsName = "Banana", Price = 30 });
                _context.SaveChanges();
            }
        }

        // GET: Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Index()
        {
            return await _context.Orders.ToListAsync();
        }


        // GET: api/orders/2
        [HttpGet("{ID}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }


        // POST: api/orders
        [HttpPost]
    
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            _context.Orders.Add(order);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrder), new { id = order.ID }, order);
        }


        // PUT: api/Orders/5
        [HttpPut("{ID}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.ID)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }




        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteTodoItem(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return order;
        }

        
    }
}
