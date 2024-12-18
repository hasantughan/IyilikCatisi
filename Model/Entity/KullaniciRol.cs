using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class KullaniciRol
{
    public int Id { get; set; }

    public int RolId { get; set; }

    public int KullaniciId { get; set; }

    public int? Aktif { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual Roller Rol { get; set; } = null!;
}
