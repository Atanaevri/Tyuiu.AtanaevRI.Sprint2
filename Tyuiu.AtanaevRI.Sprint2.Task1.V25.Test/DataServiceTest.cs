using Tyuiu.AtanaevRI.Sprint2.Task1.V25.Lib;
namespace Tyuiu.AtanaevRI.Sprint2.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 247;
            int b = 155;
            int c = 325;
            int d = 857;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
