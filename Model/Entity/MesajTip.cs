using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class MesajTip
{
    public byte Id { get; set; }

    public string MesajTipi { get; set; } = null!;

    public int? Aktif { get; set; }

    public virtual ICollection<Mesajlar> Mesajlars { get; set; } = new List<Mesajlar>();
}
