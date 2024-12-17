
try
{
System.Console.WriteLine("Lütfen yaşınızı girin:");
byte yas = Convert.ToByte(Console.ReadLine());
}
catch (FormatException ex)
{
    System.Console.WriteLine("Hata:Geçersiz değer girildi!");
}
catch (OverflowException ex2)
{
    System.Console.WriteLine("Girilebilecek değer aralığı dışına çıkıldı!");
}
