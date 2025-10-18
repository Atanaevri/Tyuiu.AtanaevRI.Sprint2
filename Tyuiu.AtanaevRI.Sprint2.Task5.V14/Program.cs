using Tyuiu.AtanaevRI.Sprint2.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите номер дня года (от 1 до 365): ");
        string inputK = Console.ReadLine();

        Console.Write("Введите день недели 1 января (1-понедельник, 7-воскресенье): ");
        string inputD = Console.ReadLine();

        if (int.TryParse(inputK, out int k) && int.TryParse(inputD, out int d))
        {
            DataService ds = new DataService();
            string result = ds.FindDayName(k, d);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"{k}-й день невисокосного года - {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите целые числа.");
        }

        Console.ReadKey();
    }
}
}
