using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanteenDb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JITMeals",
                table: "JITMeals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CanceledMeals",
                table: "CanceledMeals");

            migrationBuilder.AlterColumn<string>(
                name: "JITName",
                table: "JITMeals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CanceledMealsName",
                table: "CanceledMeals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JITName",
                table: "JITMeals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CanceledMealsName",
                table: "CanceledMeals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JITMeals",
                table: "JITMeals",
                column: "JITName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CanceledMeals",
                table: "CanceledMeals",
                column: "CanceledMealsName");
        }
    }
}
