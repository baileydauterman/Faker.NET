﻿using Faker.NET.Common;
using Faker.NET.Common.Person;
using Faker.NET.Interfaces.Definitions;

namespace Faker.NET.Locales.AR.Data
{
    internal class ArPersonData : IFakerPersonDefinition
    {
        public string[] BioPart => throw new NotImplementedException();

        public Func<IFakerPersonDefinition, string>[] BioPattern => throw new NotImplementedException();

        public string[] BioSupporter => throw new NotImplementedException();

        public SexSpecificValues<string> FirstName { get; } = new SexSpecificValues<string>
        {
            Unisex = new string[] {
    "آسر",
    "أحمد",
    "أركان",
    "أسامة",
    "أسعد",
    "أشرف",
    "أكرم",
    "أليف",
    "أمان",
    "أمجد",
    "أمير",
    "أمين",
    "أنس",
    "أنيس",
    "أوس",
    "أيمن",
    "إسلام",
    "إياد",
    "إياس",
    "إيهاب",
    "القاسم",
    "المقداد",
    "باسل",
    "باسم",
    "بدر",
    "بدران",
    "بركات",
    "برهان",
    "بسام",
    "بسيم",
    "بشار",
    "بلال",
    "بلبل",
    "بليغ",
    "بندر",
    "بهيج",
    "تميم",
    "توفيق",
    "تيسير",
    "ثابت",
    "جابر",
    "جاد",
    "جاسر",
    "جاسم",
    "جبريل",
    "جسور",
    "جعفر",
    "جلال",
    "جليل",
    "جمال",
    "جمعة",
    "جميل",
    "جهاد",
    "جوهر",
    "حاتم",
    "حاجب",
    "حارث",
    "حازم",
    "حافظ",
    "حامد",
    "حبيب",
    "حذيفة",
    "حسام",
    "حسان",
    "حسني",
    "حسون",
    "حطاب",
    "حفيظ",
    "حكيم",
    "حلمي",
    "حليم",
    "حمدان",
    "حمدي",
    "حمزة",
    "حمودة",
    "حميد",
    "حيدرة",
    "خالد",
    "خباب",
    "خلدون",
    "خليل",
    "خيري",
    "داوود",
    "دريد",
    "ديسم",
    "ذاكر",
    "رؤوف",
    "رائد",
    "رائف",
    "رابح",
    "راتب",
    "راسم",
    "راشد",
    "راغب",
    "راكان",
    "رامز",
    "رامي",
    "ربيع",
    "رتيب",
    "رجب",
    "رزق",
    "رسلان",
    "رشاد",
    "رشدي",
    "رشيد",
    "رضا",
    "رضوان",
    "رعد",
    "رفيع",
    "رفيق",
    "ركان",
    "رمزي",
    "رمضان",
    "رنيم",
    "رياض",
    "ريان",
    "زاهر",
    "زياد",
    "زيدون",
    "زين الدين",
    "سالم",
    "سامح",
    "سامر",
    "سامي",
    "سراج",
    "سرحان",
    "سرمد",
    "سريج",
    "سعد",
    "سعيد",
    "سفيان",
    "سلامة",
    "سلمان",
    "سليم",
    "سماح",
    "سمير",
    "سهيل",
    "سيف",
    "شادي",
    "شاكر",
    "شريف",
    "شعبان",
    "شفيع",
    "شفيق",
    "شكري",
    "شكيب",
    "شمس الدين",
    "شهاب",
    "شوقي",
    "صابر",
    "صادق",
    "صبحي",
    "صبري",
    "صخر",
    "صداح",
    "صدقي",
    "صفوان",
    "صقر",
    "صلاح",
    "صهيب",
    "ضياء",
    "طارق",
    "طاهر",
    "طلال",
    "طيب",
    "ظافر",
    "عادل",
    "عارف",
    "عاشور",
    "عاصم",
    "عاصي",
    "عاطف",
    "عامر",
    "عباس",
    "عثمان",
    "عجمي",
    "عدلان",
    "عدلي",
    "عدنان",
    "عدي",
    "عرفات",
    "عرفان",
    "عز الدين",
    "عزام",
    "عزمي",
    "عزيز",
    "عطا",
    "عطية",
    "عفيف",
    "علاء",
    "علوي",
    "علي",
    "عماد",
    "عمار",
    "عمر",
    "عمران",
    "عياض",
    "غازي",
    "غانم",
    "غسان",
    "غفار",
    "غيث",
    "فؤاد",
    "فائز",
    "فاخر",
    "فادي",
    "فارس",
    "فاروق",
    "فاضل",
    "فاكر",
    "فتاح",
    "فتحي",
    "فخري",
    "فراس",
    "فرج",
    "فرحات",
    "فريد",
    "فضل",
    "فضيل",
    "فكري",
    "فهد",
    "فهمي",
    "فواز",
    "فوزي",
    "فيصل",
    "قاسم",
    "قدري",
    "قيس",
    "كاظم",
    "كامل",
    "كرم",
    "كمال",
    "لبيب",
    "لطفي",
    "ليث",
    "مأمون",
    "مؤمن",
    "مؤنس",
    "ماجد",
    "مازن",
    "مبارك",
    "مبروك",
    "مجاهد",
    "مجد",
    "مجدي",
    "مجيد",
    "محجوب",
    "محرز",
    "محسن",
    "محفوظ",
    "محمد",
    "محمود",
    "مختار",
    "مخلص",
    "مراد",
    "مرتضى",
    "مرزوق",
    "مرسي",
    "مرشد",
    "مرعي",
    "مروان",
    "مستعين",
    "مسعد",
    "مسعود",
    "مصطفى",
    "مصعب",
    "مصلح",
    "مطيع",
    "معاذ",
    "معتز",
    "معز",
    "معين",
    "مفتاح",
    "مقداد",
    "ممتاز",
    "ممدوح",
    "منتصر",
    "منذر",
    "منصف",
    "منصور",
    "منعم",
    "منيب",
    "منير",
    "مهدي",
    "مهند",
    "مهيب",
    "ناجح",
    "ناجي",
    "نادر",
    "ناصح",
    "ناصر",
    "ناصف",
    "ناظم",
    "نافع",
    "نبيل",
    "نجيب",
    "نديم",
    "نزار",
    "نزيه",
    "نسيم",
    "نصحي",
    "نصر",
    "نضال",
    "نعمان",
    "نعيم",
    "نهاد",
    "نور الدين",
    "نوري",
    "نوفل",
    "هاشم",
    "هاني",
    "هشام",
    "هيثم",
    "هيكل",
    "وائل",
    "واصف",
    "وجدي",
    "وديع",
    "وسام",
    "وسيم",
    "وصفي",
    "وليد",
    "ياسر",
    "ياسين",
    "يافع",
    "يامن",
    "يحيى",
            },
            Female = new string[] {
    "اروي",
    "بتول",
    "براءة",
    "بلسم",
    "خلود",
    "ريم",
    "عنود",
    "عوضية",
    "فاطمه",
    "نوف",
                },
            Male = new string[] {
    "آسر",
    "أحمد",
    "أركان",
    "أسامة",
    "أسعد",
    "أشرف",
    "أكرم",
    "أليف",
    "أمان",
    "أمجد",
    "أمير",
    "أمين",
    "أنس",
    "أنيس",
    "أوس",
    "أيمن",
    "إسلام",
    "إياد",
    "إياس",
    "إيهاب",
    "ابراهيم",
    "القاسم",
    "المقداد",
    "باسل",
    "باسم",
    "بدر",
    "بدران",
    "بركات",
    "برهان",
    "بسام",
    "بسيم",
    "بشار",
    "بلال",
    "بلبل",
    "بليغ",
    "بندر",
    "بهيج",
    "تميم",
    "توفيق",
    "تيسير",
    "ثابت",
    "جابر",
    "جاد",
    "جاسر",
    "جاسم",
    "جبريل",
    "جسور",
    "جعفر",
    "جلال",
    "جليل",
    "جمال",
    "جمعة",
    "جميل",
    "جهاد",
    "جوهر",
    "حاتم",
    "حاجب",
    "حارث",
    "حازم",
    "حافظ",
    "حامد",
    "حبيب",
    "حذيفة",
    "حسام",
    "حسان",
    "حسن",
    "حسني",
    "حسون",
    "حطاب",
    "حفيظ",
    "حكيم",
    "حلمي",
    "حليم",
    "حمدان",
    "حمدي",
    "حمزة",
    "حمودة",
    "حميد",
    "حيدرة",
    "خالد",
    "خباب",
    "خلدون",
    "خليل",
    "خيري",
    "داوود",
    "دريد",
    "ديسم",
    "ذاكر",
    "رؤوف",
    "رائد",
    "رائف",
    "رابح",
    "راتب",
    "راسم",
    "راشد",
    "راغب",
    "راكان",
    "رامز",
    "رامي",
    "ربيع",
    "رتيب",
    "رجب",
    "رزق",
    "رسلان",
    "رشاد",
    "رشدي",
    "رشيد",
    "رضا",
    "رضوان",
    "رعد",
    "رفيع",
    "رفيق",
    "ركان",
    "رمزي",
    "رمضان",
    "رنيم",
    "رياض",
    "ريان",
    "زاهر",
    "زياد",
    "زيدون",
    "زين الدين",
    "سالم",
    "سامح",
    "سامر",
    "سامي",
    "سراج",
    "سرحان",
    "سرمد",
    "سريج",
    "سعد",
    "سعيد",
    "سفيان",
    "سلامة",
    "سلمان",
    "سليم",
    "سماح",
    "سمير",
    "سهيل",
    "سيف",
    "شادي",
    "شاكر",
    "شريف",
    "شعبان",
    "شفيع",
    "شفيق",
    "شكري",
    "شكيب",
    "شمس الدين",
    "شهاب",
    "شوقي",
    "صابر",
    "صادق",
    "صبحي",
    "صبري",
    "صخر",
    "صداح",
    "صدقي",
    "صفوان",
    "صقر",
    "صلاح",
    "صهيب",
    "ضياء",
    "طارق",
    "طاهر",
    "طلال",
    "طيب",
    "ظافر",
    "عادل",
    "عارف",
    "عاشور",
    "عاصم",
    "عاصي",
    "عاطف",
    "عامر",
    "عباس",
    "عبد الله",
    "عثمان",
    "عجمي",
    "عدلان",
    "عدلي",
    "عدنان",
    "عدي",
    "عرفات",
    "عرفان",
    "عز الدين",
    "عزام",
    "عزمي",
    "عزيز",
    "عطا",
    "عطية",
    "عفيف",
    "علاء",
    "علوي",
    "على",
    "علي",
    "عماد",
    "عمار",
    "عمر",
    "عمران",
    "عياض",
    "غازي",
    "غانم",
    "غسان",
    "غفار",
    "غيث",
    "فؤاد",
    "فائز",
    "فاخر",
    "فادي",
    "فارس",
    "فاروق",
    "فاضل",
    "فاكر",
    "فتاح",
    "فتحي",
    "فخري",
    "فراس",
    "فرج",
    "فرحات",
    "فريد",
    "فضل",
    "فضيل",
    "فكري",
    "فهد",
    "فهمي",
    "فواز",
    "فوزي",
    "فيصل",
    "قاسم",
    "قدري",
    "قيس",
    "كاظم",
    "كامل",
    "كرم",
    "كمال",
    "لبيب",
    "لطفي",
    "ليث",
    "مأمون",
    "مؤمن",
    "مؤنس",
    "ماجد",
    "مازن",
    "مبارك",
    "مبروك",
    "مجاهد",
    "مجد",
    "مجدي",
    "مجيد",
    "محجوب",
    "محرز",
    "محسن",
    "محفوظ",
    "محمد",
    "محمود",
    "مختار",
    "مخلص",
    "مراد",
    "مرتضى",
    "مرزوق",
    "مرسي",
    "مرشد",
    "مرعي",
    "مروان",
    "مستعين",
    "مسعد",
    "مسعود",
    "مصطفى",
    "مصعب",
    "مصلح",
    "مطيع",
    "معاذ",
    "معتز",
    "معز",
    "معين",
    "مفتاح",
    "مقداد",
    "ممتاز",
    "ممدوح",
    "منتصر",
    "منذر",
    "منصف",
    "منصور",
    "منعم",
    "منيب",
    "منير",
    "مهدي",
    "مهند",
    "مهيب",
    "ناجح",
    "ناجي",
    "نادر",
    "ناصح",
    "ناصر",
    "ناصف",
    "ناظم",
    "نافع",
    "نبيل",
    "نجيب",
    "نديم",
    "نزار",
    "نزيه",
    "نسيم",
    "نصحي",
    "نصر",
    "نضال",
    "نعمان",
    "نعيم",
    "نهاد",
    "نور الدين",
    "نوري",
    "نوفل",
    "هاشم",
    "هاني",
    "هشام",
    "هيثم",
    "هيكل",
    "وائل",
    "واصف",
    "وجدي",
    "وديع",
    "وسام",
    "وسيم",
    "وصفي",
    "وليد",
    "ياسر",
    "ياسين",
    "يافع",
    "يامن",
    "يحيى",
                }
        };
        public string[] Gender => throw new NotImplementedException();

        public string[] JobArea => throw new NotImplementedException();

        public string[] JobDescriptor => throw new NotImplementedException();

        public Func<string>[] JobTitlePattern => throw new NotImplementedException();

        public string[] JobType => throw new NotImplementedException();

        public SexSpecificValues<string> LastName { get; } = new SexSpecificValues<string>
        {
            Unisex = new string[] {
    "ادريس",
    "الأشراف",
    "البشيري",
    "الحجيج",
    "الحمامي",
    "الخليفي",
    "الدرقاش",
    "الدنوني",
    "الرصاع",
    "الرقيق",
    "الزوابي",
    "السقا",
    "السقاط",
    "الشتيوي",
    "الشريف",
    "الشيباني",
    "الصغير",
    "الصفار",
    "الطريقي",
    "الطويل",
    "الع لويني",
    "العطار",
    "العلاني",
    "العلايمي",
    "العنابي",
    "العواني",
    "الغربي",
    "القلال",
    "القلشاني",
    "الكافي",
    "الكراي",
    "المحجوب",
    "المدقي",
    "المنيف",
    "المولدي",
    "النابلي",
    "النجار",
    "النخلي",
    "النفطي",
    "النفير",
    "النقاش",
    "الوحيشي",
    "بن حسين",
    "بن حمودة",
    "بن عاشور",
    "بن عبد السلام",
    "بن عبد الكريم",
    "بن عبدالله",
    "بن عثمان",
    "بن عمر",
    "بنسلامة",
    "بودوارة",
    "بوديبة",
    "بوهاها",
    "تومي",
    "جابالله",
    "جاوحدو",
    "جراد",
    "خنفير",
    "زروق",
    "زقية",
    "سعيد",
    "سويس",
    "شقرون",
    "شنيق",
    "عاشور",
    "عطالله",
    "عظومة",
    "عنون",
    "غويلة",
    "فقوسة",
    "لخشين",
    "نيفر",
    "هذيل",
    "همدان",
    "يافع",
  }
        };

        public WeightedList<Func<IFakerPersonDefinition, Sex, string>> LastNamePattern { get; } = new WeightedList<Func<IFakerPersonDefinition, Sex, string>>(new Dictionary<Func<IFakerPersonDefinition, Sex, string>, int>
        {
            { (person, sex) => $"{person.LastName.Get(sex)}", 1 }
        });

        public SexSpecificValues<string> MiddleName => throw new NotImplementedException();

        public WeightedList<Func<string>> Name => throw new NotImplementedException();

        public SexSpecificValues<string> Prefix { get; } = new SexSpecificValues<string>
        {
            Unisex = new string[] { "آنسة", "بروفيسور", "دكتور", "سيد", "سيدة" },
            Female = new string[] { "آنسة", "بروفيسور", "دكتور", "سيدة" },
            Male = new string[] { "بروفيسور", "دكتور", "سيد" },
        };

        public string[] Suffix { get; } = { "المحترم", "المبجل", "حفظه الله", "الموقر" };

        public string[] ZodiacSign => throw new NotImplementedException();
    }
}
