﻿using System;
using NetTelebot.BotEnum;

namespace NetTelebot.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public static class UtilityExtensions
    {
        private static DateTime baseDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        
        /// <summary>
        /// Convert date from unix time to the <see cref="DateTime"/>.
        /// </summary>
        /// <param name="unixDate">The unix date</param>
        /// <returns>Convert DateTime</returns>
        public static DateTime ToDateTime(this long unixDate)
        {
            return baseDate.AddSeconds(unixDate).ToLocalTime();
        }

        /// <summary>
        /// Convert a date time object to Unix time representation.
        /// </summary>
        /// <param name="dateTime">The datetime object to convert to Unix time stamp.</param>
        /// <returns>Returns a numerical representation (Unix time) of the DateTime object.</returns>
        public static long ToUnixTime(this DateTime dateTime)
        {
            return (long)(dateTime - baseDate).TotalSeconds;
        }

        /// <summary>
        /// Converts a string to the specified in T enum type
        /// </summary>
        /// <param name="enumString">String value for conversion to an existing structure</param>
        /// <typeparam name="T">Exiting structure</typeparam>
        /// <returns>The value of the enumeration T from string. Null if constant in enumeration not exist</returns>
        public static T? ToEnum<T>(this string enumString) where T:struct
        {
            if (Enum.IsDefined(typeof(T), enumString))
                return (T) Enum.Parse(typeof (T), enumString, true);

            return null;
        }
    }
}
