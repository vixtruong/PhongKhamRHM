using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Phieukhambenh
{
    public string MaPkb { get; set; } = null!;

    public DateOnly Ngaykham { get; set; }

    public string? Tinhtrang { get; set; }

    public string MaBs { get; set; } = null!;

    public string MaBn { get; set; } = null!;

    public virtual ICollection<Chitietpkb> Chitietpkbs { get; set; } = new List<Chitietpkb>();

    public virtual ICollection<Chitietvatlieutieuhao> Chitietvatlieutieuhaos { get; set; } = new List<Chitietvatlieutieuhao>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual Benhnhan MaBnNavigation { get; set; } = null!;

    public virtual Bacsi MaBsNavigation { get; set; } = null!;

    public virtual ICollection<Toathuoc> Toathuocs { get; set; } = new List<Toathuoc>();
}
