using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTS_ApartBillingCheckList.Migrations
{
    /// <inheritdoc />
    public partial class CountryID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Registrations");
        }
    }
}
