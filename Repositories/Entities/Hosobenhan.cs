using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Hosobenhan
{
    public string MaBn { get; set; } = null!;

    public short Solankham { get; set; }

    public DateOnly Ngaykham { get; set; }

    public string Tinhtrang { get; set; } = null!;

    public int MaHs { get; set; }

    public virtual Benhnhan MaBnNavigation { get; set; } = null!;
}
