using System;

namespace ITMO.lab4.Ex1._2022
{
    internal class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;





        }
    }
    public class Test
    {
        public static void Main()
        {
         int x;
         int y;
         int greater;
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);


        }






    }
    
}
