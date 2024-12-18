using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Bildirimler
{
    public int Id { get; set; }

    public int OlusturanKullaniciId { get; set; }

    public int? EtkinlikId { get; set; }

    public DateTime BildirimTarihi { get; set; }

    public string BildirimBasligi { get; set; } = null!;

    public string BildirimIcerigi { get; set; } = null!;

    public bool Durum { get; set; }

    public int? Aktif { get; set; }

    public virtual ICollection<BildirimKullanici> BildirimKullanicis { get; set; } = new List<BildirimKullanici>();

    public virtual Kullanicilar OlusturanKullanici { get; set; } = null!;
}
