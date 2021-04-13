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

        public static int GetProductOfThreeEntriesThatEqual2020(int[] expenses)
        {

            foreach(var num1 in expenses)
            {

                foreach(var num2 in expenses)
                {

                    foreach(var num3 in expenses)
                    {

                        if(num1 + num2 + num3 == 2020)
                        {

                            return num1 * num2 * num3;

                        }

                    }

                }

            }

            return -1;

        }

    }
}
