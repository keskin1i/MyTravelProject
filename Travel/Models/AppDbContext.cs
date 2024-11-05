using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class AppDbContext : DbContext
    {
       

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Adres> AdresBlogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<İletisim> iletisims { get; set; }


       
    }
}