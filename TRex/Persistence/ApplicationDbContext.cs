using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TRex.Models;

namespace TRex.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<RegularExpression> RegularExpressions { get; set; }
    }
}