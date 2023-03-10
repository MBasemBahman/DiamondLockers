using Entities.DBModels.SettingModels;

namespace ModelBuilderConfig.Configurations.SettingModels
{
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            int id = 1;

            #region Header
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "home",
                Value = "Home",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "home_lang",
                Value = "الرئيسية",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "features",
                Value = "Features",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "features_lang",
                Value = "الخدمات",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "services",
                Value = "Services",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "services_lang",
                Value = "الخصائص",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "about",
                Value = "About Us",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "about_lang",
                Value = "عن دايموند لوكرز",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "products",
                Value = "Products",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "products_lang",
                Value = "المنتجات",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "contact",
                Value = "Contact Us",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "contact_lang",
                Value = "إتصل بنا",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "culture",
                Value = "AR",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "culture_lang",
                Value = "EN",
                DisplayName = "القائمه الرئيسية",
                Type = SettingTypeEnum.Input
            });

            #endregion

            #region Slider
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "slider",
                Value = "Your Diamonds are in secured Lockers! ",
                DisplayName = "slogan",
                Type = SettingTypeEnum.TextArea
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "slider_lang",
                Value = "ألماساتك في خزائن آمنة!",
                DisplayName = "slogan",
                Type = SettingTypeEnum.TextArea
            });

            #endregion

            #region Footer

            #region footer text

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "footerTitle",
                Value = "Get in touch",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "footerTitle_lang",
                Value = "تواصل معنا",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "footerDesc",
                Value = "Contact us today. Let us help you better manage your security. ",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.TextArea
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "footerDesc_lang",
                Value = " اتصل بنا اليوم. لنساعدك فى تحسين إدارة أماناتك. ",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.TextArea
            });
            #endregion

            #region Email
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "emailTitle",
                Value = "E-Mail",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "emailTitle_lang",
                Value = "الإيميل",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "emailVal",
                Value = "support@diamondlockers.com",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.Input
            });
            #endregion

            #region Address
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "addressTitle",
                Value = "Headquarter",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "addressTitle_lang",
                Value = "المقر الرئيسي",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "addressDesc",
                Value = "Riyadh,\r\nSaudi Arabia ",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.TextArea
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "addressDesc_lang",
                Value = "الرياض,\r\nالمملكة العربية السعودية",
                DisplayName = "بيانات التواصل",
                Type = SettingTypeEnum.TextArea
            });
            #endregion

            #region Form
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formTypeTitle",
                Value = "Type",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formTypeTitle_lang",
                Value = "النوع",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formType1",
                Value = "Individuals",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formType1_lang",
                Value = "أفراد",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formType2",
                Value = "Companies",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formType2_lang",
                Value = "شركات",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formNameTitle",
                Value = "Name",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formNameTitle_lang",
                Value = "الاسم",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formNameDesc",
                Value = "Your Name",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formNameDesc_lang",
                Value = "أسمك",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formPhoneTitle",
                Value = "Phone",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formPhoneTitle_lang",
                Value = "الهاتف",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formPhoneDesc",
                Value = "Your phone",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formPhoneDesc_lang",
                Value = "رقم الهاتف",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formEmailTitle",
                Value = "Email",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formEmailTitle_lang",
                Value = "البريد الإلكتروني",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formEmailDesc",
                Value = "Your email",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formEmailDesc_lang",
                Value = "البريد الإلكتروني",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formServiceTitle",
                Value = "Service",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formServiceTitle_lang",
                Value = "الخدمه",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formService1",
                Value = "Rent",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formService1_lang",
                Value = "إيجار",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formService2",
                Value = "Buy",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formService2_lang",
                Value = "شراء",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formService3",
                Value = "Enquiry",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formService3_lang",
                Value = "إستفسار",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formMessageTitle",
                Value = "Message",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formMessageTitle_lang",
                Value = "الرسالة",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formMessageDesc",
                Value = "Type your message",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formMessageDesc_lang",
                Value = "اكتب رسالتك",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formSubmit",
                Value = "Submit",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formSubmit_lang",
                Value = "إرسال",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formSuccessMsg",
                Value = "The message was sent successfully!",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formSuccessMsg_lang",
                Value = "تم إرسال الرسالة بنجاح!",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formErrorMsg",
                Value = "Something is wrong please try again!",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formErrorMsg_lang",
                Value = "هناك خطأ ما يرجى المحاولة مرة أخرى!",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formIncompleteMsg",
                Value = "Please complete the form!",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "formIncompleteMsg_lang",
                Value = "يرجى ملء النموذج!",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "copyright",
                Value = "Copyright. All Rights Reserved",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "copyright_lang",
                Value = "حقوق النشر. كل الحقوق محفوظة",
                DisplayName = "نموذج التواصل",
                Type = SettingTypeEnum.Input
            });

            #endregion

            #endregion

            #region features

            #region feature1
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature1",
                Value = "AVAILABILITY",
                DisplayName = "الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature1_desc",
                Value = "24 / 7 lockers at your service",
                DisplayName = "تفاصيل الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature1_lang",
                Value = "الخدمة",
                DisplayName = "الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature1_desc_lang",
                Value = "24/7 الخزائن في خدمتك",
                DisplayName = "تفاصيل الخصائص",
                Type = SettingTypeEnum.Input
            });
            #endregion

            #region feature2
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature2",
                Value = "Non-contact",
                DisplayName = "الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature2_desc",
                Value = "Intelligent lockers are hygienic and clean",
                DisplayName = "تفاصيل الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature2_lang",
                Value = "بدون تلامس ",
                DisplayName = "الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature2_desc_lang",
                Value = "الخزائن الذكية صحية ونظيفة",
                DisplayName = "تفاصيل الخصائص",
                Type = SettingTypeEnum.Input
            });
            #endregion

            #region feature3
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature3",
                Value = "COST REDUCTION",
                DisplayName = "الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature3_desc",
                Value = "Unneeded human presence",
                DisplayName = "تفاصيل الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature3_lang",
                Value = "تكلفة أقل ",
                DisplayName = "الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature3_desc_lang",
                Value = "لا حاجة لوجود موظف إضافي",
                DisplayName = "تفاصيل الخصائص",
                Type = SettingTypeEnum.Input
            });
            #endregion

            #region feature4
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature4",
                Value = "Safety",
                DisplayName = "الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature4_desc",
                Value = "Integrated camera surveillance as needed",
                DisplayName = "تفاصيل الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature4_lang",
                Value = "الحماية",
                DisplayName = "الخصائص",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "feature4_desc_lang",
                Value = "كاميرات مراقبة متكاملة حسب الطلب",
                DisplayName = "تفاصيل الخصائص",
                Type = SettingTypeEnum.Input
            });
            #endregion


            #endregion

            #region services

            #region service1
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service1",
                Value = "Rent or Buy?",
                DisplayName = "الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service1_desc",
                Value = "Our team will be glad to support you with this decision",
                DisplayName = "تفاصيل الخدمات",
                Type = SettingTypeEnum.TextArea
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service1_lang",
                Value = "إيجار أم شراء؟",
                DisplayName = "الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service1_desc_lang",
                Value = "سنكون سعداء بمساعدتك على اتخاذ القرار",
                DisplayName = "تفاصيل الخدمات",
                Type = SettingTypeEnum.TextArea
            });
            #endregion

            #region service2
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service2",
                Value = "After Sale Service",
                DisplayName = "الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service2_desc",
                Value = "- 2 years warranty\r\n- Delivery to your location\r\n- Installation\r\n- Staff training\r\n- Maintenance\r\n- Spare parts ",
                DisplayName = "تفاصيل الخدمات",
                Type = SettingTypeEnum.TextArea
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service2_lang",
                Value = "خدمات ما بعد البيع",
                DisplayName = "الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service2_desc_lang",
                Value = "- ضمان عامين\r\n- توصيل إلى موقعك\r\n- التركيب والتشغيل\r\n- التدريب على طريقة الإستخدام\r\n- الصيانة\r\n- توفير قطع الغيار ",
                DisplayName = "تفاصيل الخدمات",
                Type = SettingTypeEnum.TextArea
            });
            #endregion

            #region service3
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service3",
                Value = "Guaranteed Safe & Secured",
                DisplayName = "الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service3_desc",
                Value = " If anything (non-consumable) goes wrong, we will cover your loss",
                DisplayName = "تفاصيل الخدمات",
                Type = SettingTypeEnum.TextArea
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service3_lang",
                Value = "أمان وحماية مضمونة",
                DisplayName = "الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "service3_desc_lang",
                Value = " في حال حدوث خلل تصنيع, فنحن متكفلون بتعويضك ",
                DisplayName = "تفاصيل الخدمات",
                Type = SettingTypeEnum.TextArea
            });
            #endregion

            #endregion

            #region Services Description

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesTitle",
                Value = "Our clients love the customizable feature and colors of their Diamond Lockers",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.TextArea
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesTitle_lang",
                Value = "يفضل عملاء دايموند لوكرز تخصيص ألوان و خصائص لخزائنهم",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.TextArea
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesDesc",
                Value = "Diamond Lockers allows you to keep reliable cloud-based records with multiple data options. Options include what is stored, who has access, and when to permit access.\r\n\r\nOur facial recognition self-service lockers have large-scale applications.\r\n\r\nBusiness usage includes: ",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.TextArea
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesDesc_lang",
                Value = "تستطيع فى دايموند لوكرز عن طريق عدة اختيارات تخص البيانات أن تحتفظ بالسجلات الموثقة للبيانات فى قاعدة البيانات الالكترونية. وتتمثل الاختبارات فى ما هو الشيئ الذي تم تخزينة, ومن يصل إليه, ومتى يسمح بالوصول إليه.\r\n\r\nإن خزائن الاستخدام الذاتي المدعمة بخاصية بصمة الوجه تتمتع بشريحة كبيرة من المستخدمين.\r\n\r\nعلى سبيل المثال: ",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.TextArea
            });


            #region Items

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem1",
                Value = "Apartment Buildings",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem1_lang",
                Value = "الشقق السكنية",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem2",
                Value = "Airports",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem2_lang",
                Value = "المطارات",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem3",
                Value = "Offices",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem3_lang",
                Value = "المكاتب",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem4",
                Value = "Universities",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem4_lang",
                Value = "الجامعات",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem5",
                Value = "Government Institutions",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem5_lang",
                Value = " المؤسسات الخكومية",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem6",
                Value = " Supermarkets",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem6_lang",
                Value = " السوبر ماركت",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem7",
                Value = "Shopping Malls",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem7_lang",
                Value = "المول",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem8",
                Value = " Recreation Centers",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "ServicesItem8_lang",
                Value = " مراكز الترفية",
                DisplayName = "شرح الخدمات",
                Type = SettingTypeEnum.Input
            });


            #endregion

            #endregion

            #region About

            #region Home

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "aboutDesc",
                Value = "Streamlined operations and better access control make Diamond Lockers 1st for intelligent locker storage management in Saudi Arabia. ",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.TextArea
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "aboutDesc_lang",
                Value = "إنسيابية العمليات والتحكم في الاستخدام هو ما يجعل دايموند لوكرز الأولي في إدارة الخزائن الذكية في المملكة العربية السعودية. ",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.TextArea
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "learnMoreBtn",
                Value = "Learn More",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "learnMoreBtn_lang",
                Value = "للمزيد",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "missionTitle",
                Value = "Mission",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "missionTitle_lang",
                Value = "مهمتنا",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "missionDesc",
                Value = "To offer accessible, safe, and efficient state-of-the-art technology without compromising customer service. ",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "missionDesc_lang",
                Value = " نقدم خزائن تتميز بسهولة الاستخدام والأمان والتقنية التكنولوجية الحديثة. ",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "visionTitle",
                Value = "Vision",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "visionTitle_lang",
                Value = "رؤيتنا",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "visionDesc",
                Value = "To be Saudi Arabia's number-one choice for innovation in intelligent storage locker solutions. ",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "visionDesc_lang",
                Value = " نكون الاختيار الأول فى المملكة العربية السعودية لحلول الخزائن الذكية.",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.Input
            });
            #endregion

            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "aboutLongDesc",
                Value = "\r\n\r\nIf you use traditional storage lockers with keys or passcodes, you may be losing money and putting your business at risk. When you consider the difference between standard and intelligent locker management, you will quickly understand how making the change can affect your bottom line.\r\n\r\nManual storage lockers are inefficient, costly, and unsanitary. Forgotten passcodes, labor costs, and misplaced keys are ongoing issues faced by companies still using manual storage methods.\r\n\r\nWelcome to Diamond Lockers, a password-free quick storage solution transforming the locker storage industry.\r\n\r\nWith traditional locker management, employees use passcodes, keys or badges, while tracking records help ensure security and safety. Keeping accurate records, preventing theft, and maintaining hygiene are ongoing challenges faced by companies using manual storage.\r\n\r\nIf you want to increase your company`s productivity and growth consider upgrading your system to Diamond Lockers.\r\n",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.TextArea
            });
            _ = builder.HasData(new Setting
            {
                Id = id++,
                Key = "aboutLongDesc_lang",
                Value = " \r\n\r\nهل سبق وفقدت مفتاح الخزنة التقليدية التي تستخدمها؟ أو كنت لا تتذكر كلمة المرور الخاصة بها؟ الأمر الذي يفقدك أموالك ومقتنياتك وقد يعرض عملك للخسارة!! عندما تستخدم الخزنة الذكية ستدرك الفرق الكبير بينها وبين الخزنة التقليدية والذي سيحدث فارق كبير فى حياتك.\r\n\r\nمن المشاكل التي تواجه مستخدمي الخزنة التقليدية أنها عديمة الكفاءة, ومكلفة, وغير عملية, فنسيان كلمة المرور, وتكلفة الاستخدام الباهظة, وفقدان المفتاح, جميعها أمور تعاني منها المؤسسات التي مازالت تستخدم الخزنة التقليدية.\r\n\r\nوالحل يكمن في الخزائن الذكية التي تعمل بدون مدخلات الحماية التقليدية وانما بالأساليب التكنولوجية الحديثة. والتي ستجدها هنا فى دايموند لوكرز.\r\n\r\nفعندما تستخدم الخزنة التقليدية فإنك تحتاج إلي أن يكون معك كلمة المرور أو المفتاح. فى حين أن وجود سجلات استخدام الكترونية تساعد فى تعزيز عنصري الأمان والحماية. فالاحتفاظ بسجلات الكترونية دقيقة يمنع السرقات ويقلل التلامس ونشر العدوى.\r\n\r\nاذا أردت زيادة إنتاجية ونمو شركتك, فعليك تطوير نظام الخزائن لديك إلي نظام خزائن دايموند لوكرز.\r\n",
                DisplayName = "عن الشركة",
                Type = SettingTypeEnum.TextArea
            });

            #endregion
        }
    }
}
