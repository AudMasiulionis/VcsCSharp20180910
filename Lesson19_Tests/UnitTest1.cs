using System;
using Lesson19_EventsAndGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson19_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod1()
        {
            var result = Mapper.MapIntToGender(10);
        }
    }
}
