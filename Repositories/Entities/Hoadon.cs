using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Hoadon
{
    public string MaHd { get; set; } = null!;

    public short Giamgia { get; set; }

    public DateOnly Ngaylap { get; set; }

    public string MaLt { get; set; } = null!;

    public int Tongtien { get; set; }

    public string Mapkb { get; set; } = null!;

    public string Phuongthuc { get; set; } = null!;

    public string MaBn { get; set; } = null!;

    public int Thanhtien { get; set; }

    public virtual Benhnhan MaBnNavigation { get; set; } = null!;

    public virtual Letan MaLtNavigation { get; set; } = null!;

    public virtual Phieukhambenh MapkbNavigation { get; set; } = null!;
}
