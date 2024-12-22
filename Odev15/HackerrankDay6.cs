using System;
using System.Collections.Generic;
using System.IO;
public static class Solution {
    public static string ciftIndeksleriGetir(this string deger) 
    {   
        string yeni="";
        for (int i=0; i<deger.Length; i=i+2)
        {
           yeni = yeni + deger[i];
        }
        return yeni;
    }
    public static string tekIndeksleriGetir(this string deger) 
    {
        string yeni = "";
         for (int i=1; i<deger.Length; i=i+2)
        {
           yeni = yeni + deger[i];
        }
        return yeni;
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string[] kelimeler = new string[n];
        for(int i=0; i<n; i++) 
        {
            kelimeler[i]= Console.ReadLine();
        }
        for(int i=0; i<n; i++)
        {
            Console.WriteLine(kelimeler[i].ciftIndeksleriGetir()+" "+kelimeler[i].tekIndeksleriGetir());
        }
        
    }
}