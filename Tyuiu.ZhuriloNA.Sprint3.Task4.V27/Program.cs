using Tyuiu.ZhuriloNA.Sprint3.Task4.V27.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double res;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Журило Н. А. | ИБКСб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #27                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение         *");
            Console.WriteLine("* функции y=x/(cos(x)+sin(x)) При х = 0 пропустить значение.                  *");
            Console.WriteLine("* Полученные значения суммировать.                                            *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int startValue, stopValue;
            Console.WriteLine("Введите начальное значение : ");
            startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение : ");
            stopValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.Calculate(startValue, stopValue);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
