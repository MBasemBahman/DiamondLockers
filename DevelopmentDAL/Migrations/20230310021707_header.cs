using Microsoft.EntityFrameworkCore.Migrations;



namespace DevelopmentDAL.Migrations
{
    /// <inheritdoc />
    public partial class header : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 1 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 2 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 3 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 4 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 5 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 6 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 7 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 8 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 9 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 10 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 11 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 12 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 13 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 14 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 15 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 16 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 1, 1, 17 });

            _ = migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 1);

            _ = migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fk_Source",
                value: 2);

            _ = migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fk_Source",
                value: 3);

            _ = migrationBuilder.UpdateData(
                table: "DashboardAdministrationRoleLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 1);

            _ = migrationBuilder.UpdateData(
                table: "DashboardAdministrators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fk_DashboardAdministrationRole", "Fk_User" },
                values: new object[] { 1, 1 });

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 1);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fk_Source",
                value: 2);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fk_Source",
                value: 3);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fk_Source",
                value: 4);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fk_Source",
                value: 5);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 6,
                column: "Fk_Source",
                value: 6);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 7,
                column: "Fk_Source",
                value: 7);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 8,
                column: "Fk_Source",
                value: 8);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 9,
                column: "Fk_Source",
                value: 9);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 10,
                column: "Fk_Source",
                value: 10);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 11,
                column: "Fk_Source",
                value: 11);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 12,
                column: "Fk_Source",
                value: 12);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 13,
                column: "Fk_Source",
                value: 13);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 14,
                column: "Fk_Source",
                value: 14);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 15,
                column: "Fk_Source",
                value: 15);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 16,
                column: "Fk_Source",
                value: 16);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 17,
                column: "Fk_Source",
                value: 17);

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "القائمه الرئيسية", "culture", "AR" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "القائمه الرئيسية", "culture_lang", "EN" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "slogan", "slider", 2, "Your Diamonds are in secured Lockers! " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "slogan", "slider_lang", 2, "ألماساتك في خزائن آمنة!" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature1", "AVAILABILITY" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature1_desc", "24 / 7 lockers at your service" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature1_lang", "الخدمة" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature1_desc_lang", "24/7 الخزائن في خدمتك" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature2", "Non-contact" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature2_desc", "Intelligent lockers are hygienic and clean" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature2_lang", "بدون تلامس " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature2_desc_lang", "الخزائن الذكية صحية ونظيفة" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature3", "COST REDUCTION" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature3_desc", "Unneeded human presence" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature3_lang", "تكلفة أقل " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature3_desc_lang", "لا حاجة لوجود موظف إضافي" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخصائص", "feature4", "Safety" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature4_desc", 0, "Integrated camera surveillance as needed" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخصائص", "feature4_lang", "الحماية" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature4_desc_lang", 0, "كاميرات مراقبة متكاملة حسب الطلب" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service1", "Rent or Buy?" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service1_desc", "Our team will be glad to support you with this decision" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service1_lang", "إيجار أم شراء؟" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service1_desc_lang", "سنكون سعداء بمساعدتك على اتخاذ القرار" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service2", "After Sale Service" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service2_desc", "- 2 years warranty\r\n- Delivery to your location\r\n- Installation\r\n- Staff training\r\n- Maintenance\r\n- Spare parts " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service2_lang", "خدمات ما بعد البيع" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service2_desc_lang", "- ضمان عامين\r\n- توصيل إلى موقعك\r\n- التركيب والتشغيل\r\n- التدريب على طريقة الإستخدام\r\n- الصيانة\r\n- توفير قطع الغيار " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "الخدمات", "service3", 0, "Guaranteed Safe & Secured" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service3_desc", " If anything (non-consumable) goes wrong, we will cover your loss" });

            _ = migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "DisplayName", "Key", "LastModifiedBy", "Order", "Type", "Value" },
                values: new object[,]
                {
                    { 43, "الخدمات", "service3_lang", null, 0, 0, "أمان وحماية مضمونة" },
                    { 44, "تفاصيل الخدمات", "service3_desc_lang", null, 0, 2, " في حال حدوث خلل تصنيع, فنحن متكفلون بتعويضك " }
                });

            _ = migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$q2FyrN1F.dRRVoM9wfmGs.g2n83kZL75n9tUl2yAxWUw.IYyu3k/a");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 43);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 44);

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "AdministrationRolePremissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Fk_DashboardAccessLevel", "Fk_DashboardAdministrationRole", "Fk_DashboardView" },
                values: new object[] { 0, 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardAccessLevelLang",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardAdministrationRoleLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardAdministrators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fk_DashboardAdministrationRole", "Fk_User" },
                values: new object[] { 0, 0 });

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 5,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 6,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 7,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 8,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 9,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 10,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 11,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 12,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 13,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 14,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 15,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 16,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "DashboardViewLang",
                keyColumn: "Id",
                keyValue: 17,
                column: "Fk_Source",
                value: 0);

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخصائص", "feature1", "AVAILABILITY" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature1_desc", "24 / 7 lockers at your service" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "الخصائص", "feature1_lang", 0, "الخدمة" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature1_desc_lang", 0, "24/7 الخزائن في خدمتك" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature2", "Non-contact" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature2_desc", "Intelligent lockers are hygienic and clean" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature2_lang", "بدون تلامس " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature2_desc_lang", "الخزائن الذكية صحية ونظيفة" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature3", "COST REDUCTION" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature3_desc", "Unneeded human presence" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature3_lang", "تكلفة أقل " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature3_desc_lang", "لا حاجة لوجود موظف إضافي" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature4", "Safety" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature4_desc", "Integrated camera surveillance as needed" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature4_lang", "الحماية" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Key", "Value" },
                values: new object[] { "feature4_desc_lang", "كاميرات مراقبة متكاملة حسب الطلب" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخدمات", "service1", "Rent or Buy?" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service1_desc", 2, "Our team will be glad to support you with this decision" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخدمات", "service1_lang", "إيجار أم شراء؟" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service1_desc_lang", 2, "سنكون سعداء بمساعدتك على اتخاذ القرار" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service2", "After Sale Service" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service2_desc", "- 2 years warranty\r\n- Delivery to your location\r\n- Installation\r\n- Staff training\r\n- Maintenance\r\n- Spare parts " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service2_lang", "خدمات ما بعد البيع" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service2_desc_lang", "- ضمان عامين\r\n- توصيل إلى موقعك\r\n- التركيب والتشغيل\r\n- التدريب على طريقة الإستخدام\r\n- الصيانة\r\n- توفير قطع الغيار " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service3", "Guaranteed Safe & Secured" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service3_desc", " If anything (non-consumable) goes wrong, we will cover your loss" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service3_lang", "أمان وحماية مضمونة" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Key", "Value" },
                values: new object[] { "service3_desc_lang", " في حال حدوث خلل تصنيع, فنحن متكفلون بتعويضك " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "slogan", "slider", 2, "Your Diamonds are in secured Lockers! " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "slogan", "slider_lang", "ألماساتك في خزائن آمنة!" });

            _ = migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$t6rSnG03afVisXM67zG5Y.co81XSFFe7nu9Qd21epFAqj.X6llclK");
        }
    }
}
