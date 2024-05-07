using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Toathuoc
{
    public string MaToa { get; set; } = null!;

    public DateOnly Ngaylap { get; set; }

    public string MaBs { get; set; } = null!;

    public string MaPkb { get; set; } = null!;

    public virtual ICollection<Chitiettoathuoc> Chitiettoathuocs { get; set; } = new List<Chitiettoathuoc>();

    public virtual Phieukhambenh MaPkbNavigation { get; set; } = null!;
}
