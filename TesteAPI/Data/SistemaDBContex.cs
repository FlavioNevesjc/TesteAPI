using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteAPI.Data.Map;
using TesteAPI.Models;

namespace TesteAPI.Data
{
    public class SistemaDBContex : DbContext
    {
        public SistemaDBContex(DbContextOptions<SistemaDBContex> options) : base(options)
        {
        }
        
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
