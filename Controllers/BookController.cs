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

      //  [HttpGet]
        //[Route("get")]
       // public async Task<IActionResult> GetAllBooks()
        //{
            // var books = await _context.Books.ToListAsync();

            //implement eager loading isong Include()

           // var books = await _context.Books.Include(b => b.Author).ToListAsync();

            /*   var bookasDto = new List<BookDto>();*/

           /* var mybooklist = new List<Books>();
               foreach(var book in books)
               {
                   var result = new Books
                   {
                       Bid = book.Bid,
                       BookName = book.BookName,
                       Price = book.Price,
                       Author = new Authors
                       {
                           AuthorId = book.AuthorId,
                           Name = book.Author.Name
                       }


                   };
                mybooklist.Add(result);
               }*/
             //  return Ok(books);

               

           // return Ok(books);


        }
    }

