using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "recommended_product_1_Img_link",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_1_Name",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_1_Year",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_2_Img_link",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_2_Name",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_2_Year",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_3_Img_link",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_3_Name",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_3_Year",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_4_Img_link",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_4_Name",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "recommended_product_4_Year",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "recommended_product_1_Img_link",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_1_Name",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_1_Year",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_2_Img_link",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_2_Name",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_2_Year",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_3_Img_link",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_3_Name",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_3_Year",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_4_Img_link",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_4_Name",
                table: "UBRecommendations");

            migrationBuilder.DropColumn(
                name: "recommended_product_4_Year",
                table: "UBRecommendations");
        }
    }
}
