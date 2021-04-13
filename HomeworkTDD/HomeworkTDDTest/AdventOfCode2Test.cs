using System;
using System.Collections.Generic;
using NUnit.Framework;
using HomeworkTDD;

namespace HomeworkTDDTest
{
    class AdventOfCode2Test
    {

        [Test]
        public void Return_ANumber()
        {

            //var expense = AdventOfCodeDay1Test.Expenses();

            Assert.That(Program.
                GetProductOfThreeEntriesThatEqual2020(new int[] { 2020, 0, 0 }),
                Is.EqualTo(0));

        }

        [TestCase(1000, 1000, 20)]
        [TestCase(2000, 0, 20)]
        [TestCase(10, 10, 2000)]
        public void Return_LotsOfNumbers(int num1, int num2, int num3)
        {

            Assert.That(Program.
                GetProductOfThreeEntriesThatEqual2020(new int[] { num1, num2, num3 }),
                Is.EqualTo(num1 * num2 * num3));

        }

    }
}
