using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.DateTimes
{
    static class Appointment
    {
        public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);
        public static bool HasPassed(DateTime appointmentDate) => appointmentDate.CompareTo(DateTime.Now) < 0;
        public static bool IsAfternoonAppointment(DateTime appointmentDate) => (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18);
        public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";
        public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
