public class Kisi
{
    public Kisi(string _isim, string _soyisim, string _numara) // Yeni kişi oluşturma
    {
        Isım = _isim;
        SoyIsım = _soyisim;
        Numara = _numara;
        kisilistesi.Add(this);
    }
    private string isim;
    private string soyisim;
    private string numara;
    public static List<Kisi> kisilistesi = new List<Kisi>(); // Kişilerin listesi
    public string Isım
    {
        get { return isim; }
        set { isim = value; }
    }
    public string SoyIsım
    {
        get { return soyisim; }
        set { soyisim = value; }
    }
    public string Numara
    {
        get { return numara; }
        set { numara = value; }
    }
    public static void kisiSil(int indeks) // Kişi silme
    {
        Kisi.kisilistesi.RemoveAt(indeks);
    }
    public static bool kisiAra(string isimvsoyisim, out int kisiindex) // Kişi arama
    {
        bool aramaislemi = false;
        string[] isdizi = isimvsoyisim.Split(" ");
        kisiindex = 0;
        for (int i = 0; i < Kisi.kisilistesi.Count; i++)
        {
            if (Kisi.kisilistesi[i].Isım == isdizi[0] && Kisi.kisilistesi[i].SoyIsım == isdizi[1])
            {
                kisiindex = i;
                aramaislemi = true;
            }
        }
        return aramaislemi;
    }
    public static void kisiGuncelle(string numara, int indeks) // Kişinin numarasını günceller
    {
        Kisi.kisilistesi[indeks].Numara = numara;
    }
    public static void kisiBilgileriniGoster(int kisiindeks) // Kişinin bilgilerini ekrana yazdırır
    {
        System.Console.WriteLine("Kişi isim:" + Kisi.kisilistesi[kisiindeks].Isım);
        System.Console.WriteLine("Kişi soyisim:" + Kisi.kisilistesi[kisiindeks].SoyIsım);
        System.Console.WriteLine("Kişi numara:" + Kisi.kisilistesi[kisiindeks].Numara);
    }
    public static void rehberiListele() // Tüm rehberi listeler
    {
        foreach (var item in kisilistesi)
        {
            System.Console.WriteLine("***************************");
            System.Console.WriteLine("Kişi isim:" + item.Isım);
            System.Console.WriteLine("Kişi soyisim:" + item.SoyIsım);
            System.Console.WriteLine("Kişi numara:" + item.Numara);
        }
    }


}