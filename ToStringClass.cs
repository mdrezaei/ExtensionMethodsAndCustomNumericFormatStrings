using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;//مورد نیاز را یوزینگ میکنیم


namespace ConsoleApp2_ExtensionMethods
{
    public static class ToStringClass
    {
        //متد های کلاس های استاتیک باید و باید استاتیک باشند

        public static string ToRial(double Amount)
        {
            return Amount.ToString("#,0 Rial(Shit)");
        }

        public static string ToRialExMe(this double Amount)//این یک اکستنشن متد است با کلمه کلیدی دیس که میشود این متد برای متغیر های دابل است. اکستنشن متد باید در یک کلاس استاتیک باشد و خود متد هم استاتیک باشد 
        {
            return Amount.ToString("#,0 Rial(Shit)");
        }

        //میخوایم تاریخ شمسی بگیریم با میلادی

        public static string ToShamsi(this DateTime Value)//دیس چه؟ دیس هر متغیری که میخواهیم بگیریم تا کاری را روی ان انجام دهیم اینجا دیت تایم
        {
            PersianCalendar PersianC = new PersianCalendar();

            return PersianC.GetYear(Value) + "/" + PersianC.GetMonth(Value).ToString("00") + "/" +
                   PersianC.GetDayOfMonth(Value).ToString("00");//چرا نوشتیم ولیو نه دیت تایم . نو؟چون باید متغیری بگیریم که این متد را در ادامش دات تو بکنیم . پس باید از ان متغیر استفاده بکنیم.حالا میتونه تاریخ همین لحظه باشه میتونه یک تاریخ دیگه باشه ما میخوایم هر تاریخی رو تبدیل کنیم 
       
        }

        public static string MiladiSho (this DateTime Value)
        {
            GregorianCalendar MiladiC = new GregorianCalendar();

            return MiladiC.GetYear(Value).ToString("0000") + "/" + MiladiC.GetMonth(Value).ToString("00") + "/" +
                   MiladiC.GetDayOfMonth(Value).ToString("00");

        }

    }
}
