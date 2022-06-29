using System;
class Shivanie
{
    static void Main()
    {
        int a1;
        int a2;
        double a3 = 0;
        double a4;
        double a5;
        Console.WriteLine("Input celoe chislo a potom ego drobnyu chast\n");
        a1 = Convert.ToInt32(Console.ReadLine());
        a2 = Convert.ToInt32(Console.ReadLine());
        a4 = Convert.ToDouble(a2);
        while (a4 > 0)
        {
            a3 = a4 / 100; //1000?10000?100000
            break;
        }
        a5 = a1 + a3;
        Console.WriteLine(a5);
        Console.ReadKey(true);
    }
}
