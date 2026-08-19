# TodoWinFormsApp

Windows Forms、Entity Framework Core、SQL Serverを使用するTODO管理アプリの土台です。

ZIPを展開した後、ルートにある`TodoWinFormsApp.sln`をVisual Studioで開いてください。

## 作成済み

- `TodoTask`モデル
- `TodoAssignee`モデル
- 状態、優先度、履歴処理区分のenum
- `TodoDbContext`
- 各テーブルの型、最大長、主キー、外部キー、インデックス、CHECK制約
- マイグレーション用の`TodoDbContextFactory`

## 主なファイル

```text
TodoWinFormsApp.sln
└─ TodoWinFormsApp
   ├─ Data
   │  ├─ Configurations
   │  │  ├─ TodoTaskConfiguration.cs
   │  │  └─ TodoAssigneeConfiguration.cs
   │  ├─ DatabaseSettings.cs
   │  ├─ TodoDbContext.cs
   │  └─ TodoDbContextFactory.cs
   ├─ Models
   │  ├─ TodoTask.cs
   │  ├─ TodoAssignee.cs
   │  ├─ TodoStatus.cs
   │  ├─ TodoPriority.cs
   │  └─ HistoryLogType.cs
   ├─ MainForm.cs
   ├─ Program.cs
   └─ TodoWinFormsApp.csproj
```

## 接続先

初期状態ではSQL Server LocalDBの次のDBへ接続します。

```text
Server=(localdb)\MSSQLLocalDB;Database=TodoManagementDb
```

接続先を変更する場合は`Data/DatabaseSettings.cs`を修正してください。

## 次の手順

次の作業ではマイグレーションを作成して、SQL Serverにテーブルを作成します。

```powershell
dotnet tool install --global dotnet-ef --version 8.0.28
dotnet ef migrations add InitialCreate
dotnet ef database update
```
