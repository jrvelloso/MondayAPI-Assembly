using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductList");

            migrationBuilder.RenameColumn(
                name: "MethodName",
                table: "PaymentMethods",
                newName: "Type");

            migrationBuilder.AddColumn<int>(
                name: "CardNumber",
                table: "PaymentMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpirationMonth",
                table: "PaymentMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpirationYear",
                table: "PaymentMethods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Provider",
                table: "PaymentMethods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CheckoutsProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ChekcoutId = table.Column<int>(type: "int", nullable: false),
                    CheckoutId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutsProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckoutsProducts_Checkouts_CheckoutId",
                        column: x => x.CheckoutId,
                        principalTable: "Checkouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckoutsProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutsProducts_CheckoutId",
                table: "CheckoutsProducts",
                column: "CheckoutId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutsProducts_ProductId",
                table: "CheckoutsProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckoutsProducts");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "ExpirationMonth",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "ExpirationYear",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "Provider",
                table: "PaymentMethods");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "PaymentMethods",
                newName: "MethodName");

            migrationBuilder.CreateTable(
                name: "ProductList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CheckoutId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductList_Checkouts_CheckoutId",
                        column: x => x.CheckoutId,
                        principalTable: "Checkouts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductList_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_CheckoutId",
                table: "ProductList",
                column: "CheckoutId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_ProductId",
                table: "ProductList",
                column: "ProductId");
        }
    }
}
