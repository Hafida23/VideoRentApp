using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoRentApp.Migrations
{
    public partial class movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DateRelease", "Description", "Genre", "ImageUrl", "ImdbUrl", "Length", "MainActress", "Title" },
                values: new object[,]
                {
                    { 13, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", "Romance", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 125, "Kate Winslet", "Titanic" },
                    { 14, new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", "Action", "InBasterds.jpg", "https://www.imdb.com/title/tt0361748/", 105, "Diane Kruger", "Inglorious Basterds" },
                    { 15, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", "Sci-Fi", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "Zoe Saldana", "Star Trek - Into Darkness" },
                    { 16, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", "Action-Drama", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "Kelly McGills", "Top Gun" },
                    { 17, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", "Romance", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 125, "Kate Winslet", "Titanic" },
                    { 18, new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", "Action", "InBasterds.jpg", "https://www.imdb.com/title/tt0361748/", 105, "Diane Kruger", "Inglorious Basterds" },
                    { 19, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", "Sci-Fi", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "Zoe Saldana", "Star Trek - Into Darkness" },
                    { 20, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", "Action-Drama", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "Kelly McGills", "Top Gun" },
                    { 21, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", "Romance", "Titanic.jpg", "https://www.imdb.com/title/tt0120338/", 125, "Kate Winslet", "Titanic" },
                    { 22, new DateTime(2009, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", "Action", "InBasterds.jpg", "https://www.imdb.com/title/tt0361748/", 105, "Diane Kruger", "Inglorious Basterds" },
                    { 23, new DateTime(2013, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", "Sci-Fi", "StarTrek.jpg", "https://www.imdb.com/title/tt1408101/", 135, "Zoe Saldana", "Star Trek - Into Darkness" },
                    { 24, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", "Action-Drama", "topgun.jpg", "https://www.imdb.com/title/tt0092099/", 110, "Kelly McGills", "Top Gun" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 24);
        }
    }
}
