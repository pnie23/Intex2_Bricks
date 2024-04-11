using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_1_ID",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_2_ID",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_3_ID",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_4_ID",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recommended_Product_1_ID",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_2_ID",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_3_ID",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_4_ID",
                table: "IBRecommendations");
        }
    }
}
