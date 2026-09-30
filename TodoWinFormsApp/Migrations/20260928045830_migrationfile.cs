using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoWinFormsApp.Migrations
{
    /// <inheritdoc />
    public partial class migrationfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "TodoAssignee",
                schema: "dbo",
                columns: table => new
                {
                    AssigneeId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, comment: "担当者ID"),
                    UserCode = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, comment: "ユーザーコード"),
                    AssigneeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "担当者名"),
                    EmailAddress = table.Column<string>(type: "varchar(254)", unicode: false, maxLength: 254, nullable: true, comment: "メールアドレス"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true, comment: "利用状態"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 1, comment: "表示順"),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "備考"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, comment: "作成日時"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新日時"),
                    LoggedUserCode = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, comment: "更新担当者"),
                    LoggedFunctionId = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false, comment: "更新機能ID"),
                    LogType = table.Column<int>(type: "int", nullable: false, defaultValue: 0, comment: "履歴処理区分")
                },
                constraints: table =>
                {
                    table.PrimaryKey("TodoAssignee_PKC", x => x.AssigneeId);
                    table.CheckConstraint("CK_TodoAssignee_DisplayOrder", "[DisplayOrder] BETWEEN 1 AND 9999");
                    table.CheckConstraint("CK_TodoAssignee_LogType", "[LogType] BETWEEN 0 AND 2");
                },
                comment: "TODO担当者情報");

            migrationBuilder.CreateTable(
                name: "TodoTask",
                schema: "dbo",
                columns: table => new
                {
                    TodoId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, comment: "TODO ID"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "TODOタイトル"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, comment: "詳細"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0, comment: "状態"),
                    Priority = table.Column<int>(type: "int", nullable: true, defaultValue: 1, comment: "優先度"),
                    AssigneeId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true, comment: "担当者ID"),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: true, comment: "期限"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, comment: "作成日時"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false, comment: "更新日時"),
                    LoggedUserCode = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false, comment: "更新担当者"),
                    LoggedFunctionId = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false, comment: "更新機能ID"),
                    LogType = table.Column<int>(type: "int", nullable: false, defaultValue: 0, comment: "履歴処理区分")
                },
                constraints: table =>
                {
                    table.PrimaryKey("TodoTask_PKC", x => x.TodoId);
                    table.CheckConstraint("CK_TodoTask_LogType", "[LogType] BETWEEN 0 AND 2");
                    table.CheckConstraint("CK_TodoTask_Priority", "[Priority] BETWEEN 0 AND 2");
                    table.CheckConstraint("CK_TodoTask_Status", "[Status] BETWEEN 0 AND 2");
                    table.ForeignKey(
                        name: "FK_TodoTask_TodoAssignee",
                        column: x => x.AssigneeId,
                        principalSchema: "dbo",
                        principalTable: "TodoAssignee",
                        principalColumn: "AssigneeId");
                },
                comment: "TODO情報");

            migrationBuilder.CreateIndex(
                name: "IdxTodoAssignee01",
                schema: "dbo",
                table: "TodoAssignee",
                column: "UserCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IdxTodoAssignee02",
                schema: "dbo",
                table: "TodoAssignee",
                columns: new[] { "IsActive", "DisplayOrder", "AssigneeName" },
                descending: new[] { true, false, false });

            migrationBuilder.CreateIndex(
                name: "IdxTodoTask01",
                schema: "dbo",
                table: "TodoTask",
                columns: new[] { "Status", "Priority", "DueDate", "UpdatedAt" },
                descending: new[] { false, true, false, true });

            migrationBuilder.CreateIndex(
                name: "IdxTodoTask02",
                schema: "dbo",
                table: "TodoTask",
                columns: new[] { "AssigneeId", "Status", "UpdatedAt" },
                descending: new[] { false, false, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoTask",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TodoAssignee",
                schema: "dbo");
        }
    }
}
