using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi3.Models;

namespace webapi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SecretKeyAttibute]
    public class CarParkingsController : ControllerBase
    {
        private readonly MydbfirstContext _context;

        public CarParkingsController(MydbfirstContext context)
        {
            _context = context;
        }

        // GET: api/CarParkings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarParking>>> GetCarParkings()
        {
            return await _context.CarParkings.ToListAsync();
        }

        // GET: api/CarParkings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarParking>> GetCarParking(int id)
        {
            var carParking = await _context.CarParkings.FindAsync(id);

            if (carParking == null)
            {
                return NotFound();
            }

            return carParking;
        }

        // PUT: api/CarParkings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarParking(int id, CarParking carParking)
        {
            if (id != carParking.Tokenid)
            {
                return BadRequest();
            }

            _context.Entry(carParking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarParkingExists(id))
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

        // POST: api/CarParkings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarParking>> PostCarParking(CarParking carParking)
        {
            _context.CarParkings.Add(carParking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarParking", new { id = carParking.Tokenid }, carParking);
        }

        // DELETE: api/CarParkings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarParking(int id)
        {
            var carParking = await _context.CarParkings.FindAsync(id);
            if (carParking == null)
            {
                return NotFound();
            }

            _context.CarParkings.Remove(carParking);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarParkingExists(int id)
        {
            return _context.CarParkings.Any(e => e.Tokenid == id);
        }
    }
}
