using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebUygulamaIdentity.Models;

namespace WebUygulamaIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

     

        }

        public DbSet<Work> Works { get; set; }
        public DbSet<InteriorWork> InteriorWorks { get; set; }
        public DbSet<OutsideWork> OutsideWorks { get; set; }
        public DbSet<FurnitureWork> FurnitureWorks { get; set; }
        public DbSet<Company> Companies { get; set; }

    }
}
