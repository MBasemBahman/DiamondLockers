using Microsoft.EntityFrameworkCore.Migrations;



namespace DevelopmentDAL.Migrations
{
    /// <inheritdoc />
    public partial class initialmigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OldValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Audits", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Categories", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Colors", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "DashboardAccessLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateAccess = table.Column<bool>(type: "bit", nullable: false),
                    EditAccess = table.Column<bool>(type: "bit", nullable: false),
                    ViewAccess = table.Column<bool>(type: "bit", nullable: false),
                    DeleteAccess = table.Column<bool>(type: "bit", nullable: false),
                    ExportAccess = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DashboardAccessLevels", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "DashboardAdministrationRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DashboardAdministrationRoles", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "DashboardViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ViewPath = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DashboardViews", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Logs", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    StorageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Products", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Culture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Users", x => x.Id);
                });

            _ = migrationBuilder.CreateTable(
                name: "CategoryLang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    FkSource = table.Column<int>(name: "Fk_Source", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_CategoryLang", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_CategoryLang_Categories_Fk_Source",
                        column: x => x.FkSource,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "ColorLang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    FkSource = table.Column<int>(name: "Fk_Source", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ColorLang", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ColorLang_Colors_Fk_Source",
                        column: x => x.FkSource,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "DashboardAccessLevelLang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    FkSource = table.Column<int>(name: "Fk_Source", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DashboardAccessLevelLang", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_DashboardAccessLevelLang_DashboardAccessLevels_Fk_Source",
                        column: x => x.FkSource,
                        principalTable: "DashboardAccessLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "DashboardAdministrationRoleLang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    FkSource = table.Column<int>(name: "Fk_Source", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DashboardAdministrationRoleLang", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_DashboardAdministrationRoleLang_DashboardAdministrationRoles_Fk_Source",
                        column: x => x.FkSource,
                        principalTable: "DashboardAdministrationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "AdministrationRolePremissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkDashboardAccessLevel = table.Column<int>(name: "Fk_DashboardAccessLevel", type: "int", nullable: false),
                    FkDashboardAdministrationRole = table.Column<int>(name: "Fk_DashboardAdministrationRole", type: "int", nullable: false),
                    FkDashboardView = table.Column<int>(name: "Fk_DashboardView", type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_AdministrationRolePremissions", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_AdministrationRolePremissions_DashboardAccessLevels_Fk_DashboardAccessLevel",
                        column: x => x.FkDashboardAccessLevel,
                        principalTable: "DashboardAccessLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_AdministrationRolePremissions_DashboardAdministrationRoles_Fk_DashboardAdministrationRole",
                        column: x => x.FkDashboardAdministrationRole,
                        principalTable: "DashboardAdministrationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_AdministrationRolePremissions_DashboardViews_Fk_DashboardView",
                        column: x => x.FkDashboardView,
                        principalTable: "DashboardViews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "DashboardViewLang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    FkSource = table.Column<int>(name: "Fk_Source", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DashboardViewLang", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_DashboardViewLang_DashboardViews_Fk_Source",
                        column: x => x.FkSource,
                        principalTable: "DashboardViews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "ProductLang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    FkSource = table.Column<int>(name: "Fk_Source", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_ProductLang", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_ProductLang_Products_Fk_Source",
                        column: x => x.FkSource,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "SizeLang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    FkSource = table.Column<int>(name: "Fk_Source", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_SizeLang", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_SizeLang_Sizes_Fk_Source",
                        column: x => x.FkSource,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "DashboardAdministrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkUser = table.Column<int>(name: "Fk_User", type: "int", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FkDashboardAdministrationRole = table.Column<int>(name: "Fk_DashboardAdministrationRole", type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_DashboardAdministrators", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_DashboardAdministrators_DashboardAdministrationRoles_Fk_DashboardAdministrationRole",
                        column: x => x.FkDashboardAdministrationRole,
                        principalTable: "DashboardAdministrationRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_DashboardAdministrators_Users_Fk_User",
                        column: x => x.FkUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkUser = table.Column<int>(name: "Fk_User", type: "int", nullable: false),
                    NotificationToken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Devices", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_Devices_Users_Fk_User",
                        column: x => x.FkUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkUser = table.Column<int>(name: "Fk_User", type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonRevoked = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_RefreshTokens_Users_Fk_User",
                        column: x => x.FkUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateTable(
                name: "Verifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkUser = table.Column<int>(name: "Fk_User", type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Verifications", x => x.Id);
                    _ = table.ForeignKey(
                        name: "FK_Verifications_Users_Fk_User",
                        column: x => x.FkUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.InsertData(
                table: "DashboardAccessLevels",
                columns: new[] { "Id", "ColorCode", "CreateAccess", "DeleteAccess", "EditAccess", "ExportAccess", "Name", "ViewAccess" },
                values: new object[,]
                {
                    { 1, null, true, true, true, true, "FullAccess", true },
                    { 2, null, true, false, true, true, "DataControl", true },
                    { 3, null, false, false, false, false, "Viewer", true }
                });

            _ = migrationBuilder.InsertData(
                table: "DashboardAdministrationRoles",
                columns: new[] { "Id", "ColorCode", "Name" },
                values: new object[] { 1, null, "Developer" });

            _ = migrationBuilder.InsertData(
                table: "DashboardViews",
                columns: new[] { "Id", "ColorCode", "Name", "ViewPath" },
                values: new object[,]
                {
                    { 1, null, "Home", "Home" },
                    { 2, null, "User", "User" },
                    { 3, null, "DashboardAdministrator", "DashboardAdministrator" },
                    { 4, null, "DashboardAccessLevel", "DashboardAccessLevel" },
                    { 5, null, "DashboardAdministrationRole", "DashboardAdministrationRole" },
                    { 6, null, "DashboardView", "DashboardView" },
                    { 7, null, "RefreshToken", "RefreshToken" },
                    { 8, null, "UserDevice", "UserDevice" },
                    { 9, null, "Verification", "Verification" },
                    { 10, null, "DBLogs", "DBLogs" },
                    { 11, null, "Audit", "Audit" },
                    { 12, null, "Category", "Category" },
                    { 13, null, "Size", "Size" },
                    { 14, null, "Color", "Color" },
                    { 15, null, "Product", "Product" }
                });

            _ = migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Culture", "EmailAddress", "LastModifiedBy", "Name", "Password", "PhoneNumber", "UserName" },
                values: new object[] { 1, null, "user@mail.com", null, "Developer", "$2a$11$n1xmBBMbgpRP7sMlLjk8wO06c7TVxifO3ADRmTLXu.XyVXmmIWQNS", null, "Developer" });

            _ = migrationBuilder.InsertData(
                table: "AdministrationRolePremissions",
                columns: new[] { "Id", "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 1, 2 },
                    { 3, 1, 1, 3 },
                    { 4, 1, 1, 4 },
                    { 5, 1, 1, 5 },
                    { 6, 1, 1, 6 },
                    { 7, 1, 1, 7 },
                    { 8, 1, 1, 8 },
                    { 9, 1, 1, 9 },
                    { 10, 1, 1, 10 },
                    { 11, 1, 1, 11 },
                    { 12, 1, 1, 12 },
                    { 13, 1, 1, 13 },
                    { 14, 1, 1, 14 },
                    { 15, 1, 1, 15 }
                });

            _ = migrationBuilder.InsertData(
                table: "DashboardAccessLevelLang",
                columns: new[] { "Id", "Fk_Source", "Name" },
                values: new object[,]
                {
                    { 1, 1, "FullAccess" },
                    { 2, 2, "DataControl" },
                    { 3, 3, "Viewer" }
                });

            _ = migrationBuilder.InsertData(
                table: "DashboardAdministrationRoleLang",
                columns: new[] { "Id", "Fk_Source", "Name" },
                values: new object[] { 1, 1, "Developer" });

            _ = migrationBuilder.InsertData(
                table: "DashboardAdministrators",
                columns: new[] { "Id", "Fk_DashboardAdministrationRole", "Fk_User", "JobTitle", "LastModifiedBy" },
                values: new object[] { 1, 1, 1, "Developer", null });

            _ = migrationBuilder.InsertData(
                table: "DashboardViewLang",
                columns: new[] { "Id", "Fk_Source", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Home" },
                    { 2, 2, "User" },
                    { 3, 3, "DashboardAdministrator" },
                    { 4, 4, "DashboardAccessLevel" },
                    { 5, 5, "DashboardAdministrationRole" },
                    { 6, 6, "DashboardView" },
                    { 7, 7, "RefreshToken" },
                    { 8, 8, "UserDevice" },
                    { 9, 9, "Verification" },
                    { 10, 10, "DBLogs" },
                    { 11, 11, "Audit" },
                    { 12, 12, "Category" },
                    { 13, 13, "Size" },
                    { 14, 14, "Color" },
                    { 15, 15, "Product" }
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_AdministrationRolePremissions_Fk_DashboardAccessLevel",
                table: "AdministrationRolePremissions",
                column: "Fk_DashboardAccessLevel");

            _ = migrationBuilder.CreateIndex(
                name: "IX_AdministrationRolePremissions_Fk_DashboardAdministrationRole_Fk_DashboardView",
                table: "AdministrationRolePremissions",
                columns: new[] { "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_AdministrationRolePremissions_Fk_DashboardView",
                table: "AdministrationRolePremissions",
                column: "Fk_DashboardView");

            _ = migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_CategoryLang_Fk_Source",
                table: "CategoryLang",
                column: "Fk_Source",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ColorLang_Fk_Source",
                table: "ColorLang",
                column: "Fk_Source",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Colors_Name",
                table: "Colors",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardAccessLevelLang_Fk_Source",
                table: "DashboardAccessLevelLang",
                column: "Fk_Source",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardAccessLevels_Name",
                table: "DashboardAccessLevels",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardAdministrationRoleLang_Fk_Source",
                table: "DashboardAdministrationRoleLang",
                column: "Fk_Source",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardAdministrationRoles_Name",
                table: "DashboardAdministrationRoles",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardAdministrators_Fk_DashboardAdministrationRole",
                table: "DashboardAdministrators",
                column: "Fk_DashboardAdministrationRole");

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardAdministrators_Fk_User",
                table: "DashboardAdministrators",
                column: "Fk_User",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardViewLang_Fk_Source",
                table: "DashboardViewLang",
                column: "Fk_Source",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardViews_Name",
                table: "DashboardViews",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_DashboardViews_ViewPath",
                table: "DashboardViews",
                column: "ViewPath",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Devices_Fk_User",
                table: "Devices",
                column: "Fk_User");

            _ = migrationBuilder.CreateIndex(
                name: "IX_Devices_NotificationToken",
                table: "Devices",
                column: "NotificationToken",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_ProductLang_Fk_Source",
                table: "ProductLang",
                column: "Fk_Source",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_Fk_User",
                table: "RefreshTokens",
                column: "Fk_User");

            _ = migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_Token",
                table: "RefreshTokens",
                column: "Token",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_SizeLang_Fk_Source",
                table: "SizeLang",
                column: "Fk_Source",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Sizes_Name",
                table: "Sizes",
                column: "Name",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Verifications_Code",
                table: "Verifications",
                column: "Code",
                unique: true);

            _ = migrationBuilder.CreateIndex(
                name: "IX_Verifications_Fk_User",
                table: "Verifications",
                column: "Fk_User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropTable(
                name: "AdministrationRolePremissions");

            _ = migrationBuilder.DropTable(
                name: "Audits");

            _ = migrationBuilder.DropTable(
                name: "CategoryLang");

            _ = migrationBuilder.DropTable(
                name: "ColorLang");

            _ = migrationBuilder.DropTable(
                name: "DashboardAccessLevelLang");

            _ = migrationBuilder.DropTable(
                name: "DashboardAdministrationRoleLang");

            _ = migrationBuilder.DropTable(
                name: "DashboardAdministrators");

            _ = migrationBuilder.DropTable(
                name: "DashboardViewLang");

            _ = migrationBuilder.DropTable(
                name: "Devices");

            _ = migrationBuilder.DropTable(
                name: "Logs");

            _ = migrationBuilder.DropTable(
                name: "ProductLang");

            _ = migrationBuilder.DropTable(
                name: "RefreshTokens");

            _ = migrationBuilder.DropTable(
                name: "SizeLang");

            _ = migrationBuilder.DropTable(
                name: "Verifications");

            _ = migrationBuilder.DropTable(
                name: "Categories");

            _ = migrationBuilder.DropTable(
                name: "Colors");

            _ = migrationBuilder.DropTable(
                name: "DashboardAccessLevels");

            _ = migrationBuilder.DropTable(
                name: "DashboardAdministrationRoles");

            _ = migrationBuilder.DropTable(
                name: "DashboardViews");

            _ = migrationBuilder.DropTable(
                name: "Products");

            _ = migrationBuilder.DropTable(
                name: "Sizes");

            _ = migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
