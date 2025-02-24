using System.Buffers;

char[] sesliharfler = { 'a', 'ı', 'o', 'u', 'e', 'i', 'ö', 'ü', 'A', 'I', 'O', 'U', 'E', 'İ', 'Ö', 'Ü' };
System.Console.Write("Lütfen bir cümle yazın:");
string cümle = Console.ReadLine();
char[] cümledekisesliharfler = new char[0];
int z = 0;
for (int i = 0; i < cümle.Length; i++)
{
    for (int k = 0; k < sesliharfler.Length; k++)
    {
        if (cümle[i] == sesliharfler[k])
        {
            Array.Resize<char>(ref cümledekisesliharfler, z + 1);
            System.Console.WriteLine("Sesli harf bulundu!");
            cümledekisesliharfler[z] = cümle[i];
            z++;
        }
    }
}
System.Console.WriteLine("----Cümledeki sesli harfler (sıralı bir şekilde)----");
foreach (char item in cümledekisesliharfler)
{
    if (item != ' ')
    {
        System.Console.WriteLine("Sesli harf:" + item);
    }
}