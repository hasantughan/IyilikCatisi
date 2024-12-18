using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class YetkiRol
{
    public int Id { get; set; }

    public int RolId { get; set; }

    public int YetkiId { get; set; }

    public int? Aktif { get; set; }

    public virtual Roller Rol { get; set; } = null!;

    public virtual Yetkiler Yetki { get; set; } = null!;
}
