﻿using System;
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

    }
}
