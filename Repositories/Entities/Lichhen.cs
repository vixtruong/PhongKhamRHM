using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Lichhen
{
    public string MaLh { get; set; } = null!;

    public DateOnly Ngayhen { get; set; }

    public string MaBs { get; set; } = null!;

    public string MaBn { get; set; } = null!;

    public string? Nhucaukham { get; set; }

    public string LoaiBenhNhan { get; set; } = null!;

    public virtual Benhnhan MaBnNavigation { get; set; } = null!;

    public virtual Bacsi MaBsNavigation { get; set; } = null!;
}
