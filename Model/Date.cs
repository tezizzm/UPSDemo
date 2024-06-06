using System;
using System.Collections.Generic;

namespace UI.Model;

public partial class Date
{
    public DateTime Date1 { get; set; }

    public int? DateKey { get; set; }

    public int? Year { get; set; }

    public string? YearQuarter { get; set; }

    public int? YearQuarterNumber { get; set; }

    public string? Quarter { get; set; }

    public string? YearMonth { get; set; }

    public string? YearMonthShort { get; set; }

    public int? YearMonthNumber { get; set; }

    public string? Month { get; set; }

    public string? MonthShort { get; set; }

    public int? MonthNumber { get; set; }

    public string? DayOfWeek { get; set; }

    public string? DayOfWeekShort { get; set; }

    public int? DayOfWeekNumber { get; set; }

    public bool? WorkingDay { get; set; }

    public int? WorkingDayNumber { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
