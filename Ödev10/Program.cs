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