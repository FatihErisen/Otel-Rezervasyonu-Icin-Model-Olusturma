# Otel-Rezervasyonu-Icin-Model-Olusturma
Visual Studio ile Otel Rezervasyonu İçin Model Oluşturma

### Oluşturulan Modelin Diyagramı:
![otel](https://user-images.githubusercontent.com/122473354/231131579-02050f9c-0568-460e-95da-1213e639537a.png)


### 1.	Otel Sınıfı 
-	int türünde OtelId isimli PrimaryKey, 
-	Kategori türünde Kategori ForeignKey,
-	String türünde Ad, Telefon, Fax, Sehir, Ilce ve TamAdres (NotMapped),
-	 int türünde Kapasite,
-	 double türünde DenizeUzeklık, MerkezeUzaklik ve HavaAlaninaUzaklik,
-	 Star (enum) türünde Yildiz, 
değişkenleri tanımlandı. Star enum’ının içeriği: None, Bir, Ikı, Uc, Dort, Bes, Alti ve Yedi.

### 2.	Otel Olanakları Sınıfı
-	int türünde OtelOlanaklariId isimli PrimaryKey, 
-	Otel türünde Otel ForeignKey,
-	Bool türünde UcretsizIptal, TumGunServis, WIFI, AlakartRestoran, YikamaServisi, UcretsizOtopark, ToplantiOdasi, LobiBar, HavuzBar, SporSalonu, AcikHavuz, KapaliHavuz,
değişkenleri tanımlandı. Bu değişkenlerin bool olarak tanımlanmasının sebebi, söz konusu olanaklar var ise True; yok ise False değerlerini alabilmeleri için seçildi.

### 3. Müşteri Sınıfı

-	int türünde MusteriId isimli PrimaryKey, 
-	String türünde Ad, Eposta, Telefon, AdSoyad (NotMapped), TumBilgiler (NotMapped, Ad+Soyad+Yas)
-	 int türünde Yas,
-	 Cinsiyet (enum) türünde Cinsiyet,  
değişkenleri tanımlandı

### 4. Otel Yorum Sınıfı
-	int türünde OtelYorumId isimli PrimaryKey, 
-	Musteri türünde Musteri ForeignKey,
-	Otel türünde Otel ForeignKey,
-	String türünde Yorum
-	 Star (enum) türünde Yildiz,
-	 Durum (enum) türünde Durum,  
değişkenleri tanımlandı. Durum enum’ının içeriği: OnayBekliyor, Yayinlandi, KullaniciTarafindanSilindi, Reddedildi seçenekleri yer almaktadır. 

### 5. Rezervasyon Sınıfı
-	int türünde RezervasyonId isimli PrimaryKey, 
-	Musteri türünde Musteri ForeignKey,
-	Otel türünde Otel ForeignKey,
-	int türünde YetiskinSayisi, CocukSayisi,
-	double türünde Ucret,
-	DateTime türünde GirisTarihi, CikisTarihi, RezervasyonTarihi,
-	RezervasyonDurumu (enum) türünde durum,  
değişkenleri tanımlandı. RezervasyonDurum enum’ının içeriği: Onaylandi, Reddedildi, MusteriIptal, OtelIptal ve Diger seçenekleri yer almaktadır.

### 6. Rezervasyon Ödeme Sınıfı
-	int türünde RezervasyonOdemeId isimli PrimaryKey, 
-	Rezervasyon türünde Rezervasyon ForeignKey,
-	OdemeMetodu türünde OdemeMetodu ForeignKey,
-	double türünde ToplamUcret,
-	String türünde KartNo, SonKullanmaTarihi,
-	İnt türünde CVV,
-	OdemeDurumu (enum) türünde durum, 
değişkenleri tanımlandı. OdemeDurum enum’ının içeriği: Onaylandi, YetersizBakiye, Reddedildi, ve DigerHatalar seçenekleri yer almaktadır.

### 7. Ödeme Metodu sınıfı
-	int türünde OdemeMetoduId isimli PrimaryKey, 
-	Metot (enum) türünde Metot, 
değişkenleri tanımlandı. Metot enum’ının içeriği: Nakit, KrediKarti, EFT_Havale ve HadiyeCeki seçenekleri yer almaktadır.

### 8.	 Fotoğraf Sınıfı
-	int türünde FotografId isimli PrimaryKey, 
-	Otel türünde Otel ForeignKey,
-	String türünde DosyaAdi, DosyaYolu 
değişkenleri tanımlandı. 

### 9. Kategori Sınıfı
-	int türünde KategoriId isimli PrimaryKey, 
-	String türünde Ad
değişkenleri tanımlandı. 
