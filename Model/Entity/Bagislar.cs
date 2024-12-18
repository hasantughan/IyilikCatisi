using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Bagislar
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public int? TcKimlikNo { get; set; }

    public string Email { get; set; } = null!;

    public decimal BagisMiktari { get; set; }

    public int? BagisTuru { get; set; }

    public DateTime BagisTarihi { get; set; }

    public string BagislaIlgiliMesaj { get; set; } = null!;

    public bool BagisinDurumu { get; set; }

    public int? KullaniciId { get; set; }

    public int? Aktif { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }
}
