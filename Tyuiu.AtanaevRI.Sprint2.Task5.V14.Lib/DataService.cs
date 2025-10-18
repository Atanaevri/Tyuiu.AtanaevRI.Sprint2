using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AtanaevRI.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
            {
                return "Ошибка: число должно быть от 1 до 365.";
            }

            string dayOfWeek = (k % 7) switch
            {
                0 => "Воскресенье",
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                _ => "Ошибка"
            };

            return dayOfWeek;
        }
    }
}
