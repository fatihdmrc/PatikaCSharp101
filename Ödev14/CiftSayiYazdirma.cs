System.Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
int n  = Convert.ToInt32(Console.ReadLine());
int[] dizi = new int[n];
for(int i=0; i<n; i++) // Girilen sayılar diziye aktarılıyor
{
    System.Console.WriteLine(i+1+".sayıyı giriniz:"); 
    int sayi = Convert.ToInt32(Console.ReadLine());
    dizi[i] = sayi;
    System.Console.WriteLine("------------------------");
}
System.Console.WriteLine("Çift olan sayılar yazdırılıyor...");
foreach (int item in dizi)
{
    if(item%2==0)
    {
        System.Console.WriteLine(item);
    }
}