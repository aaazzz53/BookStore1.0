using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore1._0.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Author>
    {
        List<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author{id=1,FullName="Abbdullah Tkruni"},
                new Author{id=2,FullName="hamed makbwl"},
                new Author{id=3,FullName="saed sameh"},
            };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(a => a.id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors; 
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName;
        }
    }
}
