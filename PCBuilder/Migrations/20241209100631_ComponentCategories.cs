using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCBuilder.Migrations
{
    /// <inheritdoc />
    public partial class ComponentCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_ComponentCategory_CategoryId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Components_ComponentId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentCategory_ComponentCategoryId",
                table: "Components");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_ComponentId",
                table: "Baskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComponentCategory",
                table: "ComponentCategory");

            migrationBuilder.DropColumn(
                name: "ComponentId",
                table: "Baskets");

            migrationBuilder.RenameTable(
                name: "ComponentCategory",
                newName: "ComponentCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComponentCategories",
                table: "ComponentCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_ComponentCategories_CategoryId",
                table: "BasketItems",
                column: "CategoryId",
                principalTable: "ComponentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentCategories_ComponentCategoryId",
                table: "Components",
                column: "ComponentCategoryId",
                principalTable: "ComponentCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_ComponentCategories_CategoryId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentCategories_ComponentCategoryId",
                table: "Components");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComponentCategories",
                table: "ComponentCategories");

            migrationBuilder.RenameTable(
                name: "ComponentCategories",
                newName: "ComponentCategory");

            migrationBuilder.AddColumn<int>(
                name: "ComponentId",
                table: "Baskets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComponentCategory",
                table: "ComponentCategory",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ComponentId",
                table: "Baskets",
                column: "ComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_ComponentCategory_CategoryId",
                table: "BasketItems",
                column: "CategoryId",
                principalTable: "ComponentCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Components_ComponentId",
                table: "Baskets",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentCategory_ComponentCategoryId",
                table: "Components",
                column: "ComponentCategoryId",
                principalTable: "ComponentCategory",
                principalColumn: "Id");
        }
    }
}
