﻿using System;
using System.Collections.Generic;

namespace PE_Sample_SP22_Q1.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public string? Phone { get; set; }

    public string? Idnumber { get; set; }

    public virtual ICollection<Service> Services { get; } = new List<Service>();
}
