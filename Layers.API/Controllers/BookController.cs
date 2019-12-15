using System;
using System.Collections.Generic;
using Layers.API.Models;
using Layers.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Layers.API.Controllers
{
    [ApiController]
    [Route("api/v1/book")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger,
                               IBookService service)
        {
            this._logger = logger;
            this._service = service;
        }

        [HttpGet]
        public IActionResult getLayer()
        {
            //this._logger
            return Ok(new
            {
                success = true,
                data = _service.GetBooks()
            });
        }

        [HttpPost]
        public IActionResult createBook(Book book)
        {
            if (book != null)
            {
                bool isCreatedBook = _service.CreateBook(book);

                return Ok(new
                {
                    sucess = isCreatedBook,
                    data = book
                });
            }
            return NoContent();
        }

    }
}