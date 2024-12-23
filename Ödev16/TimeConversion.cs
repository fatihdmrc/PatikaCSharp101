using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string oglenbilgisi = s.Substring(8,2);
        int saat = Convert.ToInt32(s.Substring(0,2));
        string dakika = s.Substring(3,2);
        string saniye =s.Substring(6,2);
        if(oglenbilgisi=="PM")
        {
            if(saat!=12)
            {
                saat = saat+12;
            }
        }
        else{
            if(saat==12)
            {
                saat = 0;
            }
        }
        string donder = saat.ToString("00")+":"+dakika+":"+saniye;
        return donder;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
