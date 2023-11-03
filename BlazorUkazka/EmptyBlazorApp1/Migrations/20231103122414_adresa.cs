using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmptyBlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class adresa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BydlisteId",
                table: "Lide",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ulice = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lide_BydlisteId",
                table: "Lide",
                column: "BydlisteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lide_Adresa_BydlisteId",
                table: "Lide",
                column: "BydlisteId",
                principalTable: "Adresa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lide_Adresa_BydlisteId",
                table: "Lide");

            migrationBuilder.DropTable(
                name: "Adresa");

            migrationBuilder.DropIndex(
                name: "IX_Lide_BydlisteId",
                table: "Lide");

            migrationBuilder.DropColumn(
                name: "BydlisteId",
                table: "Lide");
        }
    }
}
