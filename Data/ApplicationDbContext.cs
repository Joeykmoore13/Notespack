using Microsoft.EntityFrameworkCore;
using System;
using NOTESPACK.Models;
using Notespack.Models;

namespace NOTESPACK.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Session> Sessions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuración de la entidad User
        modelBuilder.Entity<User>(entity =>
        {
            // Aseguramos que EF Core reconozca la propiedad si existe en el modelo
            entity.Property(u => u.EmailConfirmed).HasDefaultValue(false);
        });

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                username = "campus_admin",
                Email = "admin@byui.edu",
                Password = "SecurePassword123",
                EnrollmentDate = DateTime.Today,
                EmailConfirmed = true
            },
            new User { 
                Id = 2,
                username = "Juan_Q",
                Email = "JQVallenilla@gmail.com",
                Password = "Main123-Password", // Corregido: sin caracteres de escape conflictivos
                EnrollmentDate = DateTime.Today,
                EmailConfirmed = false
            },
            new User { 
                Id = 3,
                username = "Carolina2023",
                Email = "Carolina@gmail.com", // Corregido: email único
                Password = "Main123-Password",
                EnrollmentDate = DateTime.Today,
                EmailConfirmed = false
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Travel"},
            new Category { Id = 2, Name = "Meeting"},
            new Category { Id = 3, Name = "Lunch"},
            new Category { Id = 4, Name = "Break"},
            new Category { Id = 5, Name = "Course"}
        );
    }
}
