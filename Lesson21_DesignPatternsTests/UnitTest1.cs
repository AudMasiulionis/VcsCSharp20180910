using System;
using Lesson21_DesignPatterns.Singletons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson21_DesignPatternsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var singleton = Singleton.Instace;
            var singleton1 = Singleton.Instace;

            Assert.AreSame(singleton, singleton1);
        }
    }
}
