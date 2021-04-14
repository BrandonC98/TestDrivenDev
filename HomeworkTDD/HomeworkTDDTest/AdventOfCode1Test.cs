using NUnit.Framework;
using HomeworkTDD;
using System;
using System.IO;
using System.Collections.Generic;

namespace HomeworkTDDTest
{
    public class AdventOfCode1Test
    {

        //Find the two entries that sum to 2020,
        //what do you get if you multiply them together?

        [Test]
        public void Returns_0_FromTwoNumbersThatEqual2020()
        {

            Assert.That(Program.GetProductOfEntries2020(new int[] { 2020, 0}), Is.EqualTo(0));

        }

        [TestCase(1010, 1010)]
        [TestCase(1520, 500)]
        [TestCase(100, 1920)]
        public void Returns_TheProductOfTwoNumbersThatEqual2020(int num1, int num2)
        {

            Assert.That(Program.GetProductOfEntries2020(new int[] { num1, num2 }), Is.EqualTo(num1 * num2));

        }

        [Test]
        public void Return_MinusOneIfNoTheInputDoesntEqual2020()
        {

            Assert.That(Program.GetProductOfEntries2020(new int[] { 100, 1700 }), Is.EqualTo(-1));

        }

    }
}