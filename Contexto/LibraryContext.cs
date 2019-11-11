using Microsoft.EntityFrameworkCore;
using MVC_Core_Books.Models;

namespace Contexto.LibraryContext{

 public class LibraryContext: DbContext
        {
        public LibraryContext(DbContextOptions<LibraryContext> options):base(options)
        {
            Database.Migrate();
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}