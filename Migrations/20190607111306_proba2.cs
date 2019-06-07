using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class proba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnFabricatie",
                table: "Cars",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AnFabricatie",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4);
        }
    }
}
