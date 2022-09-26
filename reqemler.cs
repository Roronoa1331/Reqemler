using System;

class Program {
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int f = 1;
        while(n >= 10)
        {
            n /= 10;
            f++;
        }
        Console.WriteLine(f);
    }
}
