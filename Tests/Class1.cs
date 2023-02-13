using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
    public class HomeworkTests
    {
        [Test]
        public void Division993()
        {
            int expectedResult = 0;

            double actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Wendesday()
        {
            DayOfWeek expectedResult = DayOfWeek.Wednesday;

            DateTime now = DateTime.Now;
            DayOfWeek actualResult = DateTime.Now.DayOfWeek;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ThirteenthHour()
        {
            string expectedResult = "13:00";

            string actualResult = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
            string actualResultFormatted = DateTime.Now.ToString("HH:mm");

            Assert.AreEqual(expectedResult, actualResultFormatted);
        }

        [Test]
        public void EqualNumbers()
        {
            int count = 0;

            for (int i = 1; i <= 10; i++)
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
