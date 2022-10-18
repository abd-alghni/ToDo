using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo.DbModel.Migrations
{
    public partial class inti_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    IsAdmin = table.Column<byte>(type: "tinyint", nullable: false),
                    IsArchived = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<byte[]>(type: "timestamp", rowVersion: true, nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedDate = table.Column<byte[]>(type: "timestamp", rowVersion: true, nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "todo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    AssignedId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<byte[]>(type: "timestamp", rowVersion: true, nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedDate = table.Column<byte[]>(type: "timestamp", rowVersion: true, nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    IsRead = table.Column<byte>(type: "tinyint", nullable: false),
                    IsArchived = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_todo", x => x.Id);
                    table.ForeignKey(
                        name: "fk_user_assigned",
                        column: x => x.AssignedId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "fk_user_assigned_idx",
                table: "todo",
                column: "AssignedId");

            migrationBuilder.CreateIndex(
                name: "fk_user_todo_idx",
                table: "todo",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE",
                table: "todo",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Email_UNIQUE",
                table: "user",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Id_UNIQUE1",
                table: "user",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "todo");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
