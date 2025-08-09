using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMB_Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddKoiFishImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KoiFishImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KoiFishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KoiFishImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KoiFishImage_KoiFish_KoiFishId",
                        column: x => x.KoiFishId,
                        principalTable: "KoiFish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KoiFishImage_KoiFishId",
                table: "KoiFishImage",
                column: "KoiFishId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KoiFishImage");
        }
    }
}
