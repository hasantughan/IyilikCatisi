using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Roller
{
    public int Id { get; set; }

    public string RolAdi { get; set; } = null!;

    public int? Aktif { get; set; }

    public virtual ICollection<KullaniciRol> KullaniciRols { get; set; } = new List<KullaniciRol>();

    public virtual ICollection<YetkiRol> YetkiRols { get; set; } = new List<YetkiRol>();
}
