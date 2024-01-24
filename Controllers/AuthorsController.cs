using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi4.Models;

namespace webapi4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly BookContext _context;

        public AuthorsController(BookContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getauth")]
        public async Task<ActionResult<IEnumerable<Authors>>> GetAuthors(int id)
        {
            var authors = await _context.Authors.Include(x => x.Books).ToListAsync();
            
            return authors;
        }

        [HttpGet]
        [Route("getauth/{id}")]
        public async Task<ActionResult<Authors>> GetAuthorsById(int id)
        {
            var authors = await _context.Authors.Include(x => x.Books).FirstOrDefaultAsync(a => a.AuthorId == id);
            if(authors==null)
            {
                return NotFound();
            }
            return authors;
        }
    }
}
