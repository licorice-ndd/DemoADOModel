﻿using System;
using System.Collections.Generic;

namespace CRUDNet5.DataAccess;

public partial class Car
{
    public int CarId { get; set; }

    public string? CarName { get; set; }

    public string? Manufacturer { get; set; }

    public decimal? Price { get; set; }

    public int? ReleasedYear { get; set; }
}
