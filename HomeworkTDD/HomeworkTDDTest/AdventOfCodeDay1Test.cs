using NUnit.Framework;
using HomeworkTDD;
using System;
using System.IO;
using System.Collections.Generic;

namespace HomeworkTDDTest
{
    public class AdventOfCodeDay1Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Returns_2020()
        {

            Assert.That(Program.GetSumOfEntries2020(new int[] { 2020, 0}), Is.EqualTo(0));

        }

        [TestCase(1010, 1010)]
        [TestCase(1520, 500)]
        public void Returns_TheSumOf_TwoNumbers2(int num1, int num2)
        {

            Assert.That(Program.GetSumOfEntries2020(new int[] { num1, num2 }), Is.EqualTo(num1 * num2));

        }

        [Test]
        public void Test2()
        {

            var expenses = Expenses();

            Assert.That(Program.GetSumOfEntries2020(expenses), Is.EqualTo(806656));

        }

        public static int[] Expenses()
        {
            List<int> expensesList = new List<int>();
            StreamReader file = new StreamReader(@"C:\Users\Brandon\Documents\Sparta Global\Training\SDET weeks\Week 1\HomeworkTDD\HomeworkTDDTest\Resources\ExpenseSheet.txt");
            string line;

            while((line = file.ReadLine()) != null)
            {

                expensesList.Add(Convert.ToInt32(line));

            }

            file.Close();

            return expensesList.ToArray();

        }

    }
}