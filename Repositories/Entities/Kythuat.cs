using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Kythuat
{
    public string MaKt { get; set; } = null!;

    public string TenKt { get; set; } = null!;

    public virtual ICollection<Vitribenh> Vitribenhs { get; set; } = new List<Vitribenh>();
}
