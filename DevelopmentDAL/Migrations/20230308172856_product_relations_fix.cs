using Microsoft.EntityFrameworkCore.Migrations;


namespace DevelopmentDAL.Migrations
{
    /// <inheritdoc />
    public partial class productrelationsfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropIndex(
                name: "IX_ProductSize_Name",
                table: "ProductSize");

            _ = migrationBuilder.DropIndex(
                name: "IX_ProductColor_Name",
                table: "ProductColor");

            _ = migrationBuilder.DropIndex(
                name: "IX_ProductCategory_Name",
                table: "ProductCategory");

            _ = migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "ProductSize");

            _ = migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductSize");

            _ = migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "ProductColor");

            _ = migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductColor");

            _ = migrationBuilder.DropColumn(
                name: "ColorCode",
                table: "ProductCategory");

            _ = migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductCategory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "ProductSize",
                type: "nvarchar(max)",
                nullable: true);

            _ = migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductSize",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            _ = migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "ProductColor",
                type: "nvarchar(max)",
                nullable: true);

            _ = migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductColor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            _ = migrationBuilder.AddColumn<string>(
                name: "ColorCode",
                table: "ProductCategory",
                type: "nvarchar(max)",
                nullable: true);

            _ = migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductCategory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductSize_Name",
                table: "ProductSize",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductColor_Name",
                table: "ProductColor",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_Name",
                table: "ProductCategory",
                column: "Name",
                unique: true);
        }
    }
}
