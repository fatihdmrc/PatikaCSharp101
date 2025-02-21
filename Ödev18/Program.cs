using System.Collections;
ArrayList liste = new ArrayList();
int[] sayilar = { 1, 2, 88, 15, 24, 96, 45 };
liste.AddRange(sayilar);
liste.Sort();
foreach (int sayi in liste) // Sıralanmış ArrayList'i yazdırıyoruz
{
    System.Console.WriteLine(sayi);
}
System.Console.WriteLine(liste.BinarySearch(88)); // 88 elemanının indeksini ekranda yazdırır
liste.Reverse();// ArrayList elemanlarının sırasını terse çevirir
foreach (int sayi in liste)
{
    System.Console.WriteLine(sayi);
}
liste.Clear(); // Listeyi temizler