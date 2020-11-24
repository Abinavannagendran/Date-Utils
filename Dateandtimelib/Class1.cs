using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dateandtimelib
{
    
    public sealed class Period
    {
        private readonly int years, months, days, hours, minutes, seconds;

        public Period(int years, int months, int days,
                      int hours, int minutes, int seconds)
        {
            this.years = years;
            this.months = months;
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public static DateTime operator +(DateTime lhs, Period rhs)
        {
            
            return lhs.AddYears(rhs.years)
                      .AddMonths(rhs.months)
                      .AddDays(rhs.days)
                      .AddHours(rhs.hours)
                      .AddMinutes(rhs.minutes)
                      .AddSeconds(rhs.seconds);
        }
    }
    public sealed class Periodd
    {
        private readonly int years, months, days;

        public Periodd(int years, int months, int days)
                     
        {
            this.years = years;
            this.months = months;
            this.days = days;
            
        }

        public static DateTime operator +(DateTime lhs, Periodd rhs)
        { 
            return lhs.AddYears(rhs.years)
                      .AddMonths(rhs.months)
                      .AddDays(rhs.days);
        }
    }
    public static class Class1
    {
        public static string Dateconversion(DateTime date, String format) {          
            return date.ToString(format);
        }
        public static double DateSubtractDay(DateTime date1, DateTime date2)
        {            
            TimeSpan result = date2- (date1);
            double NrOfDays = result.TotalDays;
            return NrOfDays;
        }
       
        public static DateTime DateAddDayWithTime(DateTime first, Period second)
        {
            DateTime result = first + second;
            return result;
        }

        public static DateTime DateAddDayWithoutTime(DateTime first, Periodd second)
        {
            DateTime result = first + second;
            return result.Date;
        }
       public static string TimeLine(DateTime date2)
        {
            DateTime date1 = DateTime.Now.Date;
            if (date1 == date2)
            {
                return "istoday";
            }
            else if (date1 > date2)
            {

                return "ispastdate";
            }
            else if (date1 < date2)
            {

                return "isfuturedate";
            }
            else { return "Invalid"; }

        }
        
        
    }


}

