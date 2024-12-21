System.Console.WriteLine("Faktöriyeli alınacak sayıyı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(factorial(sayi));
static int factorial(int n)
{
    if(n==0)
            {
                return 1;
            }
            else if(n==1)
            {
                return 1;
            }
            else {
            
                return  n*factorial(n-1) ;
            }
}