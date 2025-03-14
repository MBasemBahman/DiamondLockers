﻿using Microsoft.EntityFrameworkCore.Migrations;



namespace DevelopmentDAL.Migrations
{
    /// <inheritdoc />
    public partial class footer : Migration
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
                keyValue: 17,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "بيانات التواصل", "footerTitle", "Get in touch" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "بيانات التواصل", "footerTitle_lang", "تواصل معنا" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "بيانات التواصل", "footerDesc", 2, "Contact us today. Let us help you better manage your security. " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "بيانات التواصل", "footerDesc_lang", 2, " اتصل بنا اليوم. لنساعدك فى تحسين إدارة أماناتك. " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "بيانات التواصل", "emailTitle", "E-Mail" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "بيانات التواصل", "emailTitle_lang", "الإيميل" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "بيانات التواصل", "emailVal", "support@diamondlockers.com" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "بيانات التواصل", "addressTitle", "Headquarter" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "بيانات التواصل", "addressTitle_lang", "المقر الرئيسي" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "بيانات التواصل", "addressDesc", 2, "Riyadh,\r\nSaudi Arabia " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "بيانات التواصل", "addressDesc_lang", 2, "الرياض,\r\nالمملكة العربية السعودية" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formTypeTitle", "Type" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formTypeTitle_lang", "النوع" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formType1", "Individuals" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formType1_lang", "أفراد" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formType2", "Companies" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formType2_lang", "شركات" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "نموذج التواصل", "formNameTitle", 0, "Name" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formNameTitle_lang", "الاسم" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "نموذج التواصل", "formNameDesc", 0, "Your Name" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formNameDesc_lang", "أسمك" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "نموذج التواصل", "formPhoneTitle", 0, "Phone" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formPhoneTitle_lang", "الهاتف" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "نموذج التواصل", "formPhoneDesc", 0, "Your phone" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formPhoneDesc_lang", "رقم الهاتف" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "نموذج التواصل", "formEmailTitle", 0, "Email" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "نموذج التواصل", "formEmailTitle_lang", "البريد الإلكتروني" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "نموذج التواصل", "formEmailDesc", 0, "Your email" });

            _ = migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "DisplayName", "Key", "LastModifiedBy", "Order", "Type", "Value" },
                values: new object[,]
                {
                    { 45, "نموذج التواصل", "formEmailDesc_lang", null, 0, 0, "البريد الإلكتروني" },
                    { 46, "نموذج التواصل", "formServiceTitle", null, 0, 0, "Service" },
                    { 47, "نموذج التواصل", "formServiceTitle_lang", null, 0, 0, "الخدمه" },
                    { 48, "نموذج التواصل", "formService1", null, 0, 0, "Rent" },
                    { 49, "نموذج التواصل", "formService1_lang", null, 0, 0, "إيجار" },
                    { 50, "نموذج التواصل", "formService2", null, 0, 0, "Buy" },
                    { 51, "نموذج التواصل", "formService2_lang", null, 0, 0, "شراء" },
                    { 52, "نموذج التواصل", "formService3", null, 0, 0, "Enquiry" },
                    { 53, "نموذج التواصل", "formService3_lang", null, 0, 0, "إستفسار" },
                    { 54, "نموذج التواصل", "formMessageTitle", null, 0, 0, "Message" },
                    { 55, "نموذج التواصل", "formMessageTitle_lang", null, 0, 0, "الرسالة" },
                    { 56, "نموذج التواصل", "formMessageDesc", null, 0, 0, "Type your message" },
                    { 57, "نموذج التواصل", "formMessageDesc_lang", null, 0, 0, "اكتب رسالتك" },
                    { 58, "نموذج التواصل", "formSubmit", null, 0, 0, "Submit" },
                    { 59, "نموذج التواصل", "formSubmit_lang", null, 0, 0, "إرسال" },
                    { 60, "نموذج التواصل", "formSuccessMsg", null, 0, 0, "The message was sent successfully!" },
                    { 61, "نموذج التواصل", "formSuccessMsg_lang", null, 0, 0, "تم إرسال الرسالة بنجاح!" },
                    { 62, "نموذج التواصل", "formErrorMsg", null, 0, 0, "Something is wrong please try again!" },
                    { 63, "نموذج التواصل", "formErrorMsg_lang", null, 0, 0, "هناك خطأ ما يرجى المحاولة مرة أخرى!" },
                    { 64, "نموذج التواصل", "formIncompleteMsg", null, 0, 0, "Please complete the form!" },
                    { 65, "نموذج التواصل", "formIncompleteMsg_lang", null, 0, 0, "يرجى ملء النموذج!" },
                    { 66, "نموذج التواصل", "copyright", null, 0, 0, "Copyright. All Rights Reserved" },
                    { 67, "نموذج التواصل", "copyright_lang", null, 0, 0, "حقوق النشر. كل الحقوق محفوظة" },
                    { 68, "الخصائص", "feature1", null, 0, 0, "AVAILABILITY" },
                    { 69, "تفاصيل الخصائص", "feature1_desc", null, 0, 0, "24 / 7 lockers at your service" },
                    { 70, "الخصائص", "feature1_lang", null, 0, 0, "الخدمة" },
                    { 71, "تفاصيل الخصائص", "feature1_desc_lang", null, 0, 0, "24/7 الخزائن في خدمتك" },
                    { 72, "الخصائص", "feature2", null, 0, 0, "Non-contact" },
                    { 73, "تفاصيل الخصائص", "feature2_desc", null, 0, 0, "Intelligent lockers are hygienic and clean" },
                    { 74, "الخصائص", "feature2_lang", null, 0, 0, "بدون تلامس " },
                    { 75, "تفاصيل الخصائص", "feature2_desc_lang", null, 0, 0, "الخزائن الذكية صحية ونظيفة" },
                    { 76, "الخصائص", "feature3", null, 0, 0, "COST REDUCTION" },
                    { 77, "تفاصيل الخصائص", "feature3_desc", null, 0, 0, "Unneeded human presence" },
                    { 78, "الخصائص", "feature3_lang", null, 0, 0, "تكلفة أقل " },
                    { 79, "تفاصيل الخصائص", "feature3_desc_lang", null, 0, 0, "لا حاجة لوجود موظف إضافي" },
                    { 80, "الخصائص", "feature4", null, 0, 0, "Safety" },
                    { 81, "تفاصيل الخصائص", "feature4_desc", null, 0, 0, "Integrated camera surveillance as needed" },
                    { 82, "الخصائص", "feature4_lang", null, 0, 0, "الحماية" },
                    { 83, "تفاصيل الخصائص", "feature4_desc_lang", null, 0, 0, "كاميرات مراقبة متكاملة حسب الطلب" },
                    { 84, "الخدمات", "service1", null, 0, 0, "Rent or Buy?" },
                    { 85, "تفاصيل الخدمات", "service1_desc", null, 0, 2, "Our team will be glad to support you with this decision" },
                    { 86, "الخدمات", "service1_lang", null, 0, 0, "إيجار أم شراء؟" },
                    { 87, "تفاصيل الخدمات", "service1_desc_lang", null, 0, 2, "سنكون سعداء بمساعدتك على اتخاذ القرار" },
                    { 88, "الخدمات", "service2", null, 0, 0, "After Sale Service" },
                    { 89, "تفاصيل الخدمات", "service2_desc", null, 0, 2, "- 2 years warranty\r\n- Delivery to your location\r\n- Installation\r\n- Staff training\r\n- Maintenance\r\n- Spare parts " },
                    { 90, "الخدمات", "service2_lang", null, 0, 0, "خدمات ما بعد البيع" },
                    { 91, "تفاصيل الخدمات", "service2_desc_lang", null, 0, 2, "- ضمان عامين\r\n- توصيل إلى موقعك\r\n- التركيب والتشغيل\r\n- التدريب على طريقة الإستخدام\r\n- الصيانة\r\n- توفير قطع الغيار " },
                    { 92, "الخدمات", "service3", null, 0, 0, "Guaranteed Safe & Secured" },
                    { 93, "تفاصيل الخدمات", "service3_desc", null, 0, 2, " If anything (non-consumable) goes wrong, we will cover your loss" },
                    { 94, "الخدمات", "service3_lang", null, 0, 0, "أمان وحماية مضمونة" },
                    { 95, "تفاصيل الخدمات", "service3_desc_lang", null, 0, 2, " في حال حدوث خلل تصنيع, فنحن متكفلون بتعويضك " }
                });

            _ = migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$A5KZfr9fHH/K6.tSsmTTwuZgbXauPpO2QbdKV64z7QYC389W2Jfe.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 45);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 46);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 47);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 48);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 49);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 50);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 51);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 52);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 53);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 54);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 55);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 56);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 57);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 58);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 59);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 60);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 61);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 62);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 63);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 64);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 65);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 66);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 67);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 68);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 69);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 70);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 71);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 72);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 73);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 74);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 75);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 76);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 77);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 78);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 79);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 80);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 81);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 82);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 83);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 84);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 85);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 86);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 87);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 88);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 89);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 90);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 91);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 92);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 93);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 94);

            _ = migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 95);

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
                keyValue: 17,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخصائص", "feature1", "AVAILABILITY" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature1_desc", "24 / 7 lockers at your service" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "الخصائص", "feature1_lang", 0, "الخدمة" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature1_desc_lang", 0, "24/7 الخزائن في خدمتك" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخصائص", "feature2", "Non-contact" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature2_desc", "Intelligent lockers are hygienic and clean" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخصائص", "feature2_lang", "بدون تلامس " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature2_desc_lang", "الخزائن الذكية صحية ونظيفة" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخصائص", "feature3", "COST REDUCTION" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature3_desc", 0, "Unneeded human presence" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "الخصائص", "feature3_lang", 0, "تكلفة أقل " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature3_desc_lang", "لا حاجة لوجود موظف إضافي" });

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
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature4_desc", "Integrated camera surveillance as needed" });

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
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "تفاصيل الخصائص", "feature4_desc_lang", "كاميرات مراقبة متكاملة حسب الطلب" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخدمات", "service1", "Rent or Buy?" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service1_desc", 2, "Our team will be glad to support you with this decision" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخدمات", "service1_lang", "إيجار أم شراء؟" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service1_desc_lang", 2, "سنكون سعداء بمساعدتك على اتخاذ القرار" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخدمات", "service2", "After Sale Service" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service2_desc", 2, "- 2 years warranty\r\n- Delivery to your location\r\n- Installation\r\n- Staff training\r\n- Maintenance\r\n- Spare parts " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخدمات", "service2_lang", "خدمات ما بعد البيع" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service2_desc_lang", 2, "- ضمان عامين\r\n- توصيل إلى موقعك\r\n- التركيب والتشغيل\r\n- التدريب على طريقة الإستخدام\r\n- الصيانة\r\n- توفير قطع الغيار " });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخدمات", "service3", "Guaranteed Safe & Secured" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service3_desc", 2, " If anything (non-consumable) goes wrong, we will cover your loss" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DisplayName", "Key", "Value" },
                values: new object[] { "الخدمات", "service3_lang", "أمان وحماية مضمونة" });

            _ = migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DisplayName", "Key", "Type", "Value" },
                values: new object[] { "تفاصيل الخدمات", "service3_desc_lang", 2, " في حال حدوث خلل تصنيع, فنحن متكفلون بتعويضك " });

            _ = migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$q2FyrN1F.dRRVoM9wfmGs.g2n83kZL75n9tUl2yAxWUw.IYyu3k/a");
        }
    }
}
