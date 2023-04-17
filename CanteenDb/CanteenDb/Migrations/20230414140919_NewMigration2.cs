using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanteenDb.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Customer_CPR",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Customer_CPR",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "CPR",
                table: "Reservation",
                newName: "AUID");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_CPR",
                table: "Reservation",
                newName: "IX_Reservation_AUID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Customer_AUID",
                table: "Reservation",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Customer_AUID",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "AUID",
                table: "Reservation",
                newName: "CPR");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_AUID",
                table: "Reservation",
                newName: "IX_Reservation_CPR");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Customer_CPR",
                table: "Reservation",
                column: "CPR",
                principalTable: "Customer",
                principalColumn: "CPR");
        }
    }
}
