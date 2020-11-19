using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppCinemaBooking.Migrations
{
    public partial class Add_Movie_Show : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie_Shows",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start_Show = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Room_ID = table.Column<int>(type: "int", nullable: false),
                    Movie_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Shows", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Movie_Shows_Movies_Movie_ID",
                        column: x => x.Movie_ID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Shows_Rooms_Room_ID",
                        column: x => x.Room_ID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Shows_Movie_ID",
                table: "Movie_Shows",
                column: "Movie_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Shows_Room_ID",
                table: "Movie_Shows",
                column: "Room_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie_Shows");
        }
    }
}
