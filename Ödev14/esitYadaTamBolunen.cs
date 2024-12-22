System.Console.WriteLine("Lütfen iki adet pozitif  sayı girin:");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[] sayilar = new int[n];
System.Console.WriteLine("Lütfen"+n+"adet sayı girin:");
for(int i=0; i<n; i++)
{
    System.Console.WriteLine(i+1+". sayıyı girin:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    sayilar[i] = sayi;
}
System.Console.WriteLine(m+" sayısına eşit veya tam bölünen sayılar yazdırılıyor...");
System.Console.WriteLine("---------------------------------------------");
foreach(int item in sayilar)
{
    if(item ==m || item %m==0)
    {
        System.Console.WriteLine(item);
    }
}