using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi2.Context;
using webapi2.Models;

namespace webapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropRentsController : ControllerBase
    {
        private readonly RentalContext _context;

        public PropRentsController(RentalContext context)
        {
            _context = context;
        }

        // GET: api/PropRents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropRent>>> GetpropRents()
        {
            return await _context.propRents.ToListAsync();
        }

        // GET: api/PropRents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PropRent>> GetPropRent(int id)
        {
            var propRent = await _context.propRents.FindAsync(id);

            if (propRent == null)
            {
                return NotFound();
            }

            return propRent;
        }

        // PUT: api/PropRents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPropRent(int id, PropRent propRent)
        {
            if (id != propRent.PropId)
            {
                return BadRequest();
            }

            _context.Entry(propRent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropRentExists(id))
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

        // POST: api/PropRents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PropRent>> PostPropRent(PropRent propRent)
        {
            _context.propRents.Add(propRent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPropRent", new { id = propRent.PropId }, propRent);
        }

        // DELETE: api/PropRents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePropRent(int id)
        {
            var propRent = await _context.propRents.FindAsync(id);
            if (propRent == null)
            {
                return NotFound();
            }

            _context.propRents.Remove(propRent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PropRentExists(int id)
        {
            return _context.propRents.Any(e => e.PropId == id);
        }
    }
}
