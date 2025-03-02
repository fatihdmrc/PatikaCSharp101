public class BilgiKontrol
{
    public static bool isimsoyisimKontrol(string isim, out string disim, out string hata)
    {
        bool kontroldurum = true;
        hata = "";
        isim.Trim(); // Metnin başındaki ve sonundaki boşlukları siler
        for (int i = 0; i < isim.Length; i++)
        {

            if (!Char.IsLetter(isim[i])) // karakteri harf mi diye kontrol eder
            {
                kontroldurum = false;
                hata = "İsim veya soyisim de harf dışında bir karakter bulunamaz!";
                break;
            }

        }
        disim = isim;
        return kontroldurum;
    }
    public static bool numaraKontrol(string numara, out string dnumara, out string hata)
    {
        hata = "";
        bool kontroldurum = true;
        numara.Trim();
        if (numara.Length != 11)
        {
            kontroldurum = false;
            dnumara = numara;
            hata = "Numara 11 karakterli olmalıdır!";
            return kontroldurum;
        }
        for (int i = 0; i < numara.Length; i++)
        {
            if (!Char.IsNumber(numara[i]))
            {
                hata = "Numara içinde rakam dışında bir karakter bulunamaz!";
                kontroldurum = false;
                dnumara = numara;
                return kontroldurum;
            }
        }
        dnumara = numara;
        return kontroldurum;

    }
}