using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoWinFormsApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnusedColimnsFormTodoAssignee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IdxTodoAssignee01",
                schema: "dbo",
                table: "TodoAssignee");

            migrationBuilder.DropIndex(
                name: "IdxTodoAssignee02",
                schema: "dbo",
                table: "TodoAssignee");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "dbo",
                table: "TodoAssignee");

            migrationBuilder.DropColumn(
                name: "UserCode",
                schema: "dbo",
                table: "TodoAssignee");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "dbo",
                table: "TodoAssignee",
                type: "bit",
                nullable: false,
                defaultValue: true,
                comment: "利用状態");

            migrationBuilder.AddColumn<string>(
                name: "UserCode",
                schema: "dbo",
                table: "TodoAssignee",
                type: "varchar(36)",
                unicode: false,
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                comment: "ユーザーコード");

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
        }
    }
}
