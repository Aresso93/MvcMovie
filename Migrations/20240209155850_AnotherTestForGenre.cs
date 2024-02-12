using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    public partial class AnotherTestForGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Genre_MovieGenreId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "MovieGenreId",
                table: "Movie",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_MovieGenreId",
                table: "Movie",
                newName: "IX_Movie_GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Genre_GenreId",
                table: "Movie",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Genre_GenreId",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Movie",
                newName: "MovieGenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                newName: "IX_Movie_MovieGenreId");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movie",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Genre_MovieGenreId",
                table: "Movie",
                column: "MovieGenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
