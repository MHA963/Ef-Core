using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanteenDb.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JITMeals");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JITMeals",
                columns: table => new
                {
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    JITName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_JITMeals_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JITMeals_CanteenName",
                table: "JITMeals",
                column: "CanteenName");
        }
    }
}
