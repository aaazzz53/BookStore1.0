using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore1._0.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Descrption { get; set; }
        public Author Author { get; set; }
    }
}
