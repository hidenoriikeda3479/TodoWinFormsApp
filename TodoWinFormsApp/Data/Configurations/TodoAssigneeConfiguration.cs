using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoWinFormsApp.Models;

namespace TodoWinFormsApp.Data.Configurations;

/// <summary>
/// TodoAssigneeのテーブル設定
/// </summary>
public sealed class TodoAssigneeConfiguration : IEntityTypeConfiguration<TodoAssignee>
{
    public void Configure(EntityTypeBuilder<TodoAssignee> builder)
    {
        builder.ToTable("TodoAssignee", "dbo", table =>
        {
            table.HasComment("TODO担当者情報");
            table.HasCheckConstraint(
                "CK_TodoAssignee_DisplayOrder",
                "[DisplayOrder] BETWEEN 1 AND 9999");
            table.HasCheckConstraint(
                "CK_TodoAssignee_LogType",
                "[LogType] BETWEEN 0 AND 2");
        });

        builder.HasKey(x => x.AssigneeId)
            .HasName("TodoAssignee_PKC");

        builder.Property(x => x.AssigneeId)
            .HasMaxLength(36)
            .IsUnicode(false)
            .ValueGeneratedNever()
            .HasComment("担当者ID");


        builder.Property(x => x.AssigneeName)
            .HasMaxLength(100)
            .IsRequired()
            .HasComment("担当者名");

        builder.Property(x => x.EmailAddress)
            .HasMaxLength(254)
            .IsUnicode(false)
            .HasComment("メールアドレス");


        builder.Property(x => x.DisplayOrder)
            .HasDefaultValue(1)
            .HasComment("表示順");

        builder.Property(x => x.Note)
            .HasMaxLength(500)
            .HasComment("備考");

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

    }
}
