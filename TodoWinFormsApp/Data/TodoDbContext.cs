using Microsoft.EntityFrameworkCore;
using TodoWinFormsApp.Models;

namespace TodoWinFormsApp.Data;

public sealed class TodoDbContext : DbContext
{
    public TodoDbContext()
    {
    }

    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options)
    {
    }

    public DbSet<TodoTask> TodoTasks => Set<TodoTask>();
    public DbSet<TodoAssignee> TodoAssignees => Set<TodoAssignee>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(DatabaseSettings.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoDbContext).Assembly);
    }
}