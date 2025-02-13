using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SakchyamAcharya1_Dot_Net_Assignment.Models;

namespace SakchyamAcharya1_Dot_Net_Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SakchyamAcharya1_Dot_Net_Assignment.Models.User> User { get; set; } = default!;
        public DbSet<SakchyamAcharya1_Dot_Net_Assignment.Models.Resturant> Resturant { get; set; } = default!;
        public DbSet<SakchyamAcharya1_Dot_Net_Assignment.Models.Delivery> Delivery { get; set; } = default!;
        public DbSet<SakchyamAcharya1_Dot_Net_Assignment.Models.OrderPlease> OrderPlease { get; set; } = default!;
    }
}
