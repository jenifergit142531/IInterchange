﻿using System;
using System.Collections.Generic;

namespace DBFirstApproach.Models;

public partial class LuxePropCare
{
    public Guid? Propid { get; set; }

    public string? Pname { get; set; }

    public string? Address { get; set; }

    public string? Service { get; set; }

    public DateTime? Requesteddate { get; set; }

    public int? Duration { get; set; }
}
