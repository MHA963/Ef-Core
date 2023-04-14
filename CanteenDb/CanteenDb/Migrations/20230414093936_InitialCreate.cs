using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CanteenDb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Canteen",
                columns: table => new
                {
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AvgRating = table.Column<float>(type: "real", nullable: false),
                    postCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canteen", x => x.CanteenName);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CPR = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CPR);
                });

            migrationBuilder.CreateTable(
                name: "CanceledMeals",
                columns: table => new
                {
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CanceledMealsName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_CanceledMeals_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName");
                });

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

            migrationBuilder.CreateTable(
                name: "Reservationlist",
                columns: table => new
                {
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Reservationlist_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName");
                });

            migrationBuilder.CreateTable(
                name: "ReservationMenu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warmdish_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationMenu", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_ReservationMenu_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName");
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CPR = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName");
                    table.ForeignKey(
                        name: "FK_Ratings_Customer_CPR",
                        column: x => x.CPR,
                        principalTable: "Customer",
                        principalColumn: "CPR");
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPR = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName");
                    table.ForeignKey(
                        name: "FK_Reservation_Customer_CPR",
                        column: x => x.CPR,
                        principalTable: "Customer",
                        principalColumn: "CPR");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanceledMeals_CanteenName",
                table: "CanceledMeals",
                column: "CanteenName");

            migrationBuilder.CreateIndex(
                name: "IX_JITMeals_CanteenName",
                table: "JITMeals",
                column: "CanteenName");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CanteenName",
                table: "Ratings",
                column: "CanteenName");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CPR",
                table: "Ratings",
                column: "CPR");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CanteenName",
                table: "Reservation",
                column: "CanteenName");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CPR",
                table: "Reservation",
                column: "CPR");

            migrationBuilder.CreateIndex(
                name: "IX_Reservationlist_CanteenName",
                table: "Reservationlist",
                column: "CanteenName");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationMenu_CanteenName",
                table: "ReservationMenu",
                column: "CanteenName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CanceledMeals");

            migrationBuilder.DropTable(
                name: "JITMeals");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Reservationlist");

            migrationBuilder.DropTable(
                name: "ReservationMenu");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Canteen");
        }
    }
}
