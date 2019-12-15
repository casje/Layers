using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Layers.API.Models;
using Layers.API.Context;

namespace Layers.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IServiceScope _serviceScope;
        private readonly LayersDbContext _dbContext;
        public BookRepository(IServiceProvider serviceProvider)
        {
            _serviceScope = serviceProvider.CreateScope();

            _dbContext = _serviceScope.ServiceProvider.GetRequiredService<LayersDbContext>();
        }
        public IEnumerable<Book> getItemsAll()
        {
            return _dbContext.Books;
        }
        public Boolean createItem(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();

            return true;
        }
    }

}