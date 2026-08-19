namespace TodoWinFormsApp.Models;

/// <summary>
/// TODO担当者情報
/// </summary>
public sealed class TodoAssignee
{
    /// <summary>担当者ID</summary>
    public string AssigneeId { get; set; } = Guid.NewGuid().ToString();

    /// <summary>ユーザーコード</summary>
    public required string UserCode { get; set; }

    /// <summary>担当者名</summary>
    public required string AssigneeName { get; set; }

    /// <summary>メールアドレス</summary>
    public string? EmailAddress { get; set; }

    /// <summary>利用状態</summary>
    public bool IsActive { get; set; } = true;

    /// <summary>表示順</summary>
    public int DisplayOrder { get; set; } = 1;

    /// <summary>備考</summary>
    public string? Note { get; set; }

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

    /// <summary>担当するTODO一覧</summary>
    public ICollection<TodoTask> TodoTasks { get; set; } = new List<TodoTask>();
}
