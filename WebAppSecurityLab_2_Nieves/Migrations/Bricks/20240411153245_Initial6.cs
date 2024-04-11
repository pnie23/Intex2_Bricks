using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Year",
                table: "UBRecommendations",
                newName: "Recommended_Product_4_Year");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Name",
                table: "UBRecommendations",
                newName: "Recommended_Product_4_Name");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Img_link",
                table: "UBRecommendations",
                newName: "Recommended_Product_4_Img_Link");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3_Year",
                table: "UBRecommendations",
                newName: "Recommended_Product_3_Year");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3_Name",
                table: "UBRecommendations",
                newName: "Recommended_Product_3_Name");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3_Img_link",
                table: "UBRecommendations",
                newName: "Recommended_Product_3_Img_Link");

            migrationBuilder.RenameColumn(
                name: "recommended_product_2_Year",
                table: "UBRecommendations",
                newName: "Recommended_Product_2_Year");

            migrationBuilder.RenameColumn(
                name: "recommended_product_2_Name",
                table: "UBRecommendations",
                newName: "Recommended_Product_2_Name");

            migrationBuilder.RenameColumn(
                name: "recommended_product_2_Img_link",
                table: "UBRecommendations",
                newName: "Recommended_Product_2_Img_Link");

            migrationBuilder.RenameColumn(
                name: "recommended_product_1_Year",
                table: "UBRecommendations",
                newName: "Recommended_Product_1_Year");

            migrationBuilder.RenameColumn(
                name: "recommended_product_1_Name",
                table: "UBRecommendations",
                newName: "Recommended_Product_1_Name");

            migrationBuilder.RenameColumn(
                name: "recommended_product_1_Img_link",
                table: "UBRecommendations",
                newName: "Recommended_Product_1_Img_Link");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4",
                table: "UBRecommendations",
                newName: "Recommended_Product_4_Price");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3",
                table: "UBRecommendations",
                newName: "Recommended_Product_3_Price");

            migrationBuilder.RenameColumn(
                name: "recommended_product_2",
                table: "UBRecommendations",
                newName: "Recommended_Product_2_Price");

            migrationBuilder.RenameColumn(
                name: "recommended_product_1",
                table: "UBRecommendations",
                newName: "Recommended_Product_1_Price");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_4_Name",
                table: "UBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_4_Img_Link",
                table: "UBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_3_Name",
                table: "UBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_3_Img_Link",
                table: "UBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_2_Name",
                table: "UBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_2_Img_Link",
                table: "UBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_1_Name",
                table: "UBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_1_Img_Link",
                table: "UBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_Year",
                table: "UBRecommendations",
                newName: "recommended_product_4_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_Name",
                table: "UBRecommendations",
                newName: "recommended_product_4_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_Img_Link",
                table: "UBRecommendations",
                newName: "recommended_product_4_Img_link");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_Year",
                table: "UBRecommendations",
                newName: "recommended_product_3_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_Name",
                table: "UBRecommendations",
                newName: "recommended_product_3_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_Img_Link",
                table: "UBRecommendations",
                newName: "recommended_product_3_Img_link");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_Year",
                table: "UBRecommendations",
                newName: "recommended_product_2_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_Name",
                table: "UBRecommendations",
                newName: "recommended_product_2_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_Img_Link",
                table: "UBRecommendations",
                newName: "recommended_product_2_Img_link");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_Year",
                table: "UBRecommendations",
                newName: "recommended_product_1_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_Name",
                table: "UBRecommendations",
                newName: "recommended_product_1_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_Img_Link",
                table: "UBRecommendations",
                newName: "recommended_product_1_Img_link");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_Price",
                table: "UBRecommendations",
                newName: "recommended_product_4");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_Price",
                table: "UBRecommendations",
                newName: "recommended_product_3");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_Price",
                table: "UBRecommendations",
                newName: "recommended_product_2");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_Price",
                table: "UBRecommendations",
                newName: "recommended_product_1");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_4_Name",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_4_Img_link",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_3_Name",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_3_Img_link",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_2_Name",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_2_Img_link",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_1_Name",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_1_Img_link",
                table: "UBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
