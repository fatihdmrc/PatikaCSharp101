Calisan calisan1 = new Calisan("Fatih", "Demirci", "Bilgi İşlem", 01); //Parametreli yapıcı metot çalışır
Calisan calisan2 = new Calisan("Ali", "Demirci", "İnsan Kaynakları", 02); // parametreli yapıcı metot çalışır
Calisan calisan3 = new Calisan("Fatma Nur", "Yılmaz"); // Overload edilmiş yapıcı metot çalışır
Calisan calisan4 = new Calisan(); // Boş olan yapıcı metot çalışır
calisan1.calisanBilgileriYazdir();
calisan2.calisanBilgileriYazdir();
calisan3.calisanBilgileriYazdir();
calisan4.calisanBilgileriYazdir();
class Calisan
{
    public Calisan() // parametresiz kurucu metot
    {

    }
    public Calisan(string Ad, string Soyad, string Departman, int No) // Parametreli Kurucu metot (Constructor)
    {
        this.ad = Ad; // this.ad --> Bu snıfın elemanı olan "ad" demek
        this.soyad = Soyad;
        this.departman = Departman;
        this.no = No;
    }
    public Calisan(string Ad, string Soyad) // Kurucu metodun overload edilmesi (aşırı yüklenmesi)
    {
        this.ad = Ad;
        this.soyad = Soyad;
    }
    public string ad; // Field lar
    public string soyad;
    public int no;
    public string departman;

    public void calisanBilgileriYazdir() // Sınıfta tanımlanmış bir metot
    {
        System.Console.WriteLine("Çalışan bilgileri ekrana yazdırılıyor...");
        Console.WriteLine("Çalışan adı:" + ad);
        Console.WriteLine("Çalışan soyadı:" + soyad);
        Console.WriteLine("Çalışan No:" + no);
        Console.WriteLine("Çalışanın Departmanı:" + departman);
    }
}