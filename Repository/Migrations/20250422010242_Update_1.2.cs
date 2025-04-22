using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Products_ProductId",
                table: "Checkouts");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_ProductId",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Checkouts");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Checkouts",
                newName: "ProductListId");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CheckoutId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CheckoutId",
                table: "Products",
                column: "CheckoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Checkouts_CheckoutId",
                table: "Products",
                column: "CheckoutId",
                principalTable: "Checkouts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Checkouts_CheckoutId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CheckoutId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CheckoutId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductListId",
                table: "Checkouts",
                newName: "ProductId");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Checkouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_ProductId",
                table: "Checkouts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Products_ProductId",
                table: "Checkouts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
