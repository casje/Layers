using System;
using System.Collections.Generic;
using Layers.API.Models;

namespace Layers.API.Repositories
{
    public interface IBookRepository //<T> where T : Book
    {
        IEnumerable<Book> getItemsAll();
        Boolean createItem(Book book);
    }

}