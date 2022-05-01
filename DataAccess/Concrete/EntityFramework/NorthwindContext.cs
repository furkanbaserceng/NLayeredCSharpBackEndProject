using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Veritabanı tabloları ile classlarımızı birbirine bağlar

    public class NorthwindContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");


            //contexte hangi veritabanına bağlanacağımızı söylüyoruz.
        }

        public DbSet<Product> Products { get; set; }  //product classımız Products tablosuna karşılık geliyor.

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Customer> Orders { get; set; }



    }
}
