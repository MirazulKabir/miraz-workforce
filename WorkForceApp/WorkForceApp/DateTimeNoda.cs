using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkForceApp
{
    public class DateTimeNoda
    {
        public String getInstantTime()
        {
            Instant s = SystemClock.Instance.Now;
            var dhaka = DateTimeZoneProviders.Tzdb["Asia/Bishkek"];
            var ZoneTime = s.InZone(dhaka);
            String da = String.Format("{0}", ZoneTime);
            String[] removeZone = da.Split(' ');
            String removedZone = removeZone[0];
            return removedZone;
        }

        public String getTimeDifference(String startTime, String endTime)
        {
            TimeSpan spendTime = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
            String spentTime = String.Format("{0}", spendTime);
            return spentTime;
        }

        public String getDayName(String date)
        {
            String[] splitDate = date.Split('-');
            int year = Int32.Parse(splitDate[0]);
            int month = Int32.Parse(splitDate[1]);
            int day = Int32.Parse(splitDate[2]);

            var birthDate = new DateTime(year, month, day);
            var thisYear = new DateTime(DateTime.Today.Year, birthDate.Month, birthDate.Day);

            var dayOfWeek = thisYear.DayOfWeek;
            String currentDay = String.Format("{0}", dayOfWeek);
            return currentDay;
        }

        public String getMonthName(String date)
        {
            String[] splitDate = date.Split('-');
            int month = Int32.Parse(splitDate[1]);
            String monthName = "";
            switch (month)
            {
                case 01:
                    monthName = "January";
                    break;
                case 02:
                    monthName = "February";
                    break;
                case 03:
                    monthName = "March";
                    break;
                case 04:
                    monthName = "April";
                    break;
                case 05:
                    monthName = "May";
                    break;
                case 06:
                    monthName = "June";
                    break;
                case 07:
                    monthName = "July";
                    break;
                case 08:
                    monthName = "August";
                    break;
                case 09:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
            }
            return monthName;
        }

        public String convert24To12(String time) {
            DateTime givenTime = DateTime.Parse(time);
            String in12HrFormat = givenTime.ToString("hh:mm:ss tt");
            return in12HrFormat;
        }
    }
}
