using Tyuiu.AtanaevRI.Sprint2.Task4.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Введите Значение Х");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Введите Значение Y");
        int y = Convert.ToInt32(Console.ReadLine());

        double res = ds.Calculate(x, y);

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Значение Функции=" + res);
        Console.ReadKey();
    }
}