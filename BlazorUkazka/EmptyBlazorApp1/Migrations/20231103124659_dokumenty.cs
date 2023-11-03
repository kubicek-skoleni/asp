using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmptyBlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class dokumenty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dokument",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cislo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClovekId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dokument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dokument_Lide_ClovekId",
                        column: x => x.ClovekId,
                        principalTable: "Lide",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dokument_ClovekId",
                table: "Dokument",
                column: "ClovekId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dokument");
        }
    }
}
