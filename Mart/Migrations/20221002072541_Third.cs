using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mart.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Colors_ColorId",
                table: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Colors_ColorId",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Colors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Colors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ColorId",
                table: "Colors",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Colors_ColorId",
                table: "Colors",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id");
        }
    }
}
