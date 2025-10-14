using Tyuiu.AtanaevRI.Sprint2.Task4.V4.Lib;
namespace Tyuiu.AtanaevRI.Sprint2.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = -1;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 7.159;
            Assert.AreEqual(wait ,res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = -1;
            double res = ds.Calculate(x, y);
            double wait = 4.540;
            Assert.AreEqual(wait, res);
        }
    }
}
