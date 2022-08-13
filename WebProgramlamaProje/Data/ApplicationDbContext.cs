using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProje.Models;

namespace WebProgramlamaProje.Data
{
    public class ApplicationDbContext: IdentityDbContext // veritabanı adı ne olmalı?
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) //connectionstring bilgisini dışarıdan alıyoruz.
          : base(options)
        {
            //options.UseSqlite("DataSource=webProgramlama.db");
        }

        // buraya tabloları eklıyoruz.
        public DbSet<Work> Works { get; set; }
        public DbSet<InteriorWork> InteriorWorks { get; set; }
        public DbSet<OutdoorWork> OutdoorWorks { get; set; }
        public DbSet<FurnitureWork> FurnitureWorks { get; set; }

    }
}
