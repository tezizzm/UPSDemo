using System;
using System.Collections.Generic;

namespace UI.Model;

public partial class CurrencyExchange
{
    public DateTime Date { get; set; }

    public string FromCurrency { get; set; } = null!;

    public string ToCurrency { get; set; } = null!;

    public double? Exchange { get; set; }
}
