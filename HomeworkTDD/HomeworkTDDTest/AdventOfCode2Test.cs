using System;
using System.Collections.Generic;
using NUnit.Framework;
using HomeworkTDD;

namespace HomeworkTDDTest
{
    class AdventOfCode2Test
    {

        //what is the product of the three entries that sum to 2020?

        [Test]
        public void Returns_0_FromThreeNumbersThatEqual2020()
        {
            Assert.That(Program.
                GetProductOfThreeEntries2020(new int[] { 2020, 0, 0 }), Is.EqualTo(0));

        }

        [TestCase(1000, 1000, 20)]
        [TestCase(2000, 0, 20)]
        [TestCase(10, 10, 2000)]
        public void Returns_TheProductOfThreeNumbersThatEqual2020(int num1, int num2, int num3)
        {

            Assert.That(Program.
                GetProductOfThreeEntries2020(new int[] { num1, num2, num3 }),
                Is.EqualTo(num1 * num2 * num3));

        }

    }
}
