using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Chitietpkb
{
    public string MaPkb { get; set; } = null!;

    public string? MaVt { get; set; }

    public int Soluong { get; set; }

    public int MaCtpkb { get; set; }

    public int Thanhtien { get; set; }

    public virtual Phieukhambenh MaPkbNavigation { get; set; } = null!;

    public virtual Vitribenh? MaVtNavigation { get; set; }
}
