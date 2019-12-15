using System;

namespace Layers.API.Models
{
    public class Book : EntityBase
    {
        public Book() : base()
        {
        }

        public Book(String ident) : base(ident)
        {
        }

        public String Title { get; set; }
        public String ISBN { get; set; }
        public String YearPublication { get; set; }
    }
}