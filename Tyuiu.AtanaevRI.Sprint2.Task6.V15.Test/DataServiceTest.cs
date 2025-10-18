using Tyuiu.AtanaevRI.Sprint2.Task6.V15.Lib;

namespace Tyuiu.AtanaevRI.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            // 1 января - понедельник
            Assert.AreEqual("Понедельник", ds.FindDayName(1));

            // 2 января - вторник
            Assert.AreEqual("Вторник", ds.FindDayName(2));

            // 7 января - воскресенье
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            // 8 января - понедельник (новая неделя)
            Assert.AreEqual("Понедельник", ds.FindDayName(8));

            // 14 января - воскресенье
            Assert.AreEqual("Воскресенье", ds.FindDayName(14));

            // 31 декабря (365-й день) - воскресенье
            Assert.AreEqual("Воскресенье", ds.FindDayName(365));

            // 30 декабря (364-й день) - суббота
            Assert.AreEqual("Суббота", ds.FindDayName(364));
        }

        [TestMethod]
        public void InvalidFindDayName()
        {
            DataService ds = new DataService();

            // Проверка граничных значений
            string result1 = ds.FindDayName(0);
            string result2 = ds.FindDayName(366);

            Assert.IsTrue(result1.Contains("Ошибка"));
            Assert.IsTrue(result2.Contains("Ошибка"));
        }
    }
}
