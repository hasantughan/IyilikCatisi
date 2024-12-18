using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class EtkinlikFotograflari
{
    public int Id { get; set; }

    public int EtkinlikId { get; set; }

    public string? Fotograf { get; set; }

    public string? FotografAciklama { get; set; }

    public int? Aktif { get; set; }

    public virtual Etkinlik Etkinlik { get; set; } = null!;
}
