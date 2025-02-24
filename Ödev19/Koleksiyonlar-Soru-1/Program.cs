using System.Collections;

static bool asalMi(int sayi)
{
    int pbt = 0;
    for (int i = 1; i <= sayi; i++)
    {
        if (sayi % i == 0)
        {
            pbt = pbt + i;
        }
    }
    if (sayi + 1 == pbt)
    {
        return true;
    }
    else
    {
        return false;
    }
}
System.Console.WriteLine("Lütfen 20 adet sayı giriniz!");
ArrayList asalsayilar = new ArrayList();
ArrayList asaldegil = new ArrayList();
for (int i = 0; i < 20; i++)
{
    System.Console.Write("Lütfen " + (i + 1) + ".sayıyı giriniz:");
    string sayi = Console.ReadLine();
    int dsayi;
    if (Int32.TryParse(sayi, out dsayi) && dsayi >= 0)
    {
        System.Console.WriteLine("Sayı başarı ile alındı...");
        if (asalMi(dsayi))
        {
            asalsayilar.Add(dsayi);
        }
        else
        {
            asaldegil.Add(dsayi);
        }
    }
    else
    {
        System.Console.WriteLine("Sayı olmayan veya negatif bir değer girildi! Lütfen sayısal pozitif değerler giriniz!");
        i--;
    }

}
if (asalsayilar.Count > 0)
{
    asalsayilar.Sort();
    asalsayilar.Reverse();
    System.Console.WriteLine("---- Asal Sayılar ---");
    int toplamasal = 0;
    foreach (int item in asalsayilar)
    {
        toplamasal = toplamasal + item;
        System.Console.WriteLine(item);
    }
    System.Console.WriteLine("Asal sayıların eleman sayısı:" + asalsayilar.Count);
    System.Console.WriteLine("Asal sayıların ortalaması:" + (toplamasal / asalsayilar.Count));

}
if (asaldegil.Count > 0)
{
    int toplamasaldegil = 0;
    asaldegil.Sort();
    asaldegil.Reverse();
    System.Console.WriteLine("---- Asal Olmayan Sayılar ----");
    foreach (int item in asaldegil)
    {
        toplamasaldegil = toplamasaldegil + item;
        System.Console.WriteLine(item);
    }
    System.Console.WriteLine("Asal olmayan sayıların eleman sayısı:" + asaldegil.Count);
    System.Console.WriteLine("Asal sayıların ortalaması:" + (toplamasaldegil / asaldegil.Count));
}



