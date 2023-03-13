using System;
using System.Collections.Generic;

namespace PE_PRN211_FA22_Q2.Models;

public partial class Star
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public bool? Male { get; set; }

    public DateTime? Dob { get; set; }

    public string? Description { get; set; }

    public string? Nationality { get; set; }

    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();
}
