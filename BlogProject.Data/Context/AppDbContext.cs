using BlogProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace BlogProject.Data.Context;

public class AppDbContext : DbContext
{
  


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        // ...
    }

    public DbSet<Article> Articles { get; set; }

    public DbSet<Image> Images { get; set; }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);

    }



}

