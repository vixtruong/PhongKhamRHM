using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Letan
{
    public string MaLt { get; set; } = null!;

    public string Hoten { get; set; } = null!;

    public DateOnly Ngaysinh { get; set; }

    public DateOnly Ngaylamviec { get; set; }

    public string? Sdt { get; set; }

    public string? Gioitinh { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
