using MvcMovie.Models;
using System.Data.Entity;

namespace MvcMovie.DAL
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
