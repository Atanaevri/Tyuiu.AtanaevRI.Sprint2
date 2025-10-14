using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AtanaevRI.Sprint2.Task4.V4.Lib
{
    public class DataService : ISprint2Task4V4
    {
        public double Calculate(double x, double y)
        {
            Double z = x + 2 < y ? Math.Sin(x) + 2 * y : Math.Cos(y) + 2 * x * y;
            return Math.Round(z, 3);
        }
    }
}
