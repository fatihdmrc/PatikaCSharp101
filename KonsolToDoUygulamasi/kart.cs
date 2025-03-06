public class Kart
{
    public Kart(string baslik, string icerik, TakimUye kisi, Buyukluk buyukluk, Satir satiri)
    {
        Baslik = baslik;
        Icerik = icerik;
        setAtananKisi(kisi);
        setBuyukluk(buyukluk);
        setBulunduguSatir(satiri);
        tumKartlar.Add(this);
    }
    private static List<Kart> tumKartlar = new List<Kart>();

    public static void kartSil(Kart silinecekkart)
    {
        tumKartlar.Remove(silinecekkart);
    }
    public static bool kartAra(string baslik, out Kart bulunankart)
    {
        foreach (var item in tumKartlar)
        {
            if (item.Baslik == baslik)
            {
                bulunankart = item;
                return true;
            }
        }
        bulunankart = null;
        return false;
    }
    private Satir bulundugusatir;
    private string baslik;
    private string icerik;
    private TakimUye atanankisi;
    private Buyukluk buyukluk;
    public string Baslik
    {
        get => baslik;
        set => baslik = value;
    }
    public string Icerik
    {
        get => icerik;
        set => icerik = value;
    }
    public void setBulunduguSatir(Satir satir)
    {
        bulundugusatir = satir;
    }
    public Satir getBulunduguSatir()
    {
        return bulundugusatir;
    }
    public void setAtananKisi(TakimUye atanacakkisi)
    {
        atanankisi = atanacakkisi;
    }
    public TakimUye getAtananKisi()
    {
        return atanankisi;
    }
    public void setBuyukluk(Buyukluk deger)
    {
        buyukluk = deger;
    }
    public Buyukluk getBuyukluk()
    {
        return buyukluk;
    }
    public void kartEkle(string baslik, string icerik, int kisiid, int buyukluk)
    {
        Baslik = baslik;
        Icerik = icerik;
        foreach (var item in TakimUye.takimlistesi)
        {
            if (item.Id == kisiid)
            {
                atanankisi = item;
            }
            else
            {
                System.Console.WriteLine("Girilen atanan kişi ıd'si takım üyelerinde bulunamadı!");
            }
        }


    }

}
public enum Buyukluk
{
    XS = 1,
    S,
    M,
    L,
    XL
}