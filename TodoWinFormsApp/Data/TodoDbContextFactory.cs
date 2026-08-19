using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TodoWinFormsApp.Data;

/// <summary>
/// マイグレーション実行時にDbContextを生成する
/// </summary>
public sealed class TodoDbContextFactory : IDesignTimeDbContextFactory<TodoDbContext>
{
    public TodoDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<TodoDbContext>()
            .UseSqlServer(DatabaseSettings.ConnectionString)
            .Options;

        return new TodoDbContext(options);
    }
}
