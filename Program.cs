﻿using System;

namespace ConsoleApp2_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //در اینجا کلمه پلیس هولدر اشتباها به جای عبارت
            //custom numeric format strings
            //به کار رفته است


            //double Amount = 123456.887654;//در متغیر ها صفر های بیمعنی نشون داده نمیشوند جز صفر خالی که معنای صفر میدهد

            //Console.WriteLine(Amount.ToString("0,0 - 00 - 000.00 - 00"));

            ////فرم دهی سفارشی اعداد با پلیس هولدر صفر . صفر به معنای عدد هست و به جای صفر که پلیس هولدر است اعدادی که در متغیر ما هستند جایگذاری میشوند و اگر تعداد صفر ها از ارقام بیشتر بود صفر های پلیس هولدر در جای اعداد ناموجود قرار میگیرند 
            ////رنج اعداد از سمت چپی ترین صفر تا سمت راستی ترین صفر هست
            ////با این وجود برای اعداد سمت چپ جدا کننده اعداد اعشاری یا دسیمال این موضوع متفاوت است
            ////به این صورت که ما نمیدونیم چندین رقم عدد صحیح خواهیم داشت پس صفر های سمت چپ دسیمال به این صورت اند که
            ////اگر تعداد صفر ها از ارقام کمتر بود تمام ارقام نشون داده میشوند اگر صفر ها بیشتر بودند، صفر های اضافی هم پشت اعداد قرار میگیرند
            ////در سمت راست دسیمال هم چون تعداد ارقام اعشار مهم است ما باید مشخص کنیم چند تا
            ////پس ارقام فقط و فقط به تعداد صفر های سمت راست چاپ میشوند حتی اگر تعدادشان از صفر ها بیشتر بود یا خودشان صفر بودند
            //// با این وجود اگر صفر ها باز تعدادشان از ارقام سمت راست اعشار بیشتر بود به جای انها صفر چاپ میشود
            ////صفر قابلیت گرد کردن اعداد را دارد
            //// به ای صورت که اخرین رقم از سمت راست را با توجه به صفرهایش نگه میدارد و باقی اعداد بعد از ان را گرد کرده و به اخرین عدد نتیجه گرد شده را اضافه میکند
            ////جدا کننده هزار تایی اعداد , باید سمت چپ جدا کننده اعشار یا همان دسیمال باشد و برای درست نشون دادن نتیجه باید در میان دو پلیس هولدر باشد 

            //double Amount2 = 123450.8805;
            //double Amount2 = 1230.8801;

            //Console.WriteLine(Amount2.ToString("(#)##-##.#-#-#"));

            ////شارپ مانند بالا هست با این تفاوت که اگر عددی برای پر کردن جای پلیس هولدر شارپ نباشد شارپ جای ان هیچ رقمی قرار نمیدهد
            ////نه تنها شارپ صفر های بی معنا را نشان نمیدهد بلکه صفر هایی را که ارزش صفر دارند را هم نشان نمیدهد 

            //----------------------------------------------------------------------------------------------
            //double a = 0.4;
            //Console.WriteLine(a.ToString("0"));
            //Console.WriteLine(a.ToString("#"));

            double Amount3 = 20000;

            int Amount4 = 20000;

            Console.WriteLine(Amount3.ToString("#,0 rial"));//چرا شارپ صفر ؟چرا صفر صفر یا شارپ شارپ نه؟ چون امکان داره تک رقمی باشه و صفر صفر یک صفر میزاره و امکان دارد اعشاری باشد و صفرش را شارپ بپرونه

            Console.WriteLine(ToStringClass.ToRial(Amount3));

            Console.WriteLine(ToStringClass.ToRial(987654321));//تو ريا ل متد هست

            Console.WriteLine(Amount3.ToRialExMe());//تو ریا ل اکس مه یک متد اکستنشن است و علامتش متفاوت است 

            //Console.WriteLine(Amount4.ToRialExMe());//خطا میدهد چون فقط مال دابل ها هست این متد . اکستنشن شده است برای دابل ها

            Console.WriteLine(555.65.ToRialExMe());//چرا اعشاری نوشتیم ؟تا بدونه دابل هست نه اینت چون کامپایلر به صورت خودکار عدد بدون اعشار را اینت در نظر میگیرد اگر که خودمان نوعش را مشخص نکنیم

            //Console.WriteLine(556.ToRialExMe());

            Console.WriteLine(556.00.ToRialExMe());

            Console.WriteLine(DateTime.Now.ToShamsi());

            Console.WriteLine(DateTime.Now.MiladiSho());
        }
    }
}
