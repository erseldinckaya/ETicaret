using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretBackend.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Orders_OrdersGuid",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Products_ProductsGuid",
                table: "OrderProduct");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductsGuid",
                table: "OrderProduct",
                newName: "ProductsId");

            migrationBuilder.RenameColumn(
                name: "OrdersGuid",
                table: "OrderProduct",
                newName: "OrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductsGuid",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductsId");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Customers",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Orders_OrdersId",
                table: "OrderProduct",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Products_ProductsId",
                table: "OrderProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Orders_OrdersId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Products_ProductsId",
                table: "OrderProduct");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "OrderProduct",
                newName: "ProductsGuid");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "OrderProduct",
                newName: "OrdersGuid");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                newName: "IX_OrderProduct_ProductsGuid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "Guid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Orders_OrdersGuid",
                table: "OrderProduct",
                column: "OrdersGuid",
                principalTable: "Orders",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Products_ProductsGuid",
                table: "OrderProduct",
                column: "ProductsGuid",
                principalTable: "Products",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
