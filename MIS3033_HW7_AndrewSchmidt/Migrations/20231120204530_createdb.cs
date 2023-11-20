using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS3033_HW7_AndrewSchmidt.Migrations
{
    /// <inheritdoc />
    public partial class createdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    nCogs = table.Column<int>(type: "integer", nullable: false),
                    nGears = table.Column<int>(type: "integer", nullable: false),
                    subtotal = table.Column<double>(type: "double precision", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
