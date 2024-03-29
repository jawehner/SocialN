using Microsoft.EntityFrameworkCore;
using SocialN.API.Models;

namespace SocialN.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }
    }
}