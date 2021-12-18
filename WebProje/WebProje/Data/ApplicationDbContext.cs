using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebProje.Models;

namespace WebProje.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Content> Content { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Kategori> Kategori { get; set; }

        public DbSet<Authority> Authority { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
