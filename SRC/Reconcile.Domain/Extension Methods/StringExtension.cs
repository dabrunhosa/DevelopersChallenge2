using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Extension_Methods
{
    public static class StringExtension
    {
        public static DateTime ToDatetime(this string source)
        {
            var tempSplit = source.Split('[');
            var dateTime = tempSplit[0];

            int year = Convert.ToInt32(dateTime.Substring(0, 4));
            int month = Convert.ToInt32(dateTime.Substring(4, 2));
            int day = Convert.ToInt32(dateTime.Substring(6, 2));
            int hour = Convert.ToInt32(dateTime.Substring(8, 2));
            int minute = Convert.ToInt32(dateTime.Substring(10, 2));
            int seconds = 0;

            try
            {
                return new DateTime(year: year, month: month, day: day,
                    hour: hour, minute: minute, second: seconds);
            }
            catch (Exception)
            {
                return new DateTime(year: year, month: month, day: 1,
                     hour: hour, minute: minute, second: seconds);
            }
        }
    }
}
