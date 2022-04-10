using FirstCoreApp.IRepostory;
using FirstCoreApp.Repository;
using FirstCoreModelApi.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookRepository _IbookRepostory;
        private BookRepository _bookRepository;
        public BooksController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpPost("BookInsert")]
        public IActionResult BookInsert(BooksInsert bookInsert)
        {
            var result = _bookRepository.BookInsert(bookInsert);
            return Ok();
        }
        [HttpGet("GetBooks")]
        public IActionResult GetBooks(Int32?id)
        {
            if (id == null)
            {
                var result = _bookRepository.GetBooks();
                return Ok(result);
            }
            else
            {
                var result = _bookRepository.GetBooksId(id);
                return Ok(result);
            }

         
        }
        [HttpPut("BooksUpdate")]
        public IActionResult BooksUpdate(BooksUpdate booksupdate)
        {
            var result = _bookRepository.BookUpdate(booksupdate);
            return Ok();
        }
        [HttpDelete("BooksDelete")]
        public IActionResult DeleteBooks(Int32? id)
        {
            var result = _bookRepository.BookDelete(id);
            return Ok(result);
        }
    }
}
