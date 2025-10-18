using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AtanaevRI.Sprint2.Task5.V14.Lib
{
    public class DataService
    {
        /// <summary>
        /// Определяет день недели для k-го дня года
        /// </summary>
        /// <param name="k">День года (1-365)</param>
        /// <param name="d">День недели 1 января (1-7)</param>
        /// <returns>Название дня недели</returns>
        public static string CalculateDayOfWeek(int k, int d)
        {
            // Проверка корректности входных данных
            if (k < 1 || k > 365)
                throw new ArgumentException("k должно быть в диапазоне 1-365");

            if (d < 1 || d > 7)
                throw new ArgumentException("d должно быть в диапазоне 1-7");

            // Вычисляем день недели для k-го дня
            // (d-1) потому что отсчет начинаем с 0 для удобства вычислений
            int dayOfWeek = (d - 1 + k - 1) % 7;

            // Используем switch для определения названия дня недели
            switch (dayOfWeek)
            {
                case 0:
                    return "понедельник";
                case 1:
                    return "вторник";
                case 2:
                    return "среда";
                case 3:
                    return "четверг";
                case 4:
                    return "пятница";
                case 5:
                    return "суббота";
                case 6:
                    return "воскресенье";
                default:
                    throw new InvalidOperationException("Ошибка вычисления дня недели");
            }
        }
    }
}



