Satir yapilacaklar = new Satir("YAPILACAKLAR", 1); // Yapılacaklar satırı oluşturuldu
Satir devameden = new Satir("DEVAM EDEN GÖREVLER", 2); // Devam eden görevler satırı oluşturuldu
Satir tamamlanan = new Satir("TAMAMLANAN GÖREVLER", 3); // Tamamlanan görevler satırı oluşturuldu
TakimUye yonetici = new TakimUye(1, "Fatih", "Demirci"); // Yönetici takım üyesi oluşturuldu
TakimUye uye1 = new TakimUye(2, "Ali", "Demirci"); // Yönetici takım üyesi oluşturuldu
Kart tanimlikart = new Kart("Deneme Başlık", "Deneme içerik", yonetici, Buyukluk.XS, yapilacaklar); // Tanımlı kart oluşturuldu
yapilacaklar.satiraKartEkle(tanimlikart);
while (true)
{
    System.Console.WriteLine("----------- Lütfen yapılacak işlemi seçiniz -----------\n(1) Tüm kartları listele\n(2) Kart ekle\n(3) Kart sil\n(4) Kart taşı\n---------------------- ");
    string islemno = Console.ReadLine();
    System.Console.WriteLine("----------------------");
    if (Int32.TryParse(islemno, out int islem)) // Kullanıcı eğer işlem numarasını sayısal bir ifade girdiyse
    {
        switch (islem)
        {
            case 1: // Tüm kartları listele
                {
                    yapilacaklar.satirdakiKartlariGoster();
                    devameden.satirdakiKartlariGoster();
                    tamamlanan.satirdakiKartlariGoster();
                    break;
                }
            case 2: // Kart ekle
                {
                    bool karteklemedurum = true;
                    System.Console.WriteLine("Lütfen başlığı girin:");
                    string baslik = Console.ReadLine();
                    System.Console.WriteLine("Lütfen içeriği girin:");
                    string icerik = Console.ReadLine();
                    System.Console.WriteLine("Atanacak kişinin id sini girin:");
                    int atanankisiid = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Büyüklüğü girin:XS (1) - S (2) - M (3) - L (4) , XL (5)");
                    string buyukluk = Console.ReadLine();
                    if (!(Int32.TryParse(buyukluk, out int dbuyukluk))) // Girilen büyüklük değeri sayısal mı
                    {
                        System.Console.WriteLine("Hatalı büyüklük değeri girildi!");
                        karteklemedurum = false;
                    }
                    if (!(dbuyukluk >= 1 && dbuyukluk <= 5)) // Büyüklük değeri doğru mu girildi?
                    {
                        System.Console.WriteLine("Büyüklük değeri istenilen aralıkta değil!");
                        karteklemedurum = false;
                    }
                    TakimUye gecici = new TakimUye();
                    foreach (var item in TakimUye.takimlistesi) // Atanan kişi id eşleme
                    {
                        if (item.Id == atanankisiid)
                        {
                            karteklemedurum = true;
                            gecici = item; // id eşlemesi yapıldı
                            break;
                        }
                        else
                        {
                            karteklemedurum = false; // id eşlemesi başarısız
                        }
                    }
                    if (karteklemedurum == true)
                    {
                        System.Console.WriteLine("Kart ekleme işlemi gerçekleştiriliyor...");
                        Kart yenikart = new Kart(baslik, icerik, gecici, (Buyukluk)dbuyukluk, yapilacaklar);
                        System.Console.WriteLine("Kart ekleme işlemi tamamlandı!");
                        yapilacaklar.satiraKartEkle(yenikart);
                        System.Console.WriteLine("---------------------- ");
                    }
                    else
                    {
                        System.Console.WriteLine("Bilgiler girilirken yanlış bilgi girildi! Lütfen tekrar deneyin..");
                    }
                    break;
                }
            case 3: // Kart sil
                {
                    System.Console.WriteLine("Lütfen silmek istediğiniz kartın başlığını yazınız:");
                    string kartbaslik = Console.ReadLine();
                    if (Kart.kartAra(kartbaslik, out Kart bulunankart))
                    {
                        System.Console.WriteLine("Silinecek kart bulundu. Bulunan kartın bilgileri:");
                        System.Console.WriteLine("Bulunan kartın başlığı:" + bulunankart.Baslik + "\n" + "Bulunan kartın içeriği:" + bulunankart.Icerik + "\nBulunan karta atanan kişi:" + bulunankart.getAtananKisi().Isım + " " + bulunankart.getAtananKisi().SoyIsım);
                        System.Console.WriteLine("Kart silme işlemi gerçekleştiriliyor...");
                        Kart.kartSil(bulunankart);
                        bulunankart.getBulunduguSatir().satirdanKartSil(bulunankart);
                    }
                    break;
                }
            case 4: //Kart taşı
                {
                    System.Console.WriteLine("Lütfen taşımak istediğiniz kartın başlığını yazın:");
                    string kbaslik = Console.ReadLine();
                    System.Console.WriteLine("Hangi satıra taşımak istiyorsunuz? 1(Yapılacaklar) 2(Şuan yapılmaya devam eden görevler) 3(Tamamlanan görevler)");
                    int satirno = Convert.ToInt32(Console.ReadLine());
                    if (Kart.kartAra(kbaslik, out Kart bulunankart))
                    {
                        if (satirno == 1)
                        {
                            bulunankart.getBulunduguSatir().satirDegistir(bulunankart, yapilacaklar);
                            System.Console.WriteLine("Kart" + yapilacaklar.Isım + " satırına taşındı!");
                        }
                        else if (satirno == 2)
                        {
                            bulunankart.getBulunduguSatir().satirDegistir(bulunankart, devameden);
                            System.Console.WriteLine("Kart" + devameden.Isım + " satırına taşındı!");
                        }
                        else if (satirno == 3)
                        {
                            bulunankart.getBulunduguSatir().satirDegistir(bulunankart, tamamlanan);
                            System.Console.WriteLine("Kart" + tamamlanan.Isım + " satırına taşındı!");
                        }
                        else
                        {
                            System.Console.WriteLine("Satır değiştirme işleminde hata oluştu!");
                        }
                    }
                    break;
                }
        }
    }
    else // Kullanıcı işlem numarasını sayısal bir ifade girmediyse
    {
        System.Console.WriteLine("İşlem numarası geçersiz!");
    }
}