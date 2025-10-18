using System;
using Tyuiu.AtanaevRI.Sprint2.Task7.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение Х");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение У");
        double y = Convert.ToDouble(Console.ReadLine());
        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находиться в заштрихованной области");
                
        }
        else
        {
            Console.WriteLine("Точка не находиться в заштрихованной области");
        }
    }
}