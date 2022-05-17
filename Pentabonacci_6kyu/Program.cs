public class Pentabonacci
{
    static void Main(string[] args)
    {
        int n = 1;



        Console.WriteLine($"Result of {n}-th fib = {CountOddPentaFib(n)} ");
    }


    public static long CountOddPentaFib(long n)
    {   
        int counter = 0;

        var x = 0;
        var y = 1;
        var z = 1;
        var f = 2;
        var g = 4;

       


        for(int i = 0; i < n; i++)
        {
            g = x + y + z + f + g;
            f = g - f - z - y - x; 
            z = g - f - z - y - x;
            y = g - f - z - y - x;
            x = g - f - z - y - x;

            if (x % 2 != 0) counter++;
        }

        if (n >= 2) return --counter;
        return counter;
    }
}