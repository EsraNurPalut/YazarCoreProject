using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-1M6OMN39;Database=ProjectKutuphane1; integrated security=true;");
        }

        public DbSet<Kitaplar> Kitaplars { get; set; }

        public DbSet<Yazarlar> Yazarlars { get; set; }

        public DbSet<Yayinevleri> Yayinevleris { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Belge> Belges { get; set; }

        public DbSet<KitapSayar> KitapSayars { get; set; }

    }
}
