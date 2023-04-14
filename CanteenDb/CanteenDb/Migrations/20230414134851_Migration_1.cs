using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanteenDb.Migrations
{
    /// <inheritdoc />
    public partial class Migration_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Customer_CPR",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "CPR",
                table: "Ratings",
                newName: "AUID");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_CPR",
                table: "Ratings",
                newName: "IX_Ratings_AUID");

            migrationBuilder.RenameColumn(
                name: "CPR",
                table: "Customer",
                newName: "AUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Customer_AUID",
                table: "Ratings",
                column: "AUID",
                principalTable: "Customer",
                principalColumn: "AUID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Customer_AUID",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "AUID",
                table: "Ratings",
                newName: "CPR");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_AUID",
                table: "Ratings",
                newName: "IX_Ratings_CPR");

            migrationBuilder.RenameColumn(
                name: "AUID",
                table: "Customer",
                newName: "CPR");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Customer_CPR",
                table: "Ratings",
                column: "CPR",
                principalTable: "Customer",
                principalColumn: "CPR");
        }
    }
}
