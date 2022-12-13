using LearnGraphQL.DAL;
using LearnGraphQL.Models;

namespace LearnGraphQL
{
    public class BookMutations
    {
        [UseMutationConvention]
        public async Task<Book> AddBook(BooksContext context, Book book)
        {
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();
            return book;
        }
    }
}
