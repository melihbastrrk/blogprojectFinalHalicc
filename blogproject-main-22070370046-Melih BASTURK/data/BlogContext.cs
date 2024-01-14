using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using data.tables;

namespace data {
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
            DbPath = System.IO.Path.Join("/Users/gokhanmerden/Public/Halic/blog", "blogdb.db");
        }
        public string DbPath { get; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Krediler> Krediler {get;set;} 
        public DbSet<Okul> okul_listesi {get;set;} // okul varlık türünü temsil eder.
        public DbSet<Ogrenci> ogrenciler {get;set;} // ogrenci varlık türünü temsil eder.
        public DbSet<sehirler>sehirler {get;set;} // sehirler varlık türünü temsil eder.
        public DbSet<sozluk> sozluk{get;set;} // sözlük varlık türünü temsil eder.
        public DbSet<Haberler> haberler {get;set;} //haberler varlık türünü temsil eder.
        public DbSet<Hava>hava_durumu {get;set;} // hava varlık türünü temsil eder
        public DbSet<Trafik> trafik_kaza{get;set;} //Trafik varlık türünü temsil eder.


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}