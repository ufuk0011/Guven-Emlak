using System;
using System.Collections.Generic;

namespace GuvenEmlak.Models;

public partial class Report
{
    public int Id { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string HouseName { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string CustomerPhone { get; set; } = null!;

    public string CustomerOpinions { get; set; } = null!;

    public string DateTime { get; set; } = null!;

    public int? EmployeeId { get; set; }

    public int? HouseId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual House? House { get; set; }
}
