using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace MyProduct.Logic.UnitTests
{
    [TestFixture]
    public class MyCalculatorTests
    {
        [Test]
        public void Add_TwoNumbers_ReturnSum()
        {
            MyCalculator c = GetNewCalc();

            int result = c.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void Add_FirstParamNegative_Throw()
        {
            MyCalculator c = GetNewCalc();

            int ANY_POSITIVE = 1;

            Assert.Throws<Exception>(() => c.Add(-1, ANY_POSITIVE));
        }

        private static MyCalculator GetNewCalc()
        {
            return new MyCalculator();
        }
    }
}
