using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRentApp.Migrations
{
    public partial class inti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    DateRelease = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    MainActress = table.Column<string>(maxLength: 50, nullable: true),
                    ImdbUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfPayment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Renters",
                columns: table => new
                {
                    RenterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    IdPaymentType = table.Column<int>(nullable: false),
                    PaymentTypesPaymentTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renters", x => x.RenterId);
                    table.ForeignKey(
                        name: "FK_Renters_PaymentTypes_PaymentTypesPaymentTypeId",
                        column: x => x.PaymentTypesPaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "PaymentTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentMovies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    RenterId = table.Column<int>(nullable: false),
                    RentMovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentMovies", x => new { x.MovieId, x.RenterId });
                    table.ForeignKey(
                        name: "FK_RentMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentMovies_Renters_RenterId",
                        column: x => x.RenterId,
                        principalTable: "Renters",
                        principalColumn: "RenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", "Romance", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 125, "Kate Winslet", "Titanic" },
                    { 12, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", "Action-Drama", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "Kelly McGills", "Top Gun" },
                    { 11, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", "Sci-Fi", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "Zoe Saldana", "Star Trek - Into Darkness" },
                    { 10, new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", "Action", "InBasterds.jpg", "https://www.imdb.com/title/tt0361748/", 105, "Diane Kruger", "Inglorious Basterds" },
                    { 8, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", "Action-Drama", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "Kelly McGills", "Top Gun" },
                    { 7, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", "Sci-Fi", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "Zoe Saldana", "Star Trek - Into Darkness" },
                    { 9, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", "Romance", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 125, "Kate Winslet", "Titanic" },
                    { 5, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", "Romance", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 125, "Kate Winslet", "Titanic" },
                    { 4, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", "Action-Drama", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "Kelly McGills", "Top Gun" },
                    { 3, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", "Sci-Fi", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "Zoe Saldana", "Star Trek - Into Darkness" },
                    { 2, new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", "Action", "InBasterds.jpg", "https://www.imdb.com/title/tt0361748/", 105, "Diane Kruger", "Inglorious Basterds" },
                    { 6, new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", "Action", "InBasterds.jpg", "https://www.imdb.com/title/tt0361748/", 105, "Diane Kruger", "Inglorious Basterds" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "PaymentTypeId", "TypeOfPayment" },
                values: new object[,]
                {
                    { 1, "VisaCard" },
                    { 2, "PayPAl" },
                    { 3, "Boncontact" }
                });

            migrationBuilder.InsertData(
                table: "Renters",
                columns: new[] { "RenterId", "FirstName", "IdPaymentType", "LastName", "PaymentTypesPaymentTypeId" },
                values: new object[,]
                {
                    { 2, "Anass", 2, "Allamzi", null },
                    { 1, "Fatih", 1, "Ozer", null },
                    { 3, "Olga", 3, "Kharchuk", null }
                });

            migrationBuilder.InsertData(
                table: "RentMovies",
                columns: new[] { "MovieId", "RenterId", "RentMovieId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 4 },
                    { 1, 2, 2 },
                    { 2, 2, 3 },
                    { 3, 3, 6 },
                    { 5, 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Renters_PaymentTypesPaymentTypeId",
                table: "Renters",
                column: "PaymentTypesPaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RentMovies_RenterId",
                table: "RentMovies",
                column: "RenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentMovies");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Renters");

            migrationBuilder.DropTable(
                name: "PaymentTypes");
        }
    }
}
