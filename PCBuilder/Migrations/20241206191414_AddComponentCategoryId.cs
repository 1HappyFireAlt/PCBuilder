using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCBuilder.Migrations
{
    /// <inheritdoc />
    public partial class AddComponentCategoryId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Baskets_ShopBasketId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Components_ProductId",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketItems_ShopBasketId",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "ShopBasketId",
                table: "BasketItems");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "BasketItems",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                newName: "IX_BasketItems_CategoryId");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Components",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "ComponentCategoryId",
                table: "Components",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ComponentCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    IconClass = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Components_ComponentCategoryId",
                table: "Components",
                column: "ComponentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_ComponentCategory_CategoryId",
                table: "BasketItems",
                column: "CategoryId",
                principalTable: "ComponentCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentCategory_ComponentCategoryId",
                table: "Components",
                column: "ComponentCategoryId",
                principalTable: "ComponentCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_ComponentCategory_CategoryId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentCategory_ComponentCategoryId",
                table: "Components");

            migrationBuilder.DropTable(
                name: "ComponentCategory");

            migrationBuilder.DropIndex(
                name: "IX_Components_ComponentCategoryId",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "ComponentCategoryId",
                table: "Components");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "BasketItems",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_CategoryId",
                table: "BasketItems",
                newName: "IX_BasketItems_ProductId");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Components",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<int>(
                name: "ShopBasketId",
                table: "BasketItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ShopBasketId",
                table: "BasketItems",
                column: "ShopBasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Baskets_ShopBasketId",
                table: "BasketItems",
                column: "ShopBasketId",
                principalTable: "Baskets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Components_ProductId",
                table: "BasketItems",
                column: "ProductId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
