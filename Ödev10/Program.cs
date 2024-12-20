double buyuk = 0;
        double kucuk =0;
        double sifir =0;        
        foreach(int item in arr)
        {
            if(item>0)
            {
              buyuk=buyuk+1;      
            }
            else if(item<0)
            {
                kucuk=kucuk+1;
            }
            else if(item==0){
                sifir = sifir +1;
            }
        }
        double listeUzunluk = arr.Count;
        double buyukoran = buyuk / listeUzunluk;
        double kucukoran = kucuk / listeUzunluk;
        double sifiroran = sifir / listeUzunluk;
        Console.WriteLine(buyukoran.ToString("F6"));
        Console.WriteLine(kucukoran.ToString("F6"));
        Console.WriteLine(sifiroran.ToString("F6"));
        System.Console.WriteLine("Kaç adet sayı gireceksin?:");
    int adet = Convert.ToInt32(Console.ReadLine());
    List<int> sayilar = new List<int>();
    for(int i=0; i<adet; i++){
        System.Console.WriteLine("Lütfen "+(i+1)+". sayıyı girin:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        sayilar.Add(sayi);
    }
    oranHesaplayici(sayilar);
   