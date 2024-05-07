using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Benhnhan
{
    public string MaBn { get; set; } = null!;

    public string Hoten { get; set; } = null!;

    public DateOnly Ngaysinh { get; set; }

    public string Sdt { get; set; } = null!;

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Hosobenhan> Hosobenhans { get; set; } = new List<Hosobenhan>();

    public virtual ICollection<Lichhen> Lichhens { get; set; } = new List<Lichhen>();

    public virtual ICollection<Phieukhambenh> Phieukhambenhs { get; set; } = new List<Phieukhambenh>();
}
