namespace TodoWinFormsApp.Models;

/// <summary>
/// TODO情報
/// </summary>
public sealed class TodoTask
{
    /// <summary>TODO ID</summary>
    public string TodoId { get; set; } = Guid.NewGuid().ToString();

    /// <summary>TODOタイトル</summary>
    public required string Title { get; set; }

    /// <summary>詳細</summary>
    public string? Description { get; set; }

    /// <summary>状態</summary>
    public TodoStatus Status { get; set; } = TodoStatus.NotStarted;

    /// <summary>優先度</summary>
    public TodoPriority Priority { get; set; } = TodoPriority.Medium;

    /// <summary>担当者ID</summary>
    public string? AssigneeId { get; set; }

    /// <summary>期限</summary>
    public DateOnly? DueDate { get; set; }

    /// <summary>作成日時</summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>更新日時</summary>
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    /// <summary>更新担当者</summary>
    public required string LoggedUserCode { get; set; }

    /// <summary>更新機能ID</summary>
    public required string LoggedFunctionId { get; set; }

    /// <summary>履歴処理区分</summary>
    public HistoryLogType LogType { get; set; } = HistoryLogType.Insert;

    /// <summary>担当者情報</summary>
    public TodoAssignee? Assignee { get; set; }
}
