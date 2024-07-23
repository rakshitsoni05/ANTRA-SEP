using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieShopApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTrailers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrailerResponseModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(2084)", nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(2084)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrailerResponseModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrailerResponseModel_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrailerResponseModel_MovieId",
                table: "TrailerResponseModel",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrailerResponseModel");
        }
    }
}
