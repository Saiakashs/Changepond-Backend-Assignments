using System;
using System.Collections.Generic;

namespace WebApplicationDemo.Models;

public partial class Employee
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;
}
