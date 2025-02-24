System.Console.WriteLine("Lütfen 20 adet sayı giriniz:");
int[] sayidizisi = new int[20];
for (int i = 0; i < 20; i++)
{
    System.Console.Write("Lütfen " + (i + 1) + ". sayıyı girin:");
    string sayi = Console.ReadLine();
    if (Int32.TryParse(sayi, out int dsayi))
    {
        System.Console.WriteLine("Sayı başarı ile alındı...");
        sayidizisi[i] = dsayi;
    }
    else
    {
        System.Console.WriteLine("Lütfen sayı olmayan değerler girmeyiniz!");
        i--;
    }
}
Array.Sort(sayidizisi); // sayı dizisisi sıralanıyor
int[] kucuksayilar = new int[3];
int[] buyuksayilar = new int[3];
for (int i = 0; i < 3; i++) // küçük ve büyük sayı dizilerine elemanlar ekleniyor
{
    kucuksayilar[i] = sayidizisi[i];
    buyuksayilar[i] = sayidizisi[sayidizisi.Length - 3 + i];
}
System.Console.WriteLine("----En Küçük 3 Sayı----");
foreach (int item in kucuksayilar)
{
    System.Console.WriteLine(item);
}
int kucuktoplam = kucuksayilar.Sum();
System.Console.WriteLine("En küçük 3 sayının toplamı:" + kucuktoplam);
System.Console.WriteLine("En küçük 3 sayının ortalaması:" + kucuktoplam / kucuksayilar.Length);
System.Console.WriteLine("----En Büyük 3 sayı ----");
foreach (int item in buyuksayilar)
{
    System.Console.WriteLine(item);
}
int buyuktoplam = buyuksayilar.Sum();
System.Console.WriteLine("En büyük 3 sayının toplamı:" + buyuktoplam);
System.Console.WriteLine("En büyük 3 sayının ortalaması:" + buyuktoplam / buyuksayilar.Length);