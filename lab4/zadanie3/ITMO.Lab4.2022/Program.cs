using System;


namespace ITMO.Lab4._2022
{
    public class Utils
    {
        public static bool Factorial(out int answer, int n)
        {
            int k;
            int f;
            bool ok = true;
            if (n < 0)
                ok = false;
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;

            }
            answer = f;
            return ok;


        }
    }
    public class Test
    {


         static void Main(string[] args)
         {
            int x;
            int f;
            bool ok;

            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(out f, x);
            if  (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
            }
    }
    
}
