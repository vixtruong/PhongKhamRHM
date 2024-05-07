using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Chitietvatlieutieuhao
{
    public int Id { get; set; }

    public string MaPkb { get; set; } = null!;

    public string MaVl { get; set; } = null!;

    public int Soluong { get; set; }

    public virtual Phieukhambenh MaPkbNavigation { get; set; } = null!;

    public virtual Vatlieu MaVlNavigation { get; set; } = null!;
}
