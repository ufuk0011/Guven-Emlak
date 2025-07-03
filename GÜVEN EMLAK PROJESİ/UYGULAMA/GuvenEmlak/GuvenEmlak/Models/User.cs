using System;
using System.Collections.Generic;

namespace GuvenEmlak.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string NicName { get; set; } = null!;

    public string? Password { get; set; }
}
