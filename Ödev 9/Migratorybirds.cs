static int migratoryBirds(List<int> arr)
    {   
       Dictionary<int,int> frekansSozluk = new Dictionary<int, int>();
       foreach(var item in arr) // Hangi sayıdan kaç tane var sözlüğe ekledik
       {
        if(frekansSozluk.ContainsKey(item))
        {
            frekansSozluk[item]++;
        }
        else
        {
            frekansSozluk.Add(item,1);
        }
       } 
       int maxdeger = 0;
       foreach (var item in frekansSozluk)
       {
            if(item.Value>maxdeger)
            {
                maxdeger = item.Value;
            }
       }
       List<int> maxFrekanslar = new List<int>();
       foreach (var item in frekansSozluk)
       {
        if(item.Value == maxdeger)
        {
            maxFrekanslar.Add(item.Key);
        }
       }
       return maxFrekanslar.Min();

    }

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);
        System.Console.WriteLine(result);