using Microsoft.EntityFrameworkCore;

namespace UI.Data
{
    public class BookService
    {
        private readonly CddSoiPocContext _context;

        public BookService(CddSoiPocContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _context.Books.Take(100).ToListAsync();
        }
    }
}
