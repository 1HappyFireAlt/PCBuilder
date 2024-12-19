using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCBuilder.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressPostcodeCityToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_AspNetUsers_UserId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Communities_CommunityId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_AspNetUsers_UserId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_Communities_CommunityId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentCategories_ComponentCategoryId",
                table: "Components");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "ComponentCategories");

            migrationBuilder.DropIndex(
                name: "IX_Components_ComponentCategoryId",
                table: "Components");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Communities",
                table: "Communities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "ComponentCategoryId",
                table: "Components");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Communities",
                newName: "Community");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "ShopBasket");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_UserId",
                table: "ShopBasket",
                newName: "IX_ShopBasket_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_CommunityId",
                table: "ShopBasket",
                newName: "IX_ShopBasket_CommunityId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Builds",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Community",
                table: "Community",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopBasket",
                table: "ShopBasket",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ComponentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ComponentId",
                table: "OrderItem",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_AspNetUsers_UserId",
                table: "Builds",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_Community_CommunityId",
                table: "Builds",
                column: "CommunityId",
                principalTable: "Community",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopBasket_AspNetUsers_UserId",
                table: "ShopBasket",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopBasket_Community_CommunityId",
                table: "ShopBasket",
                column: "CommunityId",
                principalTable: "Community",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Builds_AspNetUsers_UserId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_Community_CommunityId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopBasket_AspNetUsers_UserId",
                table: "ShopBasket");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopBasket_Community_CommunityId",
                table: "ShopBasket");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopBasket",
                table: "ShopBasket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Community",
                table: "Community");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "ShopBasket",
                newName: "Baskets");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Community",
                newName: "Communities");

            migrationBuilder.RenameIndex(
                name: "IX_ShopBasket_UserId",
                table: "Baskets",
                newName: "IX_Baskets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopBasket_CommunityId",
                table: "Baskets",
                newName: "IX_Baskets_CommunityId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.AddColumn<int>(
                name: "ComponentCategoryId",
                table: "Components",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Builds",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Order",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Communities",
                table: "Communities",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ComponentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    IconClass = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ComponentId = table.Column<int>(type: "INTEGER", nullable: false),
                    BasketId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_ComponentCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ComponentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Components_ComponentCategoryId",
                table: "Components",
                column: "ComponentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_CategoryId",
                table: "BasketItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ComponentId",
                table: "BasketItems",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_OrderId",
                table: "BasketItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_AspNetUsers_UserId",
                table: "Baskets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Communities_CommunityId",
                table: "Baskets",
                column: "CommunityId",
                principalTable: "Communities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_AspNetUsers_UserId",
                table: "Builds",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_Communities_CommunityId",
                table: "Builds",
                column: "CommunityId",
                principalTable: "Communities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentCategories_ComponentCategoryId",
                table: "Components",
                column: "ComponentCategoryId",
                principalTable: "ComponentCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
