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



            return new DateTime(year: Convert.ToInt32(dateTime.Substring(0, 4)),
                                month: Convert.ToInt32(dateTime.Substring(4, 2)),
                                day: Convert.ToInt32(dateTime.Substring(6, 2)),
                                hour: Convert.ToInt32(dateTime.Substring(8, 2)),
                                minute: Convert.ToInt32(dateTime.Substring(10, 2)),
                                second: 0
                                );
        }
    }
}
