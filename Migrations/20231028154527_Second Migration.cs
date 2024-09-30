using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WearHouse.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "CategoryNameEdit");

            migrationBuilder.AddColumn<string>(
                name: "CategoryNameAdd",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryNameAdd",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryNameEdit",
                table: "Categories",
                newName: "CategoryName");
        }
    }
}
