using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class YorumTip
{
    public byte Id { get; set; }

    public string YorumTipi { get; set; } = null!;

    public int? Aktif { get; set; }

    public virtual ICollection<Yorumlar> Yorumlars { get; set; } = new List<Yorumlar>();
}
