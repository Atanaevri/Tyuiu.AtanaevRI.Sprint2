using Tyuiu.AtanaevRI.Sprint2.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите номер дня года (от 1 до 365): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int k))
        {
            DataService ds = new DataService();
            string result = ds.FindDayName(k);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"{k}-й день невисокосного года (1 января - понедельник) - {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите целое число от 1 до 365.");
        }

        Console.ReadKey();
    }
}