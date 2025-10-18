
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AtanaevRI.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            if (k < 1 || k > 365)
            {
                return "Ошибка: число должно быть от 1 до 365.";
            }

            if (d < 1 || d > 7)
            {
                return "Ошибка: день недели должен быть от 1 до 7.";
            }

            // Вычисляем день недели для k-го дня
            // d - день недели 1 января (1-понедельник, 7-воскресенье)
            int dayOfWeek = (d - 1 + k - 1) % 7 + 1;

            string result = dayOfWeek switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Ошибка"
            };

            return result;
        }
    }
}
