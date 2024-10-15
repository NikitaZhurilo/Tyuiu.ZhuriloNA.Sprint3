using Tyuiu.ZhuriloNA.Sprint3.Task3.V23.Lib;
namespace Tyuiu.ZhuriloNA.Sprint3.Task3.V23
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
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #23                                                                 *");
            Console.WriteLine("* Выполнил Журило Никита Александрович | ИБКСб-24-1                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Условие                                                                     *");
            Console.WriteLine("* Используя цикл foreach заменить буквы s на цифру 8 в строке: fdsst siu vsrs *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Исходные данные:                                                            *");
            Console.WriteLine("*******************************************************************************");
            string value;
            char replaceable, replacement;
            Console.WriteLine("Введите значение, которое собираетесь заменить : ");
            replaceable = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите значение, которым хотите заменить прошлое значение : ");
            replacement = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите строку : ");
            value = Convert.ToString(Console.ReadLine());
            Console.WriteLine("* Результат:                                                                  *");
            Console.WriteLine("*******************************************************************************");
            value = ds.ReplaceCharOnNum(value, replaceable, replacement);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
