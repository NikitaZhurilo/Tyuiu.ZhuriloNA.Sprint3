using Tyuiu.ZhuriloNA.Sprint3.Task1.V17.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task1.V17
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
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение     *");
            Console.WriteLine("* ряда по формуле, при х=1                                                    *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int startValue, stopValue, value;
            Console.WriteLine("Введите начальное значение : ");
            startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение : ");
            stopValue = Convert.ToInt32(Console.ReadLine());
            value = 1;
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
