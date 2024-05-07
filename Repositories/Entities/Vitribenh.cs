using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Vitribenh
{
    public string MaVt { get; set; } = null!;

    public string TenVt { get; set; } = null!;

    public int Gia { get; set; }

    public string Dvt { get; set; } = null!;

    public string MaKt { get; set; } = null!;

    public virtual ICollection<Chitietpkb> Chitietpkbs { get; set; } = new List<Chitietpkb>();

    public virtual Kythuat MaKtNavigation { get; set; } = null!;
}
