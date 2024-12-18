using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class UyelikDurumu
{
    public int Id { get; set; }

    public string? UyelikDurumu1 { get; set; }

    public int? Aktif { get; set; }

    public virtual ICollection<Kullanicilar> Kullanicilars { get; set; } = new List<Kullanicilar>();
}
