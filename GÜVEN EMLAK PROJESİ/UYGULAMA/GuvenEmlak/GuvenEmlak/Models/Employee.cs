using System;
using System.Collections.Generic;

namespace GuvenEmlak.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string EmployeLastName { get; set; } = null!;

    public string EmployeePhone { get; set; } = null!;

    public string EmployeeEmail { get; set; } = null!;

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
