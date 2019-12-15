using System;
using System.Collections.Generic;
using Layers.API.Models;
using Layers.API.Repositories;

namespace Layers.API.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            this._repository = repository;
        }
        public Boolean CreateBook(Book book)
        {
            return _repository.createItem(book);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _repository.getItemsAll();
        }
    }
}