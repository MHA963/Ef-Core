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
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menu_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservationlist",
                columns: table => new
                {
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Reservationlist_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Rating = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CPR = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Rating);
                    table.ForeignKey(
                        name: "FK_Ratings_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Customer_CPR",
                        column: x => x.CPR,
                        principalTable: "Customer",
                        principalColumn: "CPR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPR = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CanteenName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Canteen_CanteenName",
                        column: x => x.CanteenName,
                        principalTable: "Canteen",
                        principalColumn: "CanteenName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Customer_CPR",
                        column: x => x.CPR,
                        principalTable: "Customer",
                        principalColumn: "CPR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationMenu",
                columns: table => new
                {
                    ReservationMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    StreetFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarmDish = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationMenu", x => x.ReservationMenuId);
                    table.ForeignKey(
                        name: "FK_ReservationMenu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_CanteenName",
                table: "Menu",
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
                name: "IX_ReservationMenu_MenuId",
                table: "ReservationMenu",
                column: "MenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Canteen");
        }
    }
}
