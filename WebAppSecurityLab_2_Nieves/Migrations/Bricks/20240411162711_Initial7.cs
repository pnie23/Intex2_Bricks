using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IBRecommendations",
                table: "IBRecommendations");

            migrationBuilder.AddColumn<string>(
                name: "Prediction",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "product_Id",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IBRecommendations",
                table: "IBRecommendations",
                column: "product_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IBRecommendations_Products_product_Id",
                table: "IBRecommendations",
                column: "product_Id",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IBRecommendations_Products_product_Id",
                table: "IBRecommendations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IBRecommendations",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Prediction",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "product_Id",
                table: "IBRecommendations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IBRecommendations",
                table: "IBRecommendations",
                column: "original_product");
        }
    }
}
