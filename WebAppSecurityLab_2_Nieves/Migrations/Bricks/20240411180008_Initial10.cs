using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_IBRecommendations_Recommended_Product_1_ID",
                table: "IBRecommendations",
                column: "Recommended_Product_1_ID");

            migrationBuilder.CreateIndex(
                name: "IX_IBRecommendations_Recommended_Product_2_ID",
                table: "IBRecommendations",
                column: "Recommended_Product_2_ID");

            migrationBuilder.CreateIndex(
                name: "IX_IBRecommendations_Recommended_Product_3_ID",
                table: "IBRecommendations",
                column: "Recommended_Product_3_ID");

            migrationBuilder.CreateIndex(
                name: "IX_IBRecommendations_Recommended_Product_4_ID",
                table: "IBRecommendations",
                column: "Recommended_Product_4_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_IBRecommendations_Products_Recommended_Product_1_ID",
                table: "IBRecommendations",
                column: "Recommended_Product_1_ID",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IBRecommendations_Products_Recommended_Product_2_ID",
                table: "IBRecommendations",
                column: "Recommended_Product_2_ID",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IBRecommendations_Products_Recommended_Product_3_ID",
                table: "IBRecommendations",
                column: "Recommended_Product_3_ID",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IBRecommendations_Products_Recommended_Product_4_ID",
                table: "IBRecommendations",
                column: "Recommended_Product_4_ID",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IBRecommendations_Products_Recommended_Product_1_ID",
                table: "IBRecommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_IBRecommendations_Products_Recommended_Product_2_ID",
                table: "IBRecommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_IBRecommendations_Products_Recommended_Product_3_ID",
                table: "IBRecommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_IBRecommendations_Products_Recommended_Product_4_ID",
                table: "IBRecommendations");

            migrationBuilder.DropIndex(
                name: "IX_IBRecommendations_Recommended_Product_1_ID",
                table: "IBRecommendations");

            migrationBuilder.DropIndex(
                name: "IX_IBRecommendations_Recommended_Product_2_ID",
                table: "IBRecommendations");

            migrationBuilder.DropIndex(
                name: "IX_IBRecommendations_Recommended_Product_3_ID",
                table: "IBRecommendations");

            migrationBuilder.DropIndex(
                name: "IX_IBRecommendations_Recommended_Product_4_ID",
                table: "IBRecommendations");
        }
    }
}
