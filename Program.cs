
Metotlar ornek = new Metotlar();
int a =4;
int b =5;
Console.WriteLine("Bir Arttır Topla metodundan dönen değer:"+ornek.birarttirTopla(a,b));
Console.WriteLine("topla 1 metodundan sonra Güncel Değişkenlerin değerleri,a="+a+" b="+b);
Console.WriteLine("Topla2 metodundan dönen değer:"+ornek.birarttirTopla2(ref a,ref b));
Console.WriteLine("tpola 2 metodundan sonra Güncel Değişkenlerin değerleri,a="+a+" b="+b);

class Metotlar {
    public int birarttirTopla(int deger1, int deger2){
    deger1++;
    deger2++;
    return deger1 + deger2;
    }
    public int birarttirTopla2(ref int deger1, ref int deger2)
    {
    deger1++;
    deger2++;
    return deger1 + deger2;
    }
}
