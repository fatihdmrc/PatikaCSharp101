Ogrenci ogrenci1 = new Ogrenci("Fatih", "Demirci", 3, 17);
ogrenci1.ogrenciBilgileriniGetir();
ogrenci1.sinifAtlat();
ogrenci1.sinifAtlat();
ogrenci1.ogrenciBilgileriniGetir();
ogrenci1.sinifDusur();
ogrenci1.sinifDusur();
ogrenci1.sinifDusur();
ogrenci1.sinifDusur();
class Ogrenci
{
    public Ogrenci()
    {

    }
    public Ogrenci(string isim, string soyisim, int sinif, int ogrencino)
    { // Proplar kullanarak kontrollü bir şekilde fieldlarımıza kurucu metot ile değerleri aktardık.
      //Direk field'a da aktarabildirdik fakat bu sefer bir kontrol işlemi proplarda olabileceği için hiç işlemden geçmemiş olacaktı.
        Isım = isim;
        Soyisim = soyisim;
        Ogrencino = ogrencino;
        Sinif = sinif;
    }
    public void ogrenciBilgileriniGetir()
    {
        System.Console.WriteLine("----Öğrenci Bilgileri Yazdırılıyor----");
        Console.WriteLine("Öğrencinin ismi:" + Isım);
        Console.WriteLine("Öğrencinin soyismi:" + Soyisim);
        Console.WriteLine("Öğrencinin sınıfı:" + Sinif);
        Console.WriteLine("Öğrencinin Numarası:" + Ogrencino);

    }
    public void sinifAtlat()
    {
        System.Console.WriteLine("Sınıf atlatma işlemi yapılıyor...");
        Sinif++;
    }
    public void sinifDusur()
    {
        System.Console.WriteLine("Sınıf düşürme işlemi yapılıyor...");
        Sinif--;
    }
    private string isim;
    private string soyisim;
    private int sinif;
    private int ogrencino;

    public string Isım
    {
        get { return isim; } // Propery içinde işlemler yapacaksak bu şekilde de oluşturabiliriz
        set { isim = value; }
    }
    public string Soyisim
    {
        get => soyisim; set => soyisim = value; // Eğer girilen değer direk çağırılacak veya set edilecekse o zaman bu şekilde kısa bir ifade ile de prop oluşturabiliriz
    }
    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
            {
                System.Console.WriteLine("Öğrencinin sınıfı 1 den küçük olamaz!");
                Sinif = 1;
                System.Console.WriteLine("Öğrencinin sınıfı 1 olarak güncellendi.");
            }
            if (value > 4)
            {
                System.Console.WriteLine("Öğrencinin sınıfı 4 den büyük olamaz!");
                Sinif = 4;
                System.Console.WriteLine("Öğrencinin sınıfı 4 olarak güncellendi.");
            }
            else
            {
                sinif = value;
            }
        }
    }
    public int Ogrencino
    {
        get => ogrencino; set => ogrencino = value;
    }
    /* Kapsülleme işlemini bu şekilde yaptık. Bundan sonra sınıf dışından field'lara erişirken 
    hep propertyleri kullanacağız.
    */
}

