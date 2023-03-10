using Microsoft.EntityFrameworkCore.Migrations;


namespace DevelopmentDAL.Migrations
{
    /// <inheritdoc />
    public partial class productrelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkProduct = table.Column<int>(name: "Fk_Product", type: "int", nullable: false),
                    FkCategory = table.Column<int>(name: "Fk_Category", type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ProductCategory", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ProductCategory_Categories_Fk_Category",
                        column: x => x.FkCategory,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_ProductCategory_Products_Fk_Product",
                        column: x => x.FkProduct,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "ProductColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkProduct = table.Column<int>(name: "Fk_Product", type: "int", nullable: false),
                    FkColor = table.Column<int>(name: "Fk_Color", type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ProductColor", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ProductColor_Colors_Fk_Color",
                        column: x => x.FkColor,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_ProductColor_Products_Fk_Product",
                        column: x => x.FkProduct,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkProduct = table.Column<int>(name: "Fk_Product", type: "int", nullable: false),
                    FkSize = table.Column<int>(name: "Fk_Size", type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ProductSize", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ProductSize_Products_Fk_Product",
                        column: x => x.FkProduct,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_ProductSize_Sizes_Fk_Size",
                        column: x => x.FkSize,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_Fk_Category",
                table: "ProductCategory",
                column: "Fk_Category");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_Fk_Product",
                table: "ProductCategory",
                column: "Fk_Product");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_Name",
                table: "ProductCategory",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductColor_Fk_Color",
                table: "ProductColor",
                column: "Fk_Color");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductColor_Fk_Product",
                table: "ProductColor",
                column: "Fk_Product");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductColor_Name",
                table: "ProductColor",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductSize_Fk_Product",
                table: "ProductSize",
                column: "Fk_Product");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductSize_Fk_Size",
                table: "ProductSize",
                column: "Fk_Size");

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductSize_Name",
                table: "ProductSize",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "ProductCategory");

            _ = migrationBuilder.DropTable(
                name: "ProductColor");

            _ = migrationBuilder.DropTable(
                name: "ProductSize");
        }
    }
}
