// Hackerrank Staircase
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=n; i++)
     {
        for(int j=1; j<=n-i; j++) // Boşluk Basma
        {
            Console.Write(" ");
        }
        for(int k=1; k<=i;k++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
     }
// Hackerrank 30 Days of Code Day 5
 int a = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i=1; i<=10; i++)
        {
            Console.WriteLine(a+" x "+i+" = "+a*i);
        }