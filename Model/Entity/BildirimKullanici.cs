using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class BildirimKullanici
{
    public long Id { get; set; }

    public int KullaniciId { get; set; }

    public int BildirimId { get; set; }

    public int? Aktif { get; set; }

    public virtual Bildirimler Bildirim { get; set; } = null!;

    public virtual Kullanicilar Kullanici { get; set; } = null!;
}
