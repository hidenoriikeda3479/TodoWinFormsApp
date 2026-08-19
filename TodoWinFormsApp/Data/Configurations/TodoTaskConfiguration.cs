using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoWinFormsApp.Models;

namespace TodoWinFormsApp.Data.Configurations;

/// <summary>
/// TodoTaskのテーブル設定
/// </summary>
public sealed class TodoTaskConfiguration : IEntityTypeConfiguration<TodoTask>
{
    public void Configure(EntityTypeBuilder<TodoTask> builder)
    {
        builder.ToTable("TodoTask", "dbo", table =>
        {
            table.HasComment("TODO情報");
            table.HasCheckConstraint("CK_TodoTask_Status", "[Status] BETWEEN 0 AND 2");
            table.HasCheckConstraint("CK_TodoTask_Priority", "[Priority] BETWEEN 0 AND 2");
            table.HasCheckConstraint("CK_TodoTask_LogType", "[LogType] BETWEEN 0 AND 2");
        });

        builder.HasKey(x => x.TodoId)
            .HasName("TodoTask_PKC");

        builder.Property(x => x.TodoId)
            .HasMaxLength(36)
            .IsUnicode(false)
            .ValueGeneratedNever()
            .HasComment("TODO ID");

        builder.Property(x => x.Title)
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("TODOタイトル");

        builder.Property(x => x.Description)
            .HasMaxLength(1000)
            .HasComment("詳細");

        builder.Property(x => x.Status)
            .HasConversion<int>()
            .HasDefaultValue(TodoStatus.NotStarted)
            .HasComment("状態");

        builder.Property(x => x.Priority)
            .HasConversion<int>()
            .HasDefaultValue(TodoPriority.Medium)
            .HasComment("優先度");

        builder.Property(x => x.AssigneeId)
            .HasMaxLength(36)
            .IsUnicode(false)
            .HasComment("担当者ID");

        builder.Property(x => x.DueDate)
            .HasColumnType("date")
            .HasComment("期限");

        builder.Property(x => x.CreatedAt)
            .HasColumnType("datetime")
            .HasComment("作成日時");

        builder.Property(x => x.UpdatedAt)
            .HasColumnType("datetime")
            .IsConcurrencyToken()
            .HasComment("更新日時");

        builder.Property(x => x.LoggedUserCode)
            .HasMaxLength(36)
            .IsUnicode(false)
            .IsRequired()
            .HasComment("更新担当者");

        builder.Property(x => x.LoggedFunctionId)
            .HasMaxLength(64)
            .IsUnicode(false)
            .IsRequired()
            .HasComment("更新機能ID");

        builder.Property(x => x.LogType)
            .HasConversion<int>()
            .HasDefaultValue(HistoryLogType.Insert)
            .HasComment("履歴処理区分");

        builder.HasOne(x => x.Assignee)
            .WithMany(x => x.TodoTasks)
            .HasForeignKey(x => x.AssigneeId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_TodoTask_TodoAssignee");

        builder.HasIndex(x => new { x.Status, x.Priority, x.DueDate, x.UpdatedAt })
            .IsDescending(false, true, false, true)
            .HasDatabaseName("IdxTodoTask01");

        builder.HasIndex(x => new { x.AssigneeId, x.Status, x.UpdatedAt })
            .IsDescending(false, false, true)
            .HasDatabaseName("IdxTodoTask02");
    }
}
