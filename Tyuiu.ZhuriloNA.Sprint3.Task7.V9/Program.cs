using System.ComponentModel.DataAnnotations;
using Tyuiu.ZhuriloNA.Sprint3.Task7.V9.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил Журило Н. А. | ИБКСб-24-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                            *");
            Console.WriteLine("* Задание #8                                                                  *");
            Console.WriteLine("* Вариант #9                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции (произвести    *");
            Console.WriteLine("* табулирование) на заданном диапазоне [-5; 5] с шагом 1. Произвести          *");
            Console.WriteLine("* проверку деления на ноль.                                                   *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            int startValue, stopValue;
            Console.WriteLine("Введите начальное значение : ");
            startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное значение : ");
            stopValue = Convert.ToInt32(Console.ReadLine());
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] array; 
            array = new double[len];
            array = ds.GetMassFunction(startValue, stopValue); 
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++) 
            {
                Console.WriteLine("|{0, 5:d}   |  {1, 5:f2}   |", startValue, array[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
