﻿using System;
using System.Collections.Generic;

namespace UI.Model;

public partial class Sale
{
    public long OrderNumber { get; set; }

    public int? LineNumber { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? CustomerKey { get; set; }

    public int? StoreKey { get; set; }

    public int? ProductKey { get; set; }

    public int? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? NetPrice { get; set; }

    public decimal? UnitCost { get; set; }

    public string? CurrencyCode { get; set; }

    public double? ExchangeRate { get; set; }
}
