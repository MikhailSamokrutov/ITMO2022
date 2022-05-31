using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTMO.calendar._2022
{
    enum MonthName

    {

        January, February, March, April, May, June, July, August, September, October, November, December
    }
    internal class WhatDay
    {
        
        
            static System.Collections.ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
           static void Main(string[] args)
            {
                Console.WriteLine("Введите число от 1 до 365");
                string line = Console.ReadLine();
                int dayNum = int.Parse(line);
                int monthNum = 0;
                
                foreach (int daysInMonth in DaysInMonths)
                {
                if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;

                    }
                }
                

                

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);

                
            }
        
    }
}
