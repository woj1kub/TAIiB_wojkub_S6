using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Added_Product_OrderPostition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProduktID",
                table: "OrderPosition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderPosition_ProduktID",
                table: "OrderPosition",
                column: "ProduktID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPosition_Produkt_ProduktID",
                table: "OrderPosition",
                column: "ProduktID",
                principalTable: "Produkt",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPosition_Produkt_ProduktID",
                table: "OrderPosition");

            migrationBuilder.DropIndex(
                name: "IX_OrderPosition_ProduktID",
                table: "OrderPosition");

            migrationBuilder.DropColumn(
                name: "ProduktID",
                table: "OrderPosition");
        }
    }
}
