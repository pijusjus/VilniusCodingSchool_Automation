using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void Division993Test()
        {
            int expectedResult = 0;

            double actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void WendesdayTest()
        {

            var currentTime = DateTime.Now;

            if (currentTime.DayOfWeek == DayOfWeek.Wednesday)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void ThirteenthHourTest()
        {
            var currentTime = DateTime.Now;


            if (currentTime.Hour == 13)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void EqualNumbersTest()
        {
            int count = 0;

            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }

            Assert.AreEqual(4, count);
        }
    }
}
