using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    /// <inheritdoc />
    public partial class Initial12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prediction",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_Year",
                table: "IBRecommendations",
                newName: "recommended_product_4_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_Name",
                table: "IBRecommendations",
                newName: "recommended_product_4_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_4_Img_Link",
                table: "IBRecommendations",
                newName: "recommended_product_4_Img_link");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_Year",
                table: "IBRecommendations",
                newName: "recommended_product_3_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_Name",
                table: "IBRecommendations",
                newName: "recommended_product_3_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_3_Img_Link",
                table: "IBRecommendations",
                newName: "recommended_product_3_Img_link");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_Year",
                table: "IBRecommendations",
                newName: "recommended_product_2_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_Name",
                table: "IBRecommendations",
                newName: "recommended_product_2_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_2_Img_Link",
                table: "IBRecommendations",
                newName: "recommended_product_2_Img_link");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_Year",
                table: "IBRecommendations",
                newName: "recommended_product_1_Year");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_Name",
                table: "IBRecommendations",
                newName: "recommended_product_1_Name");

            migrationBuilder.RenameColumn(
                name: "Recommended_Product_1_Img_Link",
                table: "IBRecommendations",
                newName: "recommended_product_1_Img_link");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_4_Year",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Recommended_Product_4_Price",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_4_Name",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_4_Img_link",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_3_Year",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Recommended_Product_3_Price",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_3_Name",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_3_Img_link",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_2_Year",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Recommended_Product_2_Price",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_2_Name",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_2_Img_link",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_1_Year",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Recommended_Product_1_Price",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_1_Name",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "recommended_product_1_Img_link",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "product_Id",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "original_product",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.DropColumn(
                name: "original_product",
                table: "IBRecommendations");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Year",
                table: "IBRecommendations",
                newName: "Recommended_Product_4_Year");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Name",
                table: "IBRecommendations",
                newName: "Recommended_Product_4_Name");

            migrationBuilder.RenameColumn(
                name: "recommended_product_4_Img_link",
                table: "IBRecommendations",
                newName: "Recommended_Product_4_Img_Link");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3_Year",
                table: "IBRecommendations",
                newName: "Recommended_Product_3_Year");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3_Name",
                table: "IBRecommendations",
                newName: "Recommended_Product_3_Name");

            migrationBuilder.RenameColumn(
                name: "recommended_product_3_Img_link",
                table: "IBRecommendations",
                newName: "Recommended_Product_3_Img_Link");

            migrationBuilder.RenameColumn(
                name: "recommended_product_2_Year",
                table: "IBRecommendations",
                newName: "Recommended_Product_2_Year");

            migrationBuilder.RenameColumn(
                name: "recommended_product_2_Name",
                table: "IBRecommendations",
                newName: "Recommended_Product_2_Name");

            migrationBuilder.RenameColumn(
                name: "recommended_product_2_Img_link",
                table: "IBRecommendations",
                newName: "Recommended_Product_2_Img_Link");

            migrationBuilder.RenameColumn(
                name: "recommended_product_1_Year",
                table: "IBRecommendations",
                newName: "Recommended_Product_1_Year");

            migrationBuilder.RenameColumn(
                name: "recommended_product_1_Name",
                table: "IBRecommendations",
                newName: "Recommended_Product_1_Name");

            migrationBuilder.RenameColumn(
                name: "recommended_product_1_Img_link",
                table: "IBRecommendations",
                newName: "Recommended_Product_1_Img_Link");

            migrationBuilder.AddColumn<string>(
                name: "Prediction",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_4_Year",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_4_Name",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_4_Img_Link",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_3_Year",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_3_Name",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_3_Img_Link",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_2_Year",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_2_Name",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_2_Img_Link",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_1_Year",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_1_Name",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_1_Img_Link",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_4_Price",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_3_Price",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_2_Price",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Recommended_Product_1_Price",
                table: "IBRecommendations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "product_Id",
                table: "IBRecommendations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
