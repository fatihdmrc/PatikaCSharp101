System.Console.WriteLine(Gunler.Pazar); // Ekranda Cuma Yazar
System.Console.WriteLine((int)Gunler.Pazar); // ekranda 7 yazar
int sicaklik = 32;
if (sicaklik <= (int)HavaDurumu.soguk)
{
    System.Console.WriteLine("Hava soğuk. Dışarıya çıkmak için pek uygun değil.");
}
else if (sicaklik <= (int)HavaDurumu.normal)
{
    System.Console.WriteLine("Biraz daha ısınması dışarı çıkmak için daha iyi olur :)");
}
else if (sicaklik <= (int)HavaDurumu.sicak)
{
    System.Console.WriteLine("Hava sıcaklığı normal. Dışarı çıkmak için uygun.");
}
else if (sicaklik <= (int)HavaDurumu.çoksicak)
{
    System.Console.WriteLine("Hava sıcak. İnce giyin yanarsın");
}
else
{
    System.Console.WriteLine("Hava çok sıcak. Çıkmasan daha iyi. Güneş çarpar bu havada :)");
}
enum Gunler
{
    Pazartesi = 1, // 0 dan değilde 1 den de başlatabiliriz. Diğerleri de otomatik olarak artar.
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}
enum HavaDurumu
{
    soguk = 5,
    normal = 20,
    sicak = 25,
    çoksicak = 30
}