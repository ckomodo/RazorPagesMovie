using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesMovie.Migrations
{
    public partial class AddedActorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Movie_MovieId",
                table: "Cast");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Cast",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Cast",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cast_ActorId",
                table: "Cast",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Actor_ActorId",
                table: "Cast",
                column: "ActorId",
                principalTable: "Actor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Movie_MovieId",
                table: "Cast",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Actor_ActorId",
                table: "Cast");

            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Movie_MovieId",
                table: "Cast");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Cast_ActorId",
                table: "Cast");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Cast");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Cast",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Movie_MovieId",
                table: "Cast",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "ID");
        }
    }
}
