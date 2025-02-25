System.Console.WriteLine("Çalışan Sayısı:" + Calisan.CalisanSayisi);
Calisan calisan1 = new Calisan("Fatih", "Demirci", "Bilgi İşlem");
System.Console.WriteLine("Çalışan Sayısı:" + Calisan.CalisanSayisi); // static prop'a bu şekilde sınıf üzerinden eriştik
Calisan calisan2 = new Calisan("Nurgül", "Demirci", "Revir");
System.Console.WriteLine("Çalışan sayısı:" + Calisan.CalisanSayisi);
System.Console.WriteLine("Toplama işlemi sonucu:" + Islemler.topla(1826418949, 56494894));
System.Console.WriteLine("Çıkarma işleminin sonucu:" + Islemler.cikarma(15649849, 52645));

public class Calisan
{
    // static bir field ve prop oluşturduğumuz zaman bu özellik sınıfa ait bir özelliktir nesneye ait değildir. O yüzden statik olarak sınıf üzerinden erişilir. 
    private static int calisansayisi;
    public static int CalisanSayisi
    {
        get { return calisansayisi; }
        // static prop'un set özelliğini kapattık yani sildik. Bu şekilde bu field sadece sınıf içerisinden değiştirilebilecek.
    }
    private string isim;
    private string soyisim;
    private string departman;
    /* 
    Bu 3 field'a kapsülleme işlemi yapmadık yani prop oluşturmadık. 
    Bu 3 field sadece kurucu metot ile oluşturulurken değer alacak ve değiştirilemeyecekte okunamayacakta.
    */
    static Calisan() // Statik bir kurucu metot da oluşturulabilir.
    {
        // Static kurucu metotların erişim belirteci yoktur.
        // Calisan sinifina ilk erişildiğinde çalışır sadece sonrasında bidaha çalışmaz.
        // Yani bir prop get set edildiğinde veya bir metot çağırıldığında  veya bir nesne oluşturulduğunda yani sınıfa herhangi bir erişimde çalışır
        calisansayisi = 0;
        System.Console.WriteLine("Statik metot çalıştı.... Sınıfa ilk erişim!");
    }
    public Calisan(string isim, string soyisim, string departman)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.departman = departman;
        calisansayisi++; // private olan field 1 arttırıldı
        System.Console.WriteLine("Çalışan nesnesi oluşturuldu...");
    }
}
static class Islemler
{
    // Static classların tüm üyeleri , metotları , fieldları, propları statik olmak zorundadır!
    public static long topla(long sayi1, long sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long cikarma(long sayi1, long sayi2)
    {
        return sayi1 - sayi2;
    }
}