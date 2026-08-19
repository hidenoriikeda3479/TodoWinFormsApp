namespace TodoWinFormsApp.Models;

/// <summary>
/// 履歴処理区分
/// </summary>
public enum HistoryLogType
{
    /// <summary>作成</summary>
    Insert = 0,

    /// <summary>更新</summary>
    Update = 1,

    /// <summary>削除</summary>
    Delete = 2,
}
