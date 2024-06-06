using System;
using System.Collections.Generic;

namespace UI.Model;

public partial class Order
{
    public long OrderKey { get; set; }

    public int? CustomerKey { get; set; }

    public int? StoreKey { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? CurrencyCode { get; set; }

    public virtual Customer? CustomerKeyNavigation { get; set; }

    public virtual Date? OrderDateNavigation { get; set; }

    public virtual Store? StoreKeyNavigation { get; set; }
}
