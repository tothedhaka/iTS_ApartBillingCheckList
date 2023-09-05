
using iTS_ApartBillingCheckList.Areas.Signup.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace iTS_ApartBillingCheckList.Areas.Signup.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbSet<Registration> Registrations { get; set; }

    }
}
