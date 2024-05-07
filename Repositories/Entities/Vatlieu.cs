using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Vatlieu
{
    public string MaKhoa { get; set; } = null!;

    public string MaVl { get; set; } = null!;

    public string TenVl { get; set; } = null!;

    public string Dvt { get; set; } = null!;

    public int Soluong { get; set; }

    public int Gia { get; set; }


    public virtual ICollection<Chitietvatlieutieuhao> Chitietvatlieutieuhaos { get; set; } = new List<Chitietvatlieutieuhao>();
}
