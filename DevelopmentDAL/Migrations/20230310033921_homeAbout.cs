using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevelopmentDAL.Migrations
{
    /// <inheritdoc />
    public partial class homeAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 6 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 7 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 8 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 9 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 10 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 11 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 12 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 13 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 14 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 15 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 16 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 17 });

            migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fk_Source",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fk_Source",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DashboardAdministrationRoleLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DashboardAdministrators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fk_DashboardAdministrationRole", "Fk_User" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fk_Source",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fk_Source",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fk_Source",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fk_Source",
                value: 5);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 6,
                column: "Fk_Source",
                value: 6);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 7,
                column: "Fk_Source",
                value: 7);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 8,
                column: "Fk_Source",
                value: 8);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 9,
                column: "Fk_Source",
                value: 9);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 10,
                column: "Fk_Source",
                value: 10);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 11,
                column: "Fk_Source",
                value: 11);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 12,
                column: "Fk_Source",
                value: 12);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 13,
                column: "Fk_Source",
                value: 13);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 14,
                column: "Fk_Source",
                value: 14);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 15,
                column: "Fk_Source",
                value: 15);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 16,
                column: "Fk_Source",
                value: 16);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 17,
                column: "Fk_Source",
                value: 17);

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "DisplayName", "Key", "LastModifiedBy", "Order", "Type", "Value" },
                values: new object[,]
                {
                    { 116, "عن الشركة", "aboutDesc", null, 0, 2, "Streamlined operations and better access control make Diamond Lockers 1st for intelligent locker storage management in Saudi Arabia. " },
                    { 117, "عن الشركة", "aboutDesc_lang", null, 0, 2, "إنسيابية العمليات والتحكم في الاستخدام هو ما يجعل دايموند لوكرز الأولي في إدارة الخزائن الذكية في المملكة العربية السعودية. " },
                    { 118, "عن الشركة", "learnMoreBtn", null, 0, 0, "Learn More" },
                    { 119, "عن الشركة", "learnMoreBtn_lang", null, 0, 0, "للمزيد" },
                    { 120, "عن الشركة", "missionTitle", null, 0, 0, "Mission" },
                    { 121, "عن الشركة", "missionTitle_lang", null, 0, 0, "مهمتنا" },
                    { 122, "عن الشركة", "missionDesc", null, 0, 0, "To offer accessible, safe, and efficient state-of-the-art technology without compromising customer service. " },
                    { 123, "عن الشركة", "missionDesc_lang", null, 0, 0, " نقدم خزائن تتميز بسهولة الاستخدام والأمان والتقنية التكنولوجية الحديثة. " },
                    { 124, "عن الشركة", "visionTitle", null, 0, 0, "Vision" },
                    { 125, "عن الشركة", "visionTitle_lang", null, 0, 0, "رؤيتنا" },
                    { 126, "عن الشركة", "visionDesc", null, 0, 0, "To be Saudi Arabia's number-one choice for innovation in intelligent storage locker solutions. " },
                    { 127, "عن الشركة", "visionDesc_lang", null, 0, 0, " نكون الاختيار الأول فى المملكة العربية السعودية لحلول الخزائن الذكية." }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$g3v66MMK0d37VdXFK9t/g.HP7V449kZap02Wk6or5txWxpb6pfKyW");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardAdministrationRoleLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardAdministrators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fk_DashboardAdministrationRole", "Fk_User" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 6,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 7,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 8,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 9,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 10,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 11,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 12,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 13,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 14,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 15,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 16,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 17,
                column: "Fk_Source",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$T9EF1cY1UCbYktq6iXdQtuz/IBodOa7m9Qm/ROqjzAIxWZmcC5Bei");
        }
    }
}
