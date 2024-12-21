// Out 
/*
System.Console.Write("Lütfen bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
Metotlar ornek = new Metotlar();
if(ornek.sayiCiftMi(sayi, out int ciftsayi)){
    System.Console.WriteLine(ciftsayi+" sayısı çifttir.");
}
else{
    System.Console.WriteLine(+ciftsayi+" sayısı çift değildir!");
}
*/
// Aşırı Yükleme
Metotlar ornek = new Metotlar();
ornek.konsolaYazdir("Selam");
ornek.konsolaYazdir("Fatih","Demirci");
ornek.konsolaYazdir(23);
ornek.konsolaYazdir(2.5);

class Metotlar{
    public bool sayiCiftMi(int sayi, out int ciftsayi){
        if(sayi%2==0)
        {
            ciftsayi = sayi;
            return true;
        }
        else{
            ciftsayi = sayi;
            return false; 
        }
    }
    public void konsolaYazdir(string deger){
        System.Console.WriteLine(deger);
    }
    public void konsolaYazdir(string deger1, string deger2){
        System.Console.WriteLine(deger1+deger2);
    }
    public void konsolaYazdir(int deger){
     System.Console.WriteLine(deger);   
    }
    public void konsolaYazdir(double deger){
        System.Console.WriteLine(deger);
    }
}
