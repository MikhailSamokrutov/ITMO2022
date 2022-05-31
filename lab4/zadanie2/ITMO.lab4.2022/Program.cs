using System;

namespace ITMO.lab4.Ex1._2022
{

    public class Utils
    {
        public static void Swap(ref int a, ref int b)
        {

            int temp = a;
            a = b;
            b = temp;

        }

    }
    public class Test
    {
        public static void Main()
        {
            int x;
            int y;

            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swap: " + x + ", " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + ", " + y);


        }
        
    }
    

}