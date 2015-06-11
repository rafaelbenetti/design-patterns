﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.Strategy.Animals;

namespace DesignPatterns.Test.TestDrivenDevelopment.BehavioralPatterns.Strategy
{
    [TestClass]
    public class SpiderTest
    {
        [TestMethod]
        [TestCategory("Strategy")]
        public void Validate_Number_Of_Legs_Spider()
        {
            Animal spider = new Spider();
            Assert.AreEqual(8, spider.GetNumberOfLegs());
        }
    }
}
