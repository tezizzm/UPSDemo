using System;
using System.Collections.Generic;

namespace UI.Model;

public partial class GeoLocation
{
    public int? GeoLocationKey { get; set; }

    public string? CountryCode { get; set; }

    public string? Country { get; set; }

    public string? StateCode { get; set; }

    public string? State { get; set; }

    public int? NumCustomers { get; set; }
}
