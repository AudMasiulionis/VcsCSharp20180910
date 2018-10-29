using System;
using Lesson21_DesignPatterns.Singletons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson21_DesignPatternsTests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void ShouldReturnSameInstace()
        {
            var singleton = Singleton.Instace;
            var singleton1 = Singleton.Instace;

            Assert.AreSame(singleton, singleton1);
        }
    }
}
