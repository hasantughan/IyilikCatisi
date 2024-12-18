using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Yorumlar
{
    public long Id { get; set; }

    public int KullaniciId { get; set; }

    public string YorumMetni { get; set; } = null!;

    public byte YorumTipId { get; set; }

    public int? Aktif { get; set; }

    public virtual Kullanicilar Kullanici { get; set; } = null!;

    public virtual YorumTip YorumTip { get; set; } = null!;
}
