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
            _repository.CreateEntity(book);
            _repository.Save();
            return true;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _repository.GetAll();
        }
    }
}