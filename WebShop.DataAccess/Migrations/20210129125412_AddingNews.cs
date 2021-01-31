using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.DataAccess.Migrations
{
    public partial class AddingNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<Guid>(type: "char(36)", nullable: false),
                    Header = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Article = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
