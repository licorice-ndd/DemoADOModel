using System;
using System.Collections.Generic;

namespace CRUDNet5.DataAccess;

public partial class Student
{
    public int StudentId { get; set; }

    public string? RollNumber { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MidName { get; set; }
}
