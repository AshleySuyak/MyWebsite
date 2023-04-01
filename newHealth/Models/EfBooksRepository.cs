using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newHealth.Models
{
    public class EfBooksRepository : IBookRepository
    {
        private BookstoreContext context { get; set; }

        public EfBooksRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Books> Books => context.Books;
    }
}
