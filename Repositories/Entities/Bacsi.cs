using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Bacsi
{
    public string MaBs { get; set; } = null!;

    public string Hoten { get; set; } = null!;

    public string MaKhoa { get; set; } = null!;

    public DateOnly Ngaysinh { get; set; }

    public DateOnly Ngaylamviec { get; set; }

    public string? Sdt { get; set; }

    public string? Gioitinh { get; set; }

    public virtual ICollection<Calamviec> Calamviecs { get; set; } = new List<Calamviec>();

    public virtual ICollection<Lichhen> Lichhens { get; set; } = new List<Lichhen>();

    public virtual ICollection<Phieukhambenh> Phieukhambenhs { get; set; } = new List<Phieukhambenh>();
}
