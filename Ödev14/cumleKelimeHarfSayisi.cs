System.Console.WriteLine("Lütfen bir cümle yazınız:");
string cümle = Console.ReadLine();
string[] kelimeler = cümle.Split(" ");
System.Console.WriteLine("Cümlenin kelime sayısı:"+kelimeler.Length);
int toplamharf =0;
foreach(string item in kelimeler)
{
    toplamharf += item.Length;
}
System.Console.WriteLine("Cümlenin harf sayısı:"+toplamharf);
