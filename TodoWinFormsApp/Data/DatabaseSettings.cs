namespace TodoWinFormsApp.Data;

/// <summary>
/// 開発用DB接続設定
/// 実際のサーバーを利用する場合は接続文字列を変更する
/// </summary>
public static class DatabaseSettings
{
    public const string ConnectionString =
        "Server=(localdb)\\MSSQLLocalDB;" +
        "Database=TodoManagementDb;" +
        "Trusted_Connection=True;" +
        "TrustServerCertificate=True;";
}
