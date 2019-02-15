using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public SwitchContext(DbContextOptions options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>{
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Nome)
                        .IsRequired()
                        .HasMaxLength(100);
                
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}