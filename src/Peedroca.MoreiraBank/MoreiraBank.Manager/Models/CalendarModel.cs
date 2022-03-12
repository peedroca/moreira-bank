using MoreiraBank.Manager.Data;

namespace MoreiraBank.Manager.Models
{
    internal class CalendarModel : ModelBase
    {
        public CalendarModel(string? calendarDate, string? calendarYear, string? calendarMonth)
        {
            CalendarDate = calendarDate;
            CalendarYear = calendarYear;
            CalendarMonth = calendarMonth;
        }

        public string? CalendarDate { get; private set; }
        public string? CalendarYear { get; private set; }
        public string? CalendarMonth { get; private set; }

        public static implicit operator CalendarModel(Calendar? calendar)
        {
            return new CalendarModel(calendar?.CalendarDate, calendar?.CalendarYear, calendar?.CalendarMonth);
        }
    }
}