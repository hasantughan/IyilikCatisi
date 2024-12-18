using System;
using System.Collections.Generic;

namespace Model.Entity;

public partial class Kullanicilar
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public int TcKimlikNo { get; set; }

    public string Email { get; set; } = null!;

    public bool? EpostaOnay { get; set; }

    public string CepTel { get; set; } = null!;

    public bool? CepTelOnay { get; set; }

    public string Sifre { get; set; } = null!;

    public DateOnly DogumTarihi { get; set; }

    public string? Adres { get; set; }

    public bool Durum { get; set; }

    public int? HataliGirisSayisi { get; set; }

    public DateTime? UyelikTarihi { get; set; }

    public int? UyelikDurumuId { get; set; }

    public Guid? UniqueId { get; set; }

    public int? Aktif { get; set; }

    public virtual ICollection<Bagislar> Bagislars { get; set; } = new List<Bagislar>();

    public virtual ICollection<BildirimKullanici> BildirimKullanicis { get; set; } = new List<BildirimKullanici>();

    public virtual ICollection<Bildirimler> Bildirimlers { get; set; } = new List<Bildirimler>();

    public virtual ICollection<KullaniciRol> KullaniciRols { get; set; } = new List<KullaniciRol>();

    public virtual ICollection<Mesajlar> Mesajlars { get; set; } = new List<Mesajlar>();

    public virtual ICollection<UyelikAidatlari> UyelikAidatlaris { get; set; } = new List<UyelikAidatlari>();

    public virtual UyelikDurumu? UyelikDurumu { get; set; }

    public virtual ICollection<Yorumlar> Yorumlars { get; set; } = new List<Yorumlar>();
}
