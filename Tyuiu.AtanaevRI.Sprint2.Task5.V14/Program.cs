using Tyuiu.AtanaevRI.Sprint2.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Программа определения дня недели по номеру дня в году");
        Console.WriteLine("=====================================================");

        try
        {
            // Ввод данных
            Console.Write("Введите номер дня в году (k, 1-365): ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВыберите день недели для 1 января:");
            Console.WriteLine("1 - понедельник");
            Console.WriteLine("2 - вторник");
            Console.WriteLine("3 - среда");
            Console.WriteLine("4 - четверг");
            Console.WriteLine("5 - пятница");
            Console.WriteLine("6 - суббота");
            Console.WriteLine("7 - воскресенье");
            Console.Write("Ваш выбор (d, 1-7): ");
            int d = int.Parse(Console.ReadLine());

            // Вычисление результата
            string result = DayOfWeekCalculator.CalculateDayOfWeek(k, d);

            // Вывод результата
            Console.WriteLine("\nРезультат:");
            Console.WriteLine($"==========");
            Console.WriteLine($"{k}-й день года является {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректное целое число!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
}
    
