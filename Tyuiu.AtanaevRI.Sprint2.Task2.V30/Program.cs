using Tyuiu.AtanaevRI.Sprint2.Task2.V30.Lib;
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
       
        bool res = ds.CheckDotInShadedArea(x, y);
      
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }
            Console.ReadKey();
    }
}