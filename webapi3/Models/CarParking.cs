using System;
using System.Collections.Generic;

namespace webapi3.Models;

public partial class CarParking
{
    public int Tokenid { get; set; }

    public string? Carnumber { get; set; }

    public string? Carname { get; set; }

    public string? Parkinglot { get; set; }

    public int? Duration { get; set; }
}
