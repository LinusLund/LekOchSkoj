using Microsoft.EntityFrameworkCore;
using static EmptyBlazorApp1.Pages.Receipts;

namespace EmptyBlazorApp1.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Receipt> Receipts { get; set; }
    }
}
