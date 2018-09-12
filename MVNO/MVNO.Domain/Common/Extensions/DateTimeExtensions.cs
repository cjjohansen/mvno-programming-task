using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.MVNO.Domain.Common.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// returns true if a dateTime is in a given year and month
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static  bool IsWithIn(this DateTime dateTime, int year, int month)
        {
            if (dateTime.Year == year && dateTime.Month == month)
                return true;
            return false;
        }
    }
}
