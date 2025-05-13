using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monday.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Update_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CheckoutsProducts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 100,
                column: "TotalPrice",
                value: 99.98m);

            migrationBuilder.UpdateData(
                table: "CheckoutsProducts",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amount", "Price" },
                values: new object[] { 2, 49.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "CheckoutsProducts");

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 100,
                column: "TotalPrice",
                value: 49.99m);

            migrationBuilder.UpdateData(
                table: "CheckoutsProducts",
                keyColumn: "Id",
                keyValue: 100,
                column: "Amount",
                value: 1);
        }
    }
}
