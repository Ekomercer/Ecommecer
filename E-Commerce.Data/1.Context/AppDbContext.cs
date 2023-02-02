using E_Commerce.Domain._1.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data._1.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>opt): base(opt) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Itens> Itens { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Requests> Requests { get; set; }
    }
}