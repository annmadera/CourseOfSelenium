using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseOfSelenium
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public int Add(int valueA, int valueB)
        {
            return valueA + valueB;
        }
    }
}
