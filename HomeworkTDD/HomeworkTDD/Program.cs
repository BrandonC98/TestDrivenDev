using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HomeworkTDD
{
    public class Program
    {

        private static int[] Expenses()
        {
            List<int> expensesList = new List<int>();
            StreamReader file = new StreamReader(@"C:\Users\Brandon\Documents\Sparta Global\Training\SDET weeks\Week 1\TestDrivenDev\HomeworkTDD\HomeworkTDDTest\Resources\ExpenseSheet.txt");
            string line;

            while ((line = file.ReadLine()) != null)
            {

                expensesList.Add(Convert.ToInt32(line));

            }

            file.Close();

            return expensesList.ToArray();

        }

        static void Main(string[] args)
        {
            //806656
            Console.WriteLine(GetProductOfEntries2020(Expenses()));

            //230608320
            Console.WriteLine(GetProductOfThreeEntries2020(Expenses()));

        }

        public static int GetProductOfEntries2020(int[] expenses)
        {

            foreach(var num in expenses)
            {

                var secondNum = 2020 - num;

                if(expenses.Contains(secondNum))
                {

                    return num * secondNum;

                }

            }

            return -1;

        }

        public static int GetProductOfThreeEntries2020(int[] expenses)
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
