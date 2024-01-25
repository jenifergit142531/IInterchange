using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi6.Models;

namespace webapi6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductChecksController : ControllerBase
    {
        private readonly ProContext _context;

        public ProductChecksController(ProContext context)
        {
            _context = context;
        }

        // GET: api/ProductChecks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductCheck>>> GetProductChecks()
        {
            return await _context.ProductChecks.ToListAsync();
        }

        // GET: api/ProductChecks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductCheck>> GetProductCheck(int id)
        {
            var productCheck = await _context.ProductChecks.FindAsync(id);

            if (productCheck == null)
            {
                return NotFound();
            }

            return productCheck;
        }

        // PUT: api/ProductChecks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductCheck(int id, ProductCheck productCheck)
        {
            if (id != productCheck.Id)
            {
                return BadRequest();
            }

            _context.Entry(productCheck).State = EntityState.Modified;

            try
            {
                productCheck.Version = Guid.NewGuid();
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCheckExists(id))
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

        // POST: api/ProductChecks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductCheck>> PostProductCheck(ProductCheck productCheck)
        {
            productCheck.Version = Guid.NewGuid();
            _context.ProductChecks.Add(productCheck);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductCheck", new { id = productCheck.Id }, productCheck);
        }

        // DELETE: api/ProductChecks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductCheck(int id)
        {
            var productCheck = await _context.ProductChecks.FindAsync(id);
            if (productCheck == null)
            {
                return NotFound();
            }

            _context.ProductChecks.Remove(productCheck);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductCheckExists(int id)
        {
            return _context.ProductChecks.Any(e => e.Id == id);
        }
    }
}
