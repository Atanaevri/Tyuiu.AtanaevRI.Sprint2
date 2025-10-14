using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AtanaevRI.Sprint2.Task3.V30.Lib
{
    public class DataService : ISprint2Task3V30
    {
        public double Calculate(double x)
        {
            double y=0;
            if (x>1)
            {
               y = Math.Round(x * (Math.Pow((x + 1) / (x - 1), x)), 3);
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) - Math.Pow(Math.Cos(x),2) - 3) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) - 2);
                }
                else
                {
                    if (-34 < x && x < 2)
                    {
                        y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
                    }
                    else
                    {
                        if (x < - 34)
                        {
                            y = Math.Round(x + 10 * x - (1 / x),3);
                        }
                    }


                }




        
            }
            return Math.Round(y, 3);
        }

    }
}
