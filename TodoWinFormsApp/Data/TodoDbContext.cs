using Microsoft.EntityFrameworkCore;
using TodoWinFormsApp.Models;

namespace TodoWinFormsApp.Data;

/// <summary>
/// TODO管理用のDbContext
/// </summary>
public sealed class TodoDbContext : DbContext
{

    /// <summary>
    /// 既定の接続設定を使うDBコンテキストを作成する
    /// </summary>
    public TodoDbContext()
    {
    }

    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options)
    {
    }

    /// <summary>TODO情報</summary>
    public DbSet<TodoTask> TodoTasks => Set<TodoTask>();

    /// <summary>TODO担当者情報</summary>
    public DbSet<TodoAssignee> TodoAssignees => Set<TodoAssignee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoDbContext).Assembly);
    }
}
