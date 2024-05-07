using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Thuoc
{
    public string MaThuoc { get; set; } = null!;

    public string Tenthuoc { get; set; } = null!;

    public string Dvt { get; set; } = null!;

    public int Soluong { get; set; }

    public int Gia { get; set; }

    public virtual ICollection<Chitiettoathuoc> Chitiettoathuocs { get; set; } = new List<Chitiettoathuoc>();
}
