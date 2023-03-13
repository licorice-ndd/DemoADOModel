using System;
using System.Collections.Generic;

namespace PE_PRN211_FA22_Q1.Models;

public partial class Genre
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();
}
