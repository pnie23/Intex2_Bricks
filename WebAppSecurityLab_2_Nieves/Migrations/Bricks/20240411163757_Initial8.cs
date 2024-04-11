using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "recommended_product_4",
                table: "IBRecommendations",
                newName: "Recommended_Product_4_Price");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3",
                table: "IBRecommendations",
                newName: "Recommended_Product_3_Price");

            migrationBuilder.RenameColumn(
                name: "recommended_product_2",
                table: "IBRecommendations",
                newName: "Recommended_Product_2_Price");

            migrationBuilder.RenameColumn(
                name: "recommended_product_1",
                table: "IBRecommendations",
                newName: "Recommended_Product_1_Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_Price",
                table: "IBRecommendations",
                newName: "recommended_product_4");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_Price",
                table: "IBRecommendations",
                newName: "recommended_product_3");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_Price",
                table: "IBRecommendations",
                newName: "recommended_product_2");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_Price",
                table: "IBRecommendations",
                newName: "recommended_product_1");
        }
    }
}
