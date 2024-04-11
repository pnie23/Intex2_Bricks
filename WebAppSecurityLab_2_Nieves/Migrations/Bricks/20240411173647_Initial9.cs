using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recommended_Product_1_Price",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_2_Price",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_3_Price",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_4_Price",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "original_product",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_1_Img_link",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_1_Name",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_1_Year",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_2_Img_link",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_2_Name",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_2_Year",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_3_Img_link",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_3_Name",
                table: "IBRecommendations");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Year",
                table: "IBRecommendations",
                newName: "Recommended_Product_4_ID");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Name",
                table: "IBRecommendations",
                newName: "Recommended_Product_3_ID");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Img_link",
                table: "IBRecommendations",
                newName: "Recommended_Product_2_ID");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3_Year",
                table: "IBRecommendations",
                newName: "Recommended_Product_1_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_ID",
                table: "IBRecommendations",
                newName: "recommended_product_4_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_ID",
                table: "IBRecommendations",
                newName: "recommended_product_4_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_ID",
                table: "IBRecommendations",
                newName: "recommended_product_4_Img_link");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_ID",
                table: "IBRecommendations",
                newName: "recommended_product_3_Year");

            migrationBuilder.AddColumn<int>(
                name: "Recommended_Product_1_Price",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Recommended_Product_2_Price",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Recommended_Product_3_Price",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Recommended_Product_4_Price",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "original_product",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_1_Img_link",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_1_Name",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_1_Year",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_2_Img_link",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_2_Name",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_2_Year",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_3_Img_link",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_3_Name",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
