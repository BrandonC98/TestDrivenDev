using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkTDD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int GetSumOfEntries2020(int[] expenses)
        {

            foreach(var num in expenses)
            {

                var secondNum = 2020 - num;

                if(expenses.Contains(secondNum))
                {

                    return num * secondNum;

                }

            }

            return 0;

        }

    }
}
