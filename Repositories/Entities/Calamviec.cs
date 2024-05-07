using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Calamviec
{
    public string MaCa { get; set; } = null!;

    public DateOnly Ngay { get; set; }

    public string MaBs { get; set; } = null!;

    public string MaPt { get; set; } = null!;

    public byte Ca { get; set; }

    public virtual Bacsi MaBsNavigation { get; set; } = null!;

    public virtual Phuta MaPtNavigation { get; set; } = null!;
}
