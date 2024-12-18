using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Yetkiler
{
    public int Id { get; set; }

    public string YetkiAdi { get; set; } = null!;

    public bool Durum { get; set; }

    public int? Aktif { get; set; }

    public virtual ICollection<YetkiRol> YetkiRols { get; set; } = new List<YetkiRol>();
}
