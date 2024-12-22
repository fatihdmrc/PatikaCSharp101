System.Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Lütfen "+n+" adet kelime girin:");
string[] kelimedizisi = new string[n];
for(int i =0; i<n; i++)
{
    kelimedizisi[i] = Console.ReadLine();
}
System.Console.WriteLine("Kelimeler yazdırılıyor...");
System.Console.WriteLine("---------------------------");
for(int i=n-1; i>-1; i--)
{
    System.Console.WriteLine(kelimedizisi[i]);
}
