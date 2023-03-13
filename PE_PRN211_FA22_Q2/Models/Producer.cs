using System;
using System.Collections.Generic;

namespace PE_PRN211_FA22_Q2.Models;

public partial class Producer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();
}
