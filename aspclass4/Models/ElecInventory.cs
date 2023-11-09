using System;
using System.Collections.Generic;

namespace aspclass4.Models;

public partial class ElecInventory
{
    public int Id { get; set; }

    public string? Pname { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public DateTime? Updateddate { get; set; }
}
