using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebProje.Models;

namespace WebProje.Data
{
    public class WebProjeContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<User> User { get; set; }

        public DbSet<Content> Content { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Kategori> Kategori { get; set; }
        public object ApplicationUser { get; internal set; }

        public WebProjeContext(DbContextOptions<WebProjeContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
