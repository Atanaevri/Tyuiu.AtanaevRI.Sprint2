using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AtanaevRI.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 46;
            res[1] = x != y;
            res[2] = x < y + 100;
            res[3] = x > y + 500;
            res[4] = x <= y ;
            res[5] = x >= y + 500;
            return res;

        }
    }
}




