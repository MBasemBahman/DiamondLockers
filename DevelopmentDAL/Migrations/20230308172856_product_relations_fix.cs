using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevelopmentDAL.Migrations
{
    /// <inheritdoc />
    public partial class productrelationsfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductSize_Name",
                table: "ProductSize");

            migrationBuilder.DropIndex(
                name: "IX_ProductColor_Name",
                table: "ProductColor");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategory_Name",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductSize");

            migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductColor");

            migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "ProductCategory");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductCategory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "ProductSize",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductSize",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "ProductColor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductColor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "ProductCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductCategory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_Name",
                table: "ProductSize",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductColor_Name",
                table: "ProductColor",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_Name",
                table: "ProductCategory",
                column: "Name",
                unique: true);
        }
    }
}
