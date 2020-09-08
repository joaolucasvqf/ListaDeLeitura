using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ListaDeLeitura.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "livrosFavoritos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Etag = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Authors = table.Column<string[]>(nullable: true),
                    Thumbnail = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Categories = table.Column<string[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livrosFavoritos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livrosFavoritos");
        }
    }
}
