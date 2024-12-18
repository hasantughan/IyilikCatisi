using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Haberler
{
    public int Id { get; set; }

    public string Baslik { get; set; } = null!;

    public string? Yazar { get; set; }

    public string Icerik { get; set; } = null!;

    public string? Etiketler { get; set; }

    public DateOnly? YayinTarihi { get; set; }

    public int? GoruntulenmeSayisi { get; set; }

    public DateTime? OlusturmaTarihi { get; set; }

    public DateTime? GuncellemeTarihi { get; set; }

    public int? Aktif { get; set; }
}
