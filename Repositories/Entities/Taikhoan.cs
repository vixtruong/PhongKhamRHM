using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class Taikhoan
{
    public string Sdt { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public string Chucvu { get; set; } = null!;

    public string Email { get; set; } = null!;
}
