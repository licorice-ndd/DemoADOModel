﻿using System;
using System.Collections.Generic;

namespace PE_PRN211_FA22_Q2.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }

    public string? Description { get; set; }

    public string Language { get; set; } = null!;

    public int? ProducerId { get; set; }

    public int? DirectorId { get; set; }

    public virtual Director? Director { get; set; }

    public virtual Producer? Producer { get; set; }

    public virtual ICollection<Genre> Genres { get; } = new List<Genre>();

    public virtual ICollection<Star> Stars { get; } = new List<Star>();
}
