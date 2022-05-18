using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exclusion.method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {


                Console.WriteLine("Введите первое число");
                string Temp = Console.ReadLine();
                int i = Int32.Parse(Temp);

                Console.WriteLine("Введите второе число");
                Temp = Console.ReadLine();
                int j = Int32.Parse(Temp);
                
                int k = i / j;
                Console.WriteLine("The result of dividing {0} by {1} is {2}", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}" , e );
            }
            
        }
}  }

