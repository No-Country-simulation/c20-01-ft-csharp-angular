using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
	public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Users> Users { get; set; }
        //public DbSet<Adoptions> Adoptions { get; set; }
        public DbSet<Pets> Pets { get; set; }
        //public DbSet<Reviews> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			/*
			// Pets Table Configuration
			modelBuilder.Entity<Pets>()
                .HasKey(p => p.PetId);
            
			modelBuilder.Entity<Pets>()
                .Property(p => p.PetId)
                .IsRequired()
                .ValueGeneratedOnAdd();

			modelBuilder.Entity<Pets>()
				.Property(p => p.PetName)
				.IsRequired()
				.HasMaxLength(20);
			
			modelBuilder.Entity<Pets>()
				.Property(p => p.PetSpecies)
				.IsRequired()
				.HasMaxLength(50);

			// Users Table Configuration
			modelBuilder.Entity<Users>()
				.HasKey(u => u.UserId);
			
			modelBuilder.Entity<Users>()
				.Property(u => u.UserId)
				.IsRequired()
				.ValueGeneratedOnAdd();
			
			modelBuilder.Entity<Users>()
				.Property(u => u.UserName)
				.HasMaxLength(50)
				.IsRequired();
			
			modelBuilder.Entity<Users>()
				.Property(u => u.UserEmail)
				.HasMaxLength(50)
				.IsRequired();
			
			modelBuilder.Entity<Users>()
				.Property(u => u.UserPassword)
				.HasMaxLength(20)
				.IsRequired();

			// Reviews Table Configuration
			modelBuilder.Entity<Reviews>()
				.HasKey(r => r.ReviewId);
			
			modelBuilder.Entity<Reviews>()
				.Property(r => r.ReviewId)
				.IsRequired()
				.ValueGeneratedOnAdd();

			// Adoptions Table Configuration
			modelBuilder.Entity<Adoptions>()
				.HasKey(a => a.AdoptionId);
			
			modelBuilder.Entity<Adoptions>()
				.Property(a => a.AdoptionId)
				.IsRequired()
				.ValueGeneratedOnAdd();

			// User -> Adoptions (One-to-Many)
			modelBuilder.Entity<Users>()
				.HasMany(u => u.Adoptions)
				.WithOne(a => a.User)
				.HasForeignKey(a => a.UserId)
				.IsRequired();

			// User -> Reviews (One-to-Many)
			modelBuilder.Entity<Users>()
				.HasMany(u => u.Reviews)
				.WithOne(r => r.User)
				.HasForeignKey(r => r.UserId)
				.IsRequired();

			// Pet -> Reviews (One-to-Many)
			modelBuilder.Entity<Pets>()
				.HasMany(p => p.Reviews)
				.WithOne(r => r.Pet)
				.HasForeignKey(r => r.PetId)
				.IsRequired();

			// Adoption -> Pets (One-to-Many)
			modelBuilder.Entity<Adoptions>()
				.HasMany(a => a.Pets)
				.WithOne(p => p.Adoption)
				.HasForeignKey(p => p.AdoptionId)
				.IsRequired();
			*/
		}
	}
}
