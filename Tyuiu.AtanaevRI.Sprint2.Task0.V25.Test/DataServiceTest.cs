using Tyuiu.AtanaevRI.Sprint2.Task0.V25.Lib;
namespace Tyuiu.AtanaevRI.Sprint2.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, true, true, true, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
