using System;
using System.Collections.Generic;

namespace GuvenEmlak.Models;

public partial class House
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public int Price { get; set; }

    public string Type { get; set; } = null!;

    public int CountRoom { get; set; }

    public int Size { get; set; }

    public string Status { get; set; } = null!;

    public byte[]? Picture { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
