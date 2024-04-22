using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.DateTimes
{
    public class BeautySalonGoesGlobal
    {
        public enum Location
        {
            NewYork,
            London,
            Paris
        }
        public enum AlertLevel
        {
            Early,
            Standard,
            Late
        }
        public static class Appointment
        {
            public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();
            public static DateTime Schedule(string appointmentDateDescription, Location location)
            {
                DateTime dt = DateTime.Parse(appointmentDateDescription);
                return location switch
                {
                    Location.NewYork => TimeZoneInfo.ConvertTimeToUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")),
                    Location.London => TimeZoneInfo.ConvertTimeToUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")),
                    Location.Paris => TimeZoneInfo.ConvertTimeToUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time")),
                    _ => dt
                };
            }
            public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
            {
                return alertLevel switch
                {
                    AlertLevel.Early => appointment.AddDays(-1),
                    AlertLevel.Standard => appointment.AddMinutes(-105),
                    AlertLevel.Late => appointment.AddMinutes(-30),
                    _ => appointment
                };
            }
            public static bool HasDaylightSavingChanged(DateTime dt, Location location)
            {
                return location switch
                {
                    Location.NewYork => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time").IsDaylightSavingTime(dt) ^ TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time").IsDaylightSavingTime(dt.AddDays(-7)),
                    Location.London => TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time").IsDaylightSavingTime(dt) ^ TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time").IsDaylightSavingTime(dt.AddDays(-7)),
                    Location.Paris => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time").IsDaylightSavingTime(dt) ^ TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time").IsDaylightSavingTime(dt.AddDays(-7)),
                    _ => false
                };
            }
            public static DateTime NormalizeDateTime(string dtStr, Location location)
            {
                return location switch
                {
                    Location.NewYork => DateTime.TryParse(dtStr, CultureInfo.GetCultureInfo("en-US"), out DateTime res) ? res : new DateTime(1, 1, 1, 0, 0, 0),
                    Location.London => DateTime.TryParse(dtStr, CultureInfo.GetCultureInfo("en-GB"), out DateTime res) ? res : new DateTime(1, 1, 1, 0, 0, 0),
                    Location.Paris => DateTime.TryParse(dtStr, CultureInfo.GetCultureInfo("fr-FR"), out DateTime res) ? res : new DateTime(1, 1, 1, 0, 0, 0),
                    _ => new DateTime(1, 1, 1, 0, 0, 0)
                };
            }
        }
    }
}
