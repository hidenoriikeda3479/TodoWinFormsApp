namespace TodoWinFormsApp.Models;

/// <summary>
/// TODOの状態
/// </summary>
public enum TodoStatus
{
    /// <summary>未着手</summary>
    NotStarted = 0,

    /// <summary>対応中</summary>
    InProgress = 1,

    /// <summary>完了</summary>
    Completed = 2,
}
