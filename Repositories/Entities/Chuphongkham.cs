using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Chuphongkham
{
    public string MaCpk { get; set; } = null!;

    public string Hoten { get; set; } = null!;

    public string? Sdt { get; set; }
}
