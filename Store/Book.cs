using System.Text.RegularExpressions;

namespace Store
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PagesCount { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Book( string title, 
            string author, 
            int pagesCount, 
            string isbn, 
            string description, 
            decimal price, int id) { 
            Id = id;
            Title = title;
            Author = author;
            PagesCount = pagesCount; 
            Isbn = isbn;
            Description = description;
            Price = price;
        }
        internal static bool IsIsbn(string extract) {
            if (extract == null)
            {
                return false;
            }

            extract = extract
                .Replace("-", "")
                .Replace(" ", "")
                .ToUpper();
            return Regex.IsMatch(extract, @"ISBN\d{10}"); 
        }

    }
}