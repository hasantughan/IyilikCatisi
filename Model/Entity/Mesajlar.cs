using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Mesajlar
{
    public long Id { get; set; }

    public int KullaniciId { get; set; }

    public string MesajIcerigi { get; set; } = null!;

    public byte MesajTipId { get; set; }

    public int? Aktif { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual MesajTip MesajTip { get; set; } = null!;
}
