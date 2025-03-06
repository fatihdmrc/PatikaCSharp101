public class Satir
{
    public Satir(string isim, int no)
    {
        Isım = isim;
        No = no;
    }
    private string isim;
    private int no;
    private List<Kart> satirdakiKartlar = new List<Kart>();
    public string Isım
    {
        get => isim;
        set => isim = value;
    }
    public int No
    {
        get => no;
        set => no = value;
    }

    public void satirdakiKartlariGoster()
    {
        if (satirdakiKartlar.Count < 1)
        {
            System.Console.WriteLine(Isım + " satırında kart yok");
        }
        else if (satirdakiKartlar.Count >= 1)
        {
            System.Console.WriteLine(Isım + " satırında bulunan kartlar:");
            foreach (var item in satirdakiKartlar)
            {
                System.Console.WriteLine("****************************************");
                System.Console.WriteLine("Başlık:" + item.Baslik);
                System.Console.WriteLine("İçerik:" + item.Icerik);
                System.Console.WriteLine("Atanan kişi:" + item.getAtananKisi().Isım + " " + item.getAtananKisi().SoyIsım);
                System.Console.WriteLine("Büyüklük:" + item.getBuyukluk());
                System.Console.WriteLine("****************************************");

            }
        }

    }
    public void satiraKartEkle(Kart eklenecekkart)
    {
        satirdakiKartlar.Add(eklenecekkart);
    }
    public void satirdanKartSil(Kart silinecekkart)
    {
        satirdakiKartlar.Remove(silinecekkart);
    }
    public void satirDegistir(Kart degistirilecekkart, Satir degistirileceksatir)
    {
        Kart gecici = degistirilecekkart; // Kart geçici bir değişkene aktarıldı
        degistirilecekkart.getBulunduguSatir().satirdanKartSil(degistirilecekkart); // kart bulunduğu satırdan silindi
        gecici.setBulunduguSatir(degistirileceksatir); // Kartın satır bilgisi değiştirildi
        degistirileceksatir.satiraKartEkle(gecici); // Kart yeni satırına eklendi
    }

}