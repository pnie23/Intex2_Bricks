using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_3_Year",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_4_Img_link",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_4_Name",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_4_Year",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "recommended_product_3_Year",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_4_Img_link",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_4_Name",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_4_Year",
                table: "IBRecommendations");
        }
    }
}
