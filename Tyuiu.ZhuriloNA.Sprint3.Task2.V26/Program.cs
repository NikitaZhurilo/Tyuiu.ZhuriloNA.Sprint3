using Tyuiu.ZhuriloNA.Sprint3.Task2.V26.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task2.V26
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
            Console.WriteLine("* Задание #2                                                                  *");
            Console.WriteLine("* Вариант #17                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет             *");
            Console.WriteLine("* произведение ряда по формуле, при х=0,25                                    *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int startValue, stopValue;
            double value;
            Console.WriteLine("Введите начальное значение : ");
            startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение : ");
            stopValue = Convert.ToInt32(Console.ReadLine());
            value = 0.25;
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
