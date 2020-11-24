using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dateandtimelib;

namespace Dateandtime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2020, 11, 19).Date;
            DateTime dt2 = new DateTime(2021, 2, 2).Date;
            var date =  DateTime.Now;
            var datee = date.Date;
            // Font changing
            
            var date01 = Class1.Dateconversion(date, "MMMM,dd,yyyy");
            var date02 = Class1.Dateconversion(date, "dd/MM/yyyy");
            var date03 = Class1.Dateconversion(date, "dd-MMM-yyyy");
            var date04 = Class1.Dateconversion(date, "dd-MM-yy");
            var date05 = date.ToLongDateString();
            var date06 = date.ToShortDateString();            
            var date07 = Class1.DateSubtractDay(dt1,dt2);
           

            DateTime first = new DateTime(2000, 1, 1).Date;
            Period second = new Period(11, 2, 5, 10, 10, 11);
            Periodd secondd = new Periodd(11, 2, 5);

            var date08 = Class1.DateAddDayWithTime(first,second);//( DateTime(yyyy,MM, dd),Period(yy, MM, dd, hh, mm, ff));
            var date09 = Class1.DateAddDayWithoutTime(first, secondd);//( DateTime(yyyy,MM, dd),Period(yy, MM, dd));
            string date10 = Class1.TimeLine(dt1);//To check the time function like future past present

            Console.WriteLine("Today date as in system: " + datee);
            Console.WriteLine(date01);
            Console.WriteLine(date02);
            Console.WriteLine(date03);
            Console.WriteLine(date04);
            Console.WriteLine(date05);
            Console.WriteLine(date06);
            Console.WriteLine(date07);
            Console.WriteLine(date08);
            Console.WriteLine(date09);
            Console.WriteLine(date10);


            Console.ReadLine();
        }
    }
}
