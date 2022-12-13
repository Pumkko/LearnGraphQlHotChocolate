using LearnGraphQL.DAL;
using LearnGraphQL.Models;

namespace LearnGraphQL
{
    public class BookQuery
    {
        [UseProjection]
        [UseFiltering]
        public IEnumerable<Book> GetBooks(BooksContext booksContext)
        {
            return booksContext.Books;
        }
    }
}
