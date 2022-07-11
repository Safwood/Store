using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class BookService
    {
        IBookRepository BookRepository;
        public BookService(IBookRepository bookRepository)
        {
            this.BookRepository = bookRepository;
        } 
        public Book[] GetAllByQuery(string query)
        {

            if(Book.IsIsbn(query))
            {
                return BookRepository.GetAllByIsbn(query);
            } else
            {
                return BookRepository.GetAllByTitleOrAuthor(query);
            }
        }
    }
}
