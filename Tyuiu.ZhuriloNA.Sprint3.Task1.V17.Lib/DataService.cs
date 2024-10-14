using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZhuriloNA.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            int i = startValue;
            while (i <= startValue) 
            {
                result *= Math.Pow(2 / Math.Cos(value), i);
                i++;
            }
            return Math.Round(result, 3);
        }
    }
}
