Calisan calisan1 = new Calisan();
calisan1.ad = "Fatih";
calisan1.soyad = "Demirci";
calisan1.no = 1;
calisan1.departman = "Bilgi İşlem";
calisan1.calisanBilgileriYazdir();
Calisan calisan2 = new Calisan();
calisan2.ad = "Ali";
calisan2.soyad = "Yılmaz";
calisan2.no = 2;
calisan2.departman = "İnsan Kaynakları";
calisan2.calisanBilgileriYazdir();

class Calisan
{
    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public void calisanBilgileriYazdir()
    {
        System.Console.WriteLine("Çalışan bilgileri ekrana yazdırılıyor...");
        Console.WriteLine("Çalışan adı:" + ad);
        Console.WriteLine("Çalışan soyadı:" + soyad);
        Console.WriteLine("Çalışan No:" + no);
        Console.WriteLine("Çalışanın Departmanı:" + departman);
    }
}