using Tyuiu.AtanaevRI.Sprint2.Task0.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 205;
        int y = 159;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.Title = "Спринт #2 | Выполнил: Атанаев Р.И. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                             *");
        Console.WriteLine("* Тема: Операции Сравнения                            *");
        Console.WriteLine("* Задание #0                                                            *");
        Console.WriteLine("* Вариант #25                                                            *");
        Console.WriteLine("* Выполнил: Атанаев Р.И. | РППб-25-1                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*  Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений, которая вернет логическую последовательность(массив): (True, True, True, False, False, False), при x = 205, y = 159   *");
        Console.WriteLine("*                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("X = " + x);
        Console.WriteLine("X = " + y);
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}