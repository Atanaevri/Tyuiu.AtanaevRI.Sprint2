using Tyuiu.AtanaevRI.Sprint2.Task5.V14.Lib;
namespace Tyuiu.AtanaevRI.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            // Тестируем для случая, когда 1 января - понедельник (d=1)
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));    // 1 января
            Assert.AreEqual("Вторник", ds.FindDayName(2, 1));        // 2 января
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));    // 7 января
            Assert.AreEqual("Понедельник", ds.FindDayName(8, 1));    // 8 января
            Assert.AreEqual("Воскресенье", ds.FindDayName(365, 1));  // 31 декабря

            // Тестируем для случая, когда 1 января - среда (d=3)
            Assert.AreEqual("Среда", ds.FindDayName(1, 3));          // 1 января
            Assert.AreEqual("Четверг", ds.FindDayName(2, 3));        // 2 января
            Assert.AreEqual("Вторник", ds.FindDayName(7, 3));        // 7 января
        }

        [TestMethod]
        public void InvalidFindDayName()
        {
            DataService ds = new DataService();

            // Проверка граничных значений для k
            string result1 = ds.FindDayName(0, 1);
            string result2 = ds.FindDayName(366, 1);

            // Проверка граничных значений для d
            string result3 = ds.FindDayName(1, 0);
            string result4 = ds.FindDayName(1, 8);

            Assert.IsTrue(result1.Contains("Ошибка"));
            Assert.IsTrue(result2.Contains("Ошибка"));
            Assert.IsTrue(result3.Contains("Ошибка"));
            Assert.IsTrue(result4.Contains("Ошибка"));
        }
    }
}

