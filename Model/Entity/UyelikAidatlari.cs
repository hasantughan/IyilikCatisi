using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class UyelikAidatlari
{
    public int Id { get; set; }

    public decimal? AidatTutari { get; set; }

    public int? AidatOdemePeriyodu { get; set; }

    public DateOnly? OdemeSonTarihi { get; set; }

    public DateOnly? KayitTarihi { get; set; }

    public int? KullaniciId { get; set; }

    public int? Aktif { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }
}
