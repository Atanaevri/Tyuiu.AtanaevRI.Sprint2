using Tyuiu.AtanaevRI.Sprint2.Task5.V14.Lib;
namespace Tyuiu.AtanaevRI.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFirstDay_Monday()
        {
            // 1 января - понедельник (d=1)
            string result = DayOfWeekCalculator.CalculateDayOfWeek(1, 1);
            Assert.AreEqual("понедельник", result);
        }

        [TestMethod]
        public void TestFirstDay_Sunday()
        {
            // 1 января - воскресенье (d=7)
            string result = DayOfWeekCalculator.CalculateDayOfWeek(1, 7);
            Assert.AreEqual("воскресенье", result);
        }

        [TestMethod]
        public void TestMiddleYear_Wednesday()
        {
            // 1 января - понедельник, 100-й день
            string result = DayOfWeekCalculator.CalculateDayOfWeek(100, 1);
            Assert.AreEqual("среда", result);
        }

        [TestMethod]
        public void TestLastDay_Thursday()
        {
            // 1 января - пятница (d=5), 365-й день
            string result = DayOfWeekCalculator.CalculateDayOfWeek(365, 5);
            Assert.AreEqual("четверг", result);
        }

        [TestMethod]
        public void TestWeekend_Saturday()
        {
            // 1 января - понедельник, 6-й день (суббота)
            string result = DayOfWeekCalculator.CalculateDayOfWeek(6, 1);
            Assert.AreEqual("суббота", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidK_Zero()
        {
            DayOfWeekCalculator.CalculateDayOfWeek(0, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidK_Over365()
        {
            DayOfWeekCalculator.CalculateDayOfWeek(366, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidD_Zero()
        {
            DayOfWeekCalculator.CalculateDayOfWeek(1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidD_Over7()
        {
            DayOfWeekCalculator.CalculateDayOfWeek(1, 8);
        }
    }
}
    

