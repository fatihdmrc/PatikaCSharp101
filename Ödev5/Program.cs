﻿ int N = Convert.ToInt32(Console.ReadLine().Trim());
        if(N%2==1)
        {
            Console.WriteLine("Weird");
        }
        else if(N>=2&&N<=5){
            Console.WriteLine("Not Weird");
        }
        else if(N>=6&&N<=20)
        {
            Console.WriteLine("Weird");
        }
        else if(N>20)
        {
            Console.WriteLine("Not Weird");
        }