using System;
using System.Collections.Generic;

namespace UI.Model;

public partial class CurrencyExchange1
{
    public DateTime? Date { get; set; }

    public string? FromCurrency { get; set; }

    public string? ToCurrency { get; set; }

    public double? Exchange { get; set; }
}
