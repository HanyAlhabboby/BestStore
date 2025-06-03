using BestStoreMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {
            
        }

        public DbSet<Product> Products  { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
