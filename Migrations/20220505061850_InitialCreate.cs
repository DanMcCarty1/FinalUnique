using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalUnique.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    CardID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardName = table.Column<string>(maxLength: 60, nullable: false),
                    CardColor = table.Column<string>(maxLength: 60, nullable: false),
                    CardPrice = table.Column<decimal>(maxLength: 60, nullable: false),
                    Rarity = table.Column<string>(maxLength: 5, nullable: false),
                    ExspansionName = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.CardID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
