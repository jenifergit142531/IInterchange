using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi4.Dtos;
using webapi4.Models;

namespace webapi4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookContext _context;

        public BookController(BookContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _context.Books.ToListAsync();

            var bookasDto = new List<BookDto>();
            foreach(var book in books)
            {
                var bookDto = new BookDto
                {
                    Bid = book.Bid,
                    BookName = book.BookName,
                    Price = book.Price,
                    Author = new AuthorDto
                    {
                        AuthorId = book.AuthorId,
                        Name = book.Author.Name
                    }


                };
                 bookasDto.Add(bookDto);
            }
            return Ok(bookasDto);
        }
    }
}
