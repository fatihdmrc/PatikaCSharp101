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

class Sonuc2
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        var birdIdCounts = new Dictionary<int, int>();
        
        foreach(var birdId in arr)
        {
            if(birdIdCounts.ContainsKey(birdId))
            {
                birdIdCounts[birdId]++;
            }
            else
            {
                birdIdCounts[birdId] = 1;
            }
        }
        
        var maxValue = 0;
        
        foreach (var birdIdCount in birdIdCounts) {
            if(birdIdCount.Value > maxValue) {
                maxValue = birdIdCount.Value;
            }
        }
        
        var birdIdsWithMaxValue = new List<int>();
        
        foreach(var birdIdCount in birdIdCounts) {
            if(birdIdCount.Value == maxValue) {
                birdIdsWithMaxValue.Add(birdIdCount.Key);
            }
        }
        
        return birdIdsWithMaxValue.Min();
    }

}

class Cozum4
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Sonuc2.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
