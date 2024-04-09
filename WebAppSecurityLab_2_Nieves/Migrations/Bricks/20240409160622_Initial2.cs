using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    first_name = table.Column<string>(type: "TEXT", nullable: false),
                    last_name = table.Column<string>(type: "TEXT", nullable: false),
                    birth_date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    country_of_residence = table.Column<string>(type: "TEXT", nullable: false),
                    gender = table.Column<string>(type: "TEXT", nullable: true),
                    age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_Id);
                });

            migrationBuilder.CreateTable(
                name: "IBRecommendations",
                columns: table => new
                {
                    original_product = table.Column<string>(type: "TEXT", nullable: false),
                    recommended_product_1 = table.Column<int>(type: "INTEGER", nullable: false),
                    recommended_product_2 = table.Column<int>(type: "INTEGER", nullable: false),
                    recommended_product_3 = table.Column<int>(type: "INTEGER", nullable: false),
                    recommended_product_4 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IBRecommendations", x => x.original_product);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    year = table.Column<int>(type: "INTEGER", nullable: false),
                    num_parts = table.Column<int>(type: "INTEGER", nullable: true),
                    price = table.Column<double>(type: "REAL", nullable: false),
                    img_link = table.Column<string>(type: "TEXT", nullable: false),
                    primary_color = table.Column<string>(type: "TEXT", nullable: false),
                    secondary_color = table.Column<string>(type: "TEXT", nullable: false),
                    category = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    transaction_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_Id = table.Column<int>(type: "INTEGER", nullable: true),
                    customer_Id1 = table.Column<int>(type: "INTEGER", nullable: true),
                    date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    day_of_week = table.Column<string>(type: "TEXT", nullable: false),
                    time = table.Column<int>(type: "INTEGER", nullable: false),
                    entry_mode = table.Column<string>(type: "TEXT", nullable: false),
                    amount = table.Column<int>(type: "INTEGER", nullable: true),
                    type_of_transaction = table.Column<string>(type: "TEXT", nullable: false),
                    country_of_transaction = table.Column<string>(type: "TEXT", nullable: false),
                    shipping_address = table.Column<string>(type: "TEXT", nullable: true),
                    bank = table.Column<string>(type: "TEXT", nullable: false),
                    type_of_card = table.Column<string>(type: "TEXT", nullable: false),
                    fraud = table.Column<bool>(type: "INTEGER", nullable: false),
                    fulfilled = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.transaction_Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_customer_Id1",
                        column: x => x.customer_Id1,
                        principalTable: "Customers",
                        principalColumn: "customer_Id");
                });

            migrationBuilder.CreateTable(
                name: "UBRecommendations",
                columns: table => new
                {
                    customer_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customer_Id1 = table.Column<int>(type: "INTEGER", nullable: true),
                    recommended_product_1 = table.Column<int>(type: "INTEGER", nullable: false),
                    recommended_product_2 = table.Column<int>(type: "INTEGER", nullable: false),
                    recommended_product_3 = table.Column<int>(type: "INTEGER", nullable: false),
                    recommended_product_4 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UBRecommendations", x => x.customer_Id);
                    table.ForeignKey(
                        name: "FK_UBRecommendations_Customers_customer_Id1",
                        column: x => x.customer_Id1,
                        principalTable: "Customers",
                        principalColumn: "customer_Id");
                });

            migrationBuilder.CreateTable(
                name: "LineItems",
                columns: table => new
                {
                    transaction_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    product_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    qty = table.Column<int>(type: "INTEGER", nullable: false),
                    rating = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItems", x => new { x.transaction_Id, x.product_Id });
                    table.ForeignKey(
                        name: "FK_LineItems_Orders_transaction_Id",
                        column: x => x.transaction_Id,
                        principalTable: "Orders",
                        principalColumn: "transaction_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineItems_Products_product_Id",
                        column: x => x.product_Id,
                        principalTable: "Products",
                        principalColumn: "product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineItems_product_Id",
                table: "LineItems",
                column: "product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customer_Id1",
                table: "Orders",
                column: "customer_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_UBRecommendations_customer_Id1",
                table: "UBRecommendations",
                column: "customer_Id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IBRecommendations");

            migrationBuilder.DropTable(
                name: "LineItems");

            migrationBuilder.DropTable(
                name: "UBRecommendations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
