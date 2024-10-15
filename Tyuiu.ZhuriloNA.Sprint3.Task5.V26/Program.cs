using Tyuiu.ZhuriloNA.Sprint3.Task5.V26.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task5.V26
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
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #26                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("*                                 -                                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int x, startValue1, startValue2, stopValue1, stopValue2;
            x = 2;
            Console.WriteLine("Введите первое начальное значение : ");
            startValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое конечное значение : ");
            stopValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе начальное значение : ");
            startValue2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе конечное значение : ");
            stopValue2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
