using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore1._0.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        List<Book> Books;
        public BookRepository()
        {
            Books = new List<Book>()
            {
                new Book
                {
                    id=1,Title="C# programming",Descrption="No Descrption"
                },

                 new Book
                {
                    id=2,Title="java programming",Descrption="No thing"
                },

                  new Book
                {
                    id=3,Title="python programming",Descrption="No Data"
                },
            };
        
        }

        public void Add(Book entity)
        {
            Books.Add(entity); 
        }

        public void Delete(int id)
        {
            var book = Find(id);
            Books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = Books.SingleOrDefault(b => b.id==id);
            return book;
        }

        public IList<Book> List()
        {
            return Books;
        }

        public void Update(int id, Book newBook)
        {
            var book = Find(id);
            book.Title = newBook.Title;
            book.Descrption = newBook.Descrption;
            book.Author = newBook.Author;
        }
    }
}
