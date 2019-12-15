using System;
using System.Collections.Generic;
using Layers.API.Models;

namespace Layers.API.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Boolean CreateBook(Book book);
    }
}