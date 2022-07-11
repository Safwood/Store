namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByTitleOrAuthor(string titleorAuthorExtract);
        Book[] GetAllByIsbn(string isbn);
        Book GetById(int id);
        Book[] GetBooksById(IEnumerable<int> bookIds);
    }
}
