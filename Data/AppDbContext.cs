using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MovieLover.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class AppDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public string DbPath { get; }

    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "AppDb.db"); // my path C:\Users\Fifi\AppData\Local
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}