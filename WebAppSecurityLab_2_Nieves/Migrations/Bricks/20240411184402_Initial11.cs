using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_IBRecommendations_Products_product_Id",
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

            migrationBuilder.AlterColumn<int>(
                name: "product_Id",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_1_Img_Link",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_1_Name",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_1_Price",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_1_Year",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_2_Img_Link",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_2_Name",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_2_Price",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_2_Year",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_3_Img_Link",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_3_Name",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_3_Price",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_3_Year",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_4_Img_Link",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_4_Name",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_4_Price",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Recommended_Product_4_Year",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recommended_Product_1_Img_Link",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_1_Name",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_1_Price",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_1_Year",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_2_Img_Link",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_2_Name",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_2_Price",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_2_Year",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_3_Img_Link",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_3_Name",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_3_Price",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_3_Year",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_4_Img_Link",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_4_Name",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_4_Price",
                table: "IBRecommendations");

            migrationBuilder.DropColumn(
                name: "Recommended_Product_4_Year",
                table: "IBRecommendations");

            migrationBuilder.AlterColumn<int>(
                name: "product_Id",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Recommended_Product_1_ID",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Recommended_Product_2_ID",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Recommended_Product_3_ID",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Recommended_Product_4_ID",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_IBRecommendations_Products_product_Id",
                table: "IBRecommendations",
                column: "product_Id",
                principalTable: "Products",
                principalColumn: "product_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
