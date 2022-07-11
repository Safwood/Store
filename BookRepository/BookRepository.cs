
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[] {

            new Book("С# language", "Karl", 52, "ISBN 555-651", "Interesting book", 5.6m, 1),
            new Book("Architecture of applications",  "Not Karl", 6, "ISBN 555-655", "Interesting book", 5.8m, 2),
            new Book("Python vs Java",  "Einstein", 66, "ISBN 555-656", "Interesting book", 5.4m, 3)
        };

        public Book[] GetAllByTitleOrAuthor(string titleExtract)
        {
            return books.Where(book => ((book.Title).ToLower()).Contains(titleExtract.ToLower())).ToArray();
            
        }

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where((book) => book.Isbn.Contains(isbn)).ToArray();  
        }
        
        public Book GetById(int id)
        {
            return books.Single((book) => book.Id == id);  
        }

        public Book[] GetBooksById(IEnumerable<int> bookIds)
        {
            var foundBooks = from book in books
                join id in bookIds on book.Id equals id
                select book;

            return foundBooks.ToArray();
        }
    }
}