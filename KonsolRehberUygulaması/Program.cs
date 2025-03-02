Kisi vkisi1 = new Kisi("Fatih", "Demirci", "05370519300");

while (true)
{
    System.Console.Write("**************************\n(1) Yeni numara kaydet \n(2) Varolan Numarayı Sil \n(3) Varolan numarayı güncelle \n(4) Rehberi Listele \n(5) Rehberde arama yap \n(6) Çıkış Yap\n **************************\n Lütfen yapmak istediğiniz işlemi seçin:");
    string islemno = Console.ReadLine();
    if (Int32.TryParse(islemno, out int islemsonuc)) // Eğer girilen işlem no değeri bir sayı ise
    {
        if (islemsonuc == 1) // Rehbere yeni kişi ekleme
        {
            System.Console.Write("Lütfen rehbere eklenecek kişinin ismini giriniz:");
            string isim = Console.ReadLine();
            System.Console.Write("Lütfen rehbere eklenecek kişinin soyismini giriniz:");
            string soyisim = Console.ReadLine();
            System.Console.Write("Lütfen rehbere eklenecek kişinin numarasını giriniz:");
            string numara = Console.ReadLine();
            string _isimhata, _soyisimhata = "";
            string _numarahata = "";
            if (BilgiKontrol.isimsoyisimKontrol(isim, out string disim, out _isimhata) && BilgiKontrol.isimsoyisimKontrol(soyisim, out string dsoyisim, out _soyisimhata) && BilgiKontrol.numaraKontrol(numara, out string dnumara, out _numarahata))
            {
                System.Console.WriteLine("Yeni kişi kaydedildi!");
                Kisi yenikisi = new Kisi(disim, dsoyisim, dnumara);
            }
            else
            {
                System.Console.WriteLine("Kişi bilgileri hatalı girildi!");
                if (_isimhata.Length > 1)
                {
                    System.Console.WriteLine(_isimhata);
                }
                if (_soyisimhata.Length > 1)
                {
                    System.Console.WriteLine(_soyisimhata);
                }
                if (_numarahata.Length > 1)
                {
                    System.Console.WriteLine(_numarahata);
                }
            }


        }
        else if (islemsonuc == 2) // Rehberden kişi silme
        {
            System.Console.WriteLine("Lütfen rehberden silinmesi istenen kişinin ismini ve soyismini giriniz:");
            string isimvsoyisim = Console.ReadLine();
            if (Kisi.kisiAra(isimvsoyisim, out int indeks))
            {
                System.Console.WriteLine("Kişi bulundu! Bulunan kişinin bilgileri:");
                Kisi.kisiBilgileriniGoster(indeks);
                System.Console.WriteLine("Silme işlemini onaylıyor musunuz? 1-0");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    System.Console.WriteLine("Silme işlemi gerçekleştiriliyor...");
                    Kisi.kisiSil(indeks);
                    System.Console.WriteLine("Silme işlemi gerçekleştirildi!");
                }
                else if (secim == 0)
                {
                    System.Console.WriteLine("Silme işlemi gerçekleşmedi!");
                }
            }
            else
            {
                System.Console.WriteLine("Böyle bir kişi bulunamadı!");
            }



        }
        else if (islemsonuc == 3) // Rehberden numara güncelleme
        {
            System.Console.Write("********************\nNumarasını güncellemek istediğiniz kişinin ismini ve soyismini giriniz:");
            string isimvvsoyisim = Console.ReadLine();
            if (Kisi.kisiAra(isimvvsoyisim, out int kisiindeks))
            {
                System.Console.WriteLine("Güncellenecek kişinin bilgileri:");
                Kisi.kisiBilgileriniGoster(kisiindeks);
                System.Console.Write("Güncellenecek numarayı giriniz:");
                string numara = Console.ReadLine();
                Kisi.kisiGuncelle(numara, kisiindeks);
                System.Console.WriteLine("Güncelleme işlemi yapıldı!");
            }
            else
            {
                System.Console.WriteLine("Girdiğiniz kişi bilgilerine ait bir kişi rehberde bulunamadı!");
            }

        }
        else if (islemsonuc == 4) // Rehberi listeleme
        {
            Kisi.rehberiListele();
        }
        else if (islemsonuc == 5) // Rehberde arama yapma
        {
            System.Console.WriteLine("*******************************\nLütfen rehberde arama yapılacak kişinin ismini ve soyismini giriniz:");
            string isimsoyisim = Console.ReadLine();
            if (Kisi.kisiAra(isimsoyisim, out int kisiindeks))
            {
                System.Console.WriteLine("Kişi bulundu! Kişinin bilgileri:");
                Kisi.kisiBilgileriniGoster(kisiindeks);
            }
            else
            {
                System.Console.WriteLine("Aradığınız kişi bulunamadı!");
            }
        }
        else if (islemsonuc == 6) // Çıkış
        {
            System.Console.WriteLine("Çıkış yapılıyor...");
            break;
        }
        else
        {
            System.Console.WriteLine("Yanlış işlem numarası girildi!");
        }
    }
    else
    {
        System.Console.WriteLine("Lütfen sayı değeri giriniz!");
    }
}