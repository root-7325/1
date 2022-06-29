using System;
class Shivanie
{
    static void Main()
    {

        Console.WriteLine("Input int, then float number");
        int number = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        double number4 = Convert.ToDouble(number2);
        double number3 = 0;
        while (number4 >= 1) number4 /= 10;
        number3 = number4 + number;
        Console.WriteLine(number3);
        Console.ReadKey(true);
    }
}
