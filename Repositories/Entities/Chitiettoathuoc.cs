using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Chitiettoathuoc
{
    public string MaToa { get; set; } = null!;

    public string MaThuoc { get; set; } = null!;

    public int Soluong { get; set; }

    public int Macttt { get; set; }

    public int Thanhtien { get; set; }

    public virtual Thuoc MaThuocNavigation { get; set; } = null!;

    public virtual Toathuoc MaToaNavigation { get; set; } = null!;
}
