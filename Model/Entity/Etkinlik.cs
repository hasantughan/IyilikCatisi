using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Etkinlik
{
    public int Id { get; set; }

    public string? Baslik { get; set; }

    public string? Aciklama { get; set; }

    public DateOnly? Tarih { get; set; }

    public TimeOnly? Saat { get; set; }

    public string? Konum { get; set; }

    public bool Durum { get; set; }

    public int? Aktif { get; set; }

    public virtual EtkinlikFotograflari? EtkinlikFotograflari { get; set; }
}
