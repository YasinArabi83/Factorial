//یاسین عربی
//فاکتوریال عدد n 
int n =0;
Console.Write("enter a number :");
n = int.Parse(Console.ReadLine());
    long result = 1;

    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
Console.Write("Factorial: ");
Console.WriteLine( result);
