using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Layers.API.Models;
using Layers.API.Context;

namespace Layers.API.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        //private readonly IServiceScope _serviceScope;
        //private readonly LayersDbContext _dbContext;
        public BookRepository(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            //_serviceScope = serviceProvider.CreateScope();
            //_dbContext = _serviceScope.ServiceProvider.GetRequiredService<LayersDbContext>();
        }
    }

}