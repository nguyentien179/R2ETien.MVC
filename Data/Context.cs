using System;
using Microsoft.EntityFrameworkCore;
using R2ETien.MVC.Models;

namespace R2ETien.MVC.Data;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Person> Person { get; set; }
}
