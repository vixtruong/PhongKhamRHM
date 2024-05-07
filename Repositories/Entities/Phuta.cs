using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Phuta
{
    public string MaPt { get; set; } = null!;

    public string Hoten { get; set; } = null!;

    public DateOnly Ngaysinh { get; set; }

    public DateOnly Ngaylamviec { get; set; }

    public string? Gioitinh { get; set; }

    public string? Sdt { get; set; }

    public virtual ICollection<Calamviec> Calamviecs { get; set; } = new List<Calamviec>();
}
